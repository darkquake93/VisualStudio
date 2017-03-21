using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Circle : IComparable<Circle>
    {
        private String name;
        private double radius;

        public Circle(String n, double r)
        {
            name = n;
            radius = r;
        }

        public String Name() { return name; }
        public double Radius() { return radius; }

        

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public int CompareTo(Circle other)
        {
            if (this.radius < other.radius)
                return -1;
            else if (this.radius > other.radius)
                return 1;
            else
                return 0;
        }

    }
}
