using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();

            // color has to be "Red".
            Console.WriteLine(trafficLight.GetCurrentColor());
            trafficLight.NextState();

            // color has to be "green".
            Console.WriteLine(trafficLight.GetCurrentColor());
            trafficLight.NextState();

            // color has to be "orange".
            Console.WriteLine(trafficLight.GetCurrentColor());
            trafficLight.NextState();

            // and 'red' again!
            Console.WriteLine(trafficLight.GetCurrentColor());

            Console.ReadKey();
        }
    }
}
