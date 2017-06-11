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
        private static bool init = false;

        /// <summary>
        /// Initializes video, keyboard, sounds and joysticks systems.
        /// </summary>
        /// <param name="multisamples">Multisamples determine anti-aliasing levels. Values can be 0, 2, 4, 8, 16.</param>
        /// <param name="dephtbits">Depth bits determines the precision of depth calucations. Values can be 16, 24, 32.</param>
        /// <param name="stencilbits">Stencil bits determines the level of stencil bits. Values can be 0, 8, 16.</param>
        public static bool Init(int multisamples = 0, int dephtbits = 24, int stencilbits = 0)
        {
            if (init)
                return true;
            SDL_GL_SetAttribute(SDL_GL_CONTEXT_PROFILE_MASK, SDL_GL_CONTEXT_PROFILE_ES);
            SDL_GL_SetAttribute(SDL_GL_CONTEXT_MAJOR_VERSION, 2);
            SDL_GL_SetAttribute(SDL_GL_CONTEXT_MINOR_VERSION, 0);
            SDL_GL_SetAttribute(SDL_GL_RED_SIZE, 8);
            SDL_GL_SetAttribute(SDL_GL_GREEN_SIZE, 8);
            SDL_GL_SetAttribute(SDL_GL_BLUE_SIZE, 8);
            SDL_GL_SetAttribute(SDL_GL_ALPHA_SIZE, 8);
            SDL_GL_SetAttribute(SDL_GL_ACCELERATED_VISUAL, 1);
            SDL_GL_SetAttribute(SDL_GL_DOUBLEBUFFER, 1);
            SDL_GL_SetAttribute(SDL_GL_DEPTH_SIZE, dephtbits);
            SDL_GL_SetAttribute(SDL_GL_STENCIL_SIZE, stencilbits);
            if (multisamples > 0)
            {
                SDL_GL_SetAttribute(SDL_GL_MULTISAMPLEBUFFERS, 1);
                SDL_GL_SetAttribute(SDL_GL_MULTISAMPLESAMPLES, multisamples);
            }
            SDL_Init(SDL_INIT_EVERYTHING);
            init = Displays.Count > 0;
            if (!init)
                SDL_Quit();
            return init;
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
            while (SDL_PollEvent(out e) > 0)
            {
                switch (e.type)
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
        public static bool Run(Window window)
        {
            if (running)
                return false;
            if (window == null)
                return false;
            if (!Init())
                return false;
            running = true;
            MainWindow = window;
            var created = window.CreateWindow();
            if (created)
                try
                {
                    events = new EventList();
                    while (ProcessEvents())
                    {
                        MainWindow.ProcessLoop(events);
                        Delay(2);
                    }
                }
                finally
                {
                    Quit();
                }
            return created;
        }

        public static void Quit()
        {
            if (running)
            {
                running = false;
                MainWindow.Dispose();
                MainWindow = null;
                SDL_Quit();
                init = false;
            }
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
