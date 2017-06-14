using System;

namespace Tests
{
    public class MainClass
    {
        [STAThread]
        public static void Main(string[] args)
        {
            if (!Bare.Game.Init())
            {
                Console.WriteLine("Unable to find a display");
                Console.WriteLine("done.");
                return;
            }
            Test03Window.Test();
        }
    }
}