using System;
using System.Collections;
using System.Collections.Generic;
using Bare.Devices;

using static Bare.Interop.SDL2;

namespace Bare
{
    /// <summary>
    /// The game class provides a connection between hardware and your game window.
    /// </summary>
    public static class Game
    {
        static Game()
        {
            SDL_Init(SDL_INIT_VIDEO);
        }

        /// <summary>
        /// Suspend execution for a specified number of milliseconds.
        /// </summary>
        /// <param name="milliseconds">Number of milliseconds to delay.</param>
        public static void Delay(uint milliseconds)
        {
            SDL_Delay(milliseconds);
        }

        private static bool running;
        private static EventList events;

        private static bool ProcessEvents()
        {
            events.Clear();
            SDL_Event e;
            while (SDL_WaitEventTimeout(out e, 5) != 0)
            {
                switch(e.type)
                {
                    case SDL_EventType.SDL_QUIT:
                        Quit();
                        break;
                    case SDL_EventType.SDL_KEYDOWN:
                    case SDL_EventType.SDL_KEYUP:
                        var k = new KeyboardEvent();
                        k.Code = (KeyCode)e.key.keysym.sym;
                        k.Time = 0;
                        k.State = e.key.state == SDL_PRESSED ? KeyState.Down : KeyState.Up;
                        events.Add(k);
                        break;
                }
            }
            return running;
        }

        public static Window MainWindow { get; private set; } = null;

        /// <summary>
        /// Run the game using a specified window.
        /// </summary>
        /// <param name="window">A user defined window containing game logic and render methods.</param>
        public static void Run(Window window)
        {
            if (running)
                return;
            if (window == null)
                return;
            MainWindow = window;
            window.CreateWindow();
            running = true;
            events = new EventList();
            while (ProcessEvents())
            {
                window.ProcessLoop(events);
                Delay(1);
            }
            window.Dispose();
        }

        public static void Quit()
        {
            if (running)
            {
                running = false;
            }
            SDL_Quit();
        }

        /// <summary>
        /// Gets a list of available displays.
        /// </summary>
        public static DisplayList Displays { get; private set; } = new DisplayList();

        /// <summary>
        /// Gets a list of available video drivers.
        /// </summary>
        public static VideoDriverList VideoDrivers { get; private set; } = new VideoDriverList();

        /* public IEnumerable<Joystick> Joysticks { get; }
        public Keyboard Keyboard { get; }
        public Mouse Mouse { get; }
        public Window Window { get; }*/
    }
}
