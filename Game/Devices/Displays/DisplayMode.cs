using System;
using System.Linq;
using static Bare.Interop.SDL2;

namespace Bare.Devices
{
    #region DisplayMode
    /// <summary>
    /// Display mode is a class summarizing a displays color, dimensions, and refresh rate.
    /// </summary>
    public sealed class DisplayMode
    {
        /// <summary>
        /// Gets or sets the display pixel format flags.
        /// </summary>
        public uint Format { get; set; }
        /// <summary>
        /// Gets or sets the display width in pixels.
        /// </summary>
		public int Width { get; set; }
        /// <summary>
        /// Gets or sets the display height in pixels.
        /// </summary>
		public int Height { get; set; }
        /// <summary>
        /// Gets or sets the display refresh rate in cycles per second.
        /// </summary>
		public int RefreshRate { get; set; }

        public override string ToString()
        {
            return string.Format("[DisplayMode: Format={0}, Width={1}, Height={2}, RefreshRate={3}]",
                Format, Width, Height, RefreshRate);
        }
    }
    #endregion

    #region Displays List
    /// <summary>
    /// Display modes is a list of DisplayMode items for the current display.
    /// </summary>
    public sealed class DisplayModeList : DeviceList<DisplayMode>
    {
        private int display;

        internal DisplayModeList(int display)
        {
            this.display = display;
        }

        protected override DisplayMode GetItem(int index)
        {
            SDL_DisplayMode mode;
            SDL_GetDisplayMode(display, index, out mode);
            var d = new DisplayMode();
            d.Format = mode.format;
            d.Width = mode.w;
            d.Height = mode.h;
            d.RefreshRate = mode.refresh_rate;
            return d;
        }

        protected override int GetCount()
        {
            return SDL_GetNumDisplayModes(display);
        }

        /// <summary>
        /// Finds a matching display mode given a width, height, and refresh rate.
        /// <param name="Width">The width in pixels</param>
        /// <param name="Height">The height in pixels</param>
        /// <param name="RefreshRate">The refresh rate in cycles per second</param>
        /// </summary>
        public DisplayMode Closest(int Width, int Height, int RefreshRate = 60)
        {
            SDL_DisplayMode mode;
            mode.format = 0;
            mode.w = Width;
            mode.h = Height;
            mode.refresh_rate = RefreshRate;
            mode.driverdata = IntPtr.Zero;
            SDL_DisplayMode match;
            SDL_GetClosestDisplayMode(display, ref mode, out match);
            var closest = this.Where(m =>
                              m.Width == match.w &&
                              m.Height == match.h &&
                              m.RefreshRate == match.refresh_rate)
                       .FirstOrDefault();
            return closest ?? Current;
        }

        /// <summary>
        /// Gets the current display mode for the display.
        /// </summary>
        public DisplayMode Current
        {
            get
            {
                SDL_DisplayMode mode;
                SDL_GetCurrentDisplayMode(display, out mode);
                return this.Where(m =>
                                  m.Width == mode.w &&
                                  m.Height == mode.h &&
                                  m.RefreshRate == mode.refresh_rate)
                           .FirstOrDefault();

            }
        }

        /// <summary>
        /// Gets the display mode for the display when the game is not exclusive.
        /// </summary>
        public DisplayMode Desktop
        {
            get
            {
                SDL_DisplayMode mode;
                SDL_GetDesktopDisplayMode(display, out mode);
                return this.Where(m =>
                                  m.Width == mode.w &&
                                  m.Height == mode.h &&
                                  m.RefreshRate == mode.refresh_rate)
                           .FirstOrDefault();

            }
        }
    }
    #endregion
}
