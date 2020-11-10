using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundButNotReally
{
    class Pidget : Bird, ICanFly
    {
        public override string Draw()
        {
            return "Pidget is on screen";
        }

        public string SetAltitude(double altitude)
        {
            return "Pidget is now flying at: " + altitude + " meters in the air";
        }

        public override string SetLocation(double longitude, double latitude)
        {
            return "Pidget is now at: " + longitude + "," + latitude;
        }
    }
}
