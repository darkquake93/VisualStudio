using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle_demo
{
    class Circle
    {
        private String name;
        private double radius;

        public Circle (String n, double r)
        {
            name = n;
            radius = r;
        }

        public String Name() { return name;  }
        public double Radius() { return radius; }

        public bool Is_Greater_Than(Circle other)
        {
            if (this.Radius() > other.Radius())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }
        public double Circum()
        {
            return 2 * Math.PI * radius;
        }
    }
}
