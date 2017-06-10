using System;

using static Bare.Interop.GLES20;

namespace Bare.Devices
{
    public class TestWindow : Window
    {
        protected override void Logic(EventList events)
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
        }

        protected override void Render()
        {
            glClearColor(1, 0, 0, 1);
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            SwapBuffers();
        }
    }
}
