using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundButNotReally
{
    abstract class Bird
    {
        public abstract string SetLocation(double longitude, double latitude);
        public abstract string Draw();
    }
}
