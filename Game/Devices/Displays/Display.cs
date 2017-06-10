using System;
using System.Collections;
using System.Collections.Generic;
using Bare.Geometry;
using static Bare.Interop.SDL2;

namespace Bare.Devices
{
    #region Display
    /// <summary>
    /// The display class provides information about a screen or monitor device.
    /// </summary>
    public sealed class Display
    {
        private int index;

        internal Display(int index)
        {
            this.index = index;
        }

        /// <summary>
        /// Gets the name of the display.
        /// </summary>
        public string Name
        {
            get
            {
                return SDL_GetDisplayName(index);
			}
                
        }

        /// <summary>
        /// Gets the width of the display in pixels.
        /// </summary>
        public int Width
        {
            get
            {
                SDL_Rect rect;
                SDL_GetDisplayBounds(index, out rect);
                return rect.w;
            }
        }

        /// <summary>
        /// Gets the height of the display in pixels.
        /// </summary>
		public int Height
		{
			get
			{
				SDL_Rect rect;
				SDL_GetDisplayBounds(index, out rect);
				return rect.h;
			}
		}

        /// <summary>
        /// Gets the bounding rectangle for the display.
        /// </summary>
        public RectI GetBounds()
        {
            SDL_Rect rect;
            SDL_GetDisplayBounds(index, out rect);
            return new RectI(rect.x, rect.y, rect.w, rect.h);
        }

        /// <summary>
        /// Gets the bounding rectangle for the display minus any taskbar or menus.
        /// </summary>
        public RectI GetUsableBounds()
        {
            SDL_Rect rect;
            SDL_GetDisplayUsableBounds(index, out rect);
            return new RectI(rect.x, rect.y, rect.w, rect.h);
        }

        private DisplayModeList modes;

        /// <summary>
        /// Gets a list of viable display modes for the display.
        /// </summary>
        public DisplayModeList Modes
        {
            get
            {
                return modes ?? (modes = new DisplayModeList(index));    
            }
        }

        public override string ToString()
        {
            return string.Format("[Display: Name={0}, Width={1}, Height={2}]", Name, Width, Height);
        }
	}
    #endregion

    #region Displays List
    /// <summary>
    /// Displays is a list of the available display items.
    /// </summary>
    public sealed class DisplayList : DeviceList<Display>
    {
		protected override Display GetItem(int index)
        {
            return new Display(index);
        }

		protected override int GetCount()
        {
                return SDL_GetNumVideoDisplays();
        }
    }
    #endregion
}