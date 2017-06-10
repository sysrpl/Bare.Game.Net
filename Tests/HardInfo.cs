using System;
using Bare.Devices;
using static Bare.Game;
using static System.Console;

namespace Tests
{
    public class HardInfo
    {
		[STAThread]
		public static void Main(string[] args)
		{
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
            //var window = new TestWindow();
            //Run(window);
            WriteLine("done.");
		}

	}
}