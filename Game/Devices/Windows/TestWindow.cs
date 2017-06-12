using System;

using static Bare.Interop.GLES20;

namespace Bare.Devices
{
    public class TestWindow : Window
    {
        private int seconds;

        protected override void Logic(EventList events, Stopwatch stopwatch)
        {
            foreach (var e in events)
            {
                if (e is KeyboardEvent)
                {
                    var k = e as KeyboardEvent;
                    Console.WriteLine(k.Code);
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
