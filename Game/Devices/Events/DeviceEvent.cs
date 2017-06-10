using System;

namespace Bare.Devices
{
    /// <summary>
    /// Device event is the base class for all device related events.
    /// </summary>
    public class DeviceEvent
    {
        /// <summary>
        /// The time stamp in seconds when the event occurred.
        /// </summary>
        public double Time { get; set; }
    }
}
