using System;

namespace Bare.Devices
{
    /// <summary>
    /// Keyboard event arguments store information related to a keyboard event.
    /// </summary>
    public class KeyboardEvent : DeviceEvent
    {
        /// <summary>
        /// State determines if the eevent is a key up or down event.
        /// </summary>
        public KeyState State { get; set; }
        /// <summary>
        /// Code gives the actual key trigggering the event.
        /// </summary>
        public KeyCode Code { get; set; }
        /// <summary>
        /// Mods lists the keyboard modifiers for the event.
        /// </summary>
        public KeyMods Mods { get; set; }
        /// <summary>
        ///  Repeat greater than zero indicates the key is being held.
        /// </summary>
        public int Repeat { get; set; }
    }
}
