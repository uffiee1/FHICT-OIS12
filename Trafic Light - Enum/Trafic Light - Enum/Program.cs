using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafic_Light___Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();

            // color has to be TrafficlightColors.Red.
            Console.WriteLine(trafficLight.GetCurrentColor());
            trafficLight.NextState();

            // color has to be TrafficlightColors.Green.
            Console.WriteLine(trafficLight.GetCurrentColor());
            trafficLight.NextState();

            // color has to be TrafficlightColors.Orange.
            Console.WriteLine(trafficLight.GetCurrentColor());
            trafficLight.NextState();

            // color has to be TrafficlightColors.Red.
            Console.WriteLine(trafficLight.GetCurrentColor());

            Console.ReadLine();
        }
    }
}