﻿using System;
using Bare;
using Bare.Devices;

using static System.Console;
using static Bare.Game;
using static Bare.Interop.GLES20;

namespace Tests
{
    public class Test01Window : Window
    {
        public static void Test()
        {
            if (!Init())
            {
                WriteLine("Unable to find a display");
                WriteLine("done.");
                return;
            }
            WriteLine("Bare Game Hardware Information");
            WriteLine("------------------------------");
            WriteLine($"Number of displays: {Displays.Count}");
            foreach (var d in Displays)
            {
                WriteLine($"\t{d}");
                WriteLine($"\tPossible display modes: {d.Modes.Count}");
                foreach (var m in d.Modes)
                    WriteLine($"\t\t{m}");
                WriteLine("\tCurrent display mode:");
                WriteLine($"\t\t{d.Modes.Current}");
                WriteLine("\tClosest display mode:");
                WriteLine($"\t\t{d.Modes.Closest(1280, 0, 60)}");
            }
            WriteLine($"Number of video drivers: {VideoDrivers.Count}");
            foreach (var d in VideoDrivers)
                WriteLine($"\t{d}");
            WriteLine("Current video driver:");
            WriteLine($"\t{VideoDrivers.Current}");
            var window = new Test01Window();
            Run(window);
            WriteLine("done.");
        }

        protected override void ContextCreated()
        {
            WriteLine("OpenGL information:");
            WriteLine($"\tVendor: {glGetString(GL_VENDOR)}");
            WriteLine($"\tRenderer: {glGetString(GL_RENDERER)}");
            WriteLine($"\tVersion: {glGetString(GL_VERSION)}");
            WriteLine($"\n\tExtensions: {glGetString(GL_EXTENSIONS)}");
        }

        protected override void Logic(EventList events)
        {
            foreach (var e in events)
            {
                if (e is KeyboardEvent)
                {
                    var k = e as KeyboardEvent;
                    if (k.Code == KeyCode.Escape)
                        Game.Quit();
                }
            }
        }

        private int i = 0;

        private static float Flip(float f)
        {
            f = f - (float)Math.Floor(f);
            f = f * 2;
            if (f > 1) f = 2 - f;
            return f;
        }

        protected override void Render()
        {
            i++;
            float r = Flip(0.5f + i / 400.0f);
            float g = Flip(0.3f + i / 680.0f);
            float b = Flip(0.8f + i / 840.0f);
            glClearColor(r, g, b, 1);
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            SwapBuffers();
        }
    }
}
