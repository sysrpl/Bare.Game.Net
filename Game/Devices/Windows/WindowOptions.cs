using System;
namespace Bare.Devices
{
    /// <summary>
    /// Window style is used by window parameters when creating a windows.
    /// </summary>
    [Flags]
    public enum WindowOptions
    {
        /// <summary>
        /// Window starts maximized.
        /// </summary>
        Maximized,
        /// <summary>
        /// Window has no title bar or border.
        /// </summary>
        Borderless,
        /// <summary>
        /// Window starts centered in the desktop.
        /// </summary>
        Centered,
        /// <summary>
        /// Window starts with input focus and constrains mouse movement.
        /// </summary>
        GrabInput,
        /// <summary>
        /// Window is hidden from view.
        /// </summary>
        Hidden,
        /// <summary>
        /// Window can be resized.
        /// </summary>
        Sizable
    }
}
