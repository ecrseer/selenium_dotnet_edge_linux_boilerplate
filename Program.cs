using System;
using Microsoft.Edge.SeleniumTools;

namespace badotryEdge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

            // Launch Microsoft Edge (Chromium)
            var options = new EdgeOptions();
            options.UseChromium = true;
            var drver = new EdgeDriver(options);
            drver.Url="https://mbasic.facebook.com/";
		    drver.Navigate();
            Console.WriteLine("Start mobile mode and type enter");
        }
    }
}
