using System;

using static Bare.Interop.SDL2;

namespace Bare.Devices
{
    /// <summary>
    /// Key modifiers accompany a keyboard event.
    /// </summary>
    [Flags]
    public enum KeyMods : ushort
    {
        None = SDL_Keymod.KMOD_NONE,
        LeftShift = SDL_Keymod.KMOD_LSHIFT,
        RightShift = SDL_Keymod.KMOD_RSHIFT,
        LeftCtrl = SDL_Keymod.KMOD_LCTRL,
        RightCtrl = SDL_Keymod.KMOD_RCTRL,
        LeftAlt = SDL_Keymod.KMOD_LALT,
        RightAlt = SDL_Keymod.KMOD_RALT,
        LeftSuper = SDL_Keymod.KMOD_LGUI,
        RightSuper = SDL_Keymod.KMOD_RGUI,
        NumLock = SDL_Keymod.KMOD_NUM,
        CapLock = SDL_Keymod.KMOD_CAPS,
        Menu = SDL_Keymod.KMOD_MODE,
        Reserved = SDL_Keymod.KMOD_RESERVED,
        Ctrl = (SDL_Keymod.KMOD_LCTRL | SDL_Keymod.KMOD_RCTRL),
        Shift = (SDL_Keymod.KMOD_LSHIFT | SDL_Keymod.KMOD_RSHIFT),
        Alt = (SDL_Keymod.KMOD_LALT | SDL_Keymod.KMOD_RALT),
        Super = (SDL_Keymod.KMOD_LGUI | SDL_Keymod.KMOD_RGUI)
    }
}
