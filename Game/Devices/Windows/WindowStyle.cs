using System;
using Bare;
using Bare.Devices;
using Bare.Geometry;

namespace Bare.Devices
{
    /// <summary>
    /// Window style is used to create a game window.
    /// </summary>
    public class WindowStyle
    {
        /// <summary>
        /// Create the default window style.
        /// </summary>
        public WindowStyle()
        {
            DisplayMode = Game.Displays[0].Modes.Desktop;
        }

        /// <summary>
        /// Gets or sets the display mode used when window mode is exclusive.
        /// </summary>
        public DisplayMode DisplayMode { get; set; }

        /// <summary>
        /// Gets or sets the window mode for float, fullscreen, or exclusive.
        /// </summary>
        public WindowMode WindowMode { get; set; }

        /// <summary>
        /// The X position in pixels of the window helps determine the display.
        /// </summary>
        public int X { get; set; } = 0;

        /// <summary>
        /// The Y position in pixels of the window helps determine the display.
        /// </summary>
        public int Y { get; set; } = 0;

        /// <summary>
        /// Gets or sets the width of the window when floating.
        /// </summary>
        public int Width { get; set; } = 720;

        /// <summary>
        /// Gets or sets the height of the window when floating.
        /// </summary>
        public int Height { get; set; } = 480;

        /// <summary>
        /// Gets or sets the border creation of the window when floating.
        /// </summary>
        public bool Borderless { get; set; } = false;

        /// <summary>
        /// Gets or sets the caption of the window when floating.
        /// </summary>
        public string Caption { get; set; } = "Game Window";

        /// <summary>
        /// Gets or sets the automatic centering of at creation.
        /// </summary>
        public bool Centered { get; set; } = true;

        /// <summary>
        /// Gets or sets grabbed input of a window.
        /// </summary>
        public bool Maximized { get; set; } = false;

        /// <summary>
        /// Gets or sets grabbed input of a window.
        /// </summary>
        public bool InputGrabbed { get; set; } = false;

        /// <summary>
        /// Gets or sets the the ability to resize a floating window.
        /// </summary>
        public bool Sizable { get; set; } = true;

        /// <summary>
        /// Gets or sets the the the visibility of a window.
        /// </summary>
        public bool Visible { get; set; } = true;

        /// <summary>
        /// Gets or sets the multisampling level for the graphics context.
        /// </summary>
        public int Multisamples { get; set; } = 0;

        /// <summary>
        /// Gets or sets the number of depth buffer bits for the graphics context.
        /// </summary>
        public int DepthBits { get; set; } = 16;

        /// <summary>
        /// Gets or sets the number of stencil buffer bits for the graphics context.
        /// </summary>
        public int StencilBits { get; set; } = 0;
    }
}
