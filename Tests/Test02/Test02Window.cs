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
        public static void Test()
        {
            WriteLine("Bare Game DataBuffer Tests");
            WriteLine("--------------------------");
            Run(new Test02Window());
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
