using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic
{
    class TrafficLight
    {
        private string color;

        public TrafficLight()
        {
            color = "Red";
        }

        public string NextState()
        {
            switch (color)
            {
                case "Red":
                    color = "Green";
                    break;
                case "Green":
                    color = "Orange";
                    break;
                case "Orange":
                    color = "Red";
                    break;

                default:
                    break;
            }
            return color;
        }

        public string GetCurrentColor()
        {
            return color;
        }
    }
}
