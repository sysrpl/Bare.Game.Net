using System;
using static Bare.Interop.SDL2;

namespace Bare.Devices
{
    /// <summary>
    /// Stopwatch is used to track time in high resolution seconds.
    /// </summary>
    public class Stopwatch
    {
        static readonly double frequency;
        private int frames;
        private int frameRate;
        private int seconds;
        private UInt64 start;
        private UInt64 now;

        static Stopwatch()
        {
            frequency = SDL_GetPerformanceFrequency();
        }

        /// <summary>
        /// Create a new stopwatch instance.
        /// </summary>
        public Stopwatch()
        {
            Reset();
        }

        /// <summary>
        /// Reset the epoch to now setting time back to zero.
        /// </summary>
        public void Reset()
        {
            frames = 0;
            frameRate = 0;
            seconds = 0;
            start = now = SDL_GetPerformanceCounter();
        }

        /// <summary>
        /// Tick updates the current time and add one to the frame rate.
        /// </summary>
        public void Tick()
        {
            now = SDL_GetPerformanceCounter();
            var s = (int)Time;
            if (s > seconds)
            {
                int i = s - seconds;
                if (i < 1)
                    i = 1;
                frameRate = frames / i;
                frames = 1;
                seconds = s;
            }
            else
                frames++;
        }

        /// <summary>
        /// The number of whole seconds since the stopwatch was created or reset
        /// </summary>
        public int Seconds
        {
            get
            {
                return seconds;
            }
        }

        /// <summary>
        /// The high performance fractional seconds since the stopwatch was created or reset
        /// </summary>
        public double Time
        {
            get
            {
                return (now - start) / frequency;
            }
        }

        /// <summary>
        /// The frame rate euqla the number of times the watch ticked in the prior second.
        /// </summary>
        public int FrameRate
        {
            get
            {
                return frameRate; 
            }
        }
    }
}
