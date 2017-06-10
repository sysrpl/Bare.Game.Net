using static Bare.Interop.SDL2;

namespace Bare.Devices
{
    /// <summary>
    /// Window mode is used to make a window floating, fullscreen, or exclusive
    /// at a specific display mode.
    /// </summary>
    public enum WindowMode : uint
    {
        /// <summary>
        /// The window is floating on the desktop.
        /// </summary>
        Floating = 0,
        /// <summary>
        /// The window is covers the entire desktop.
        /// </summary>
        Fullscreen = SDL_WINDOW_FULLSCREEN_DESKTOP,
        /// <summary>
        /// The window is covers the  entire desktop, possibly switching the display mode.
        /// </summary>
        Exclusive = SDL_WINDOW_FULLSCREEN
    }
}
