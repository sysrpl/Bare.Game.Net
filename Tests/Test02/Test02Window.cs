﻿using System;
using Bare;
using Bare.Devices;
using Bare.Geometry;

using static System.Console;
using static Bare.Game;
using static Bare.Interop.GLES20;

namespace Tests
{
    public class Test02Window : Window
    {
<<<<<<< HEAD:Tests/Test02/Test02Window.cs
        public static void Test()
        {
            WriteLine("Bare Game DataBuffer Tests");
            WriteLine("--------------------------");
            Run(new Test02Window());
        }

        protected override void Logic(EventList events)
=======
        private int seconds;

        protected override void Logic(EventList events, Stopwatch stopwatch)
>>>>>>> 2fb7c6e1f524dfd707d1f6052118c26c152c1a4b:Game/Devices/Windows/TestWindow.cs
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
            if (stopwatch.Seconds > seconds)
            {
                seconds = stopwatch.Seconds;
                Console.WriteLine();
                Console.WriteLine($"Frame rate: {stopwatch.FrameRate}");
                Console.WriteLine();
            }
            if (stopwatch.Seconds > 10)
                Game.Quit();
        }

        private static float Flip(float f)
        {
            f = f - (float)Math.Floor(f);
            f = f * 2;
            if (f > 1) f = 2 - f;
            return f;
        }

        protected override void Render(Stopwatch stopwatch)
        {
            float i = (float)(stopwatch.Time * 60);
            float r = Flip(0.5f + i / 400.0f);
            float g = Flip(0.3f + i / 680.0f);
            float b = Flip(0.8f + i / 840.0f);
            glClearColor(r, g, b, 1);
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            SwapBuffers();
        }
    }
}
