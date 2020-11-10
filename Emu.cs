using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundButNotReally
{
    class Emu : Bird
    {
        public bool IsAngry
        {
            get { return true;; }
        }

        public override string Draw()
        {
            return "The Emu is on screen, ready to attack";
        }

        public override string SetLocation(double longitude, double latitude)
        {
            return "The foockin emu is now at: " + longitude + "," + latitude;
        }
    }
}
