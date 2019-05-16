using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafic_Light___Enum
{
    class TrafficLight
    {//testr

        public enum Color
        {
            green, orange, red
        }; //

        private Color CurrentTrafficLightColor = Color.red;

        public void NextState()
        {
            if (CurrentTrafficLightColor == Color.red)
            {
                CurrentTrafficLightColor = Color.green;
            }
            else if (CurrentTrafficLightColor == Color.green)
            {
                CurrentTrafficLightColor = Color.orange;
            }
            else if (CurrentTrafficLightColor == Color.orange)
            {
                CurrentTrafficLightColor = Color.red;
            }

        }

        public Color GetCurrentColor()
        {
            return CurrentTrafficLightColor;
        }
        public TrafficLight()
        {


        }
    }
}
