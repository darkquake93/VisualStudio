using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAttempt
{
    public class Rectangle : IComparable<Rectangle>
    {
        public double length { get; set; }
        public double width { get; set; }
        String name = "";


        public Rectangle(String rname, double length, double width)
        {
            name = rname;
            this.length = length;
            this.width = width;
            Console.WriteLine(rname + "'s Length is " + length);
            Console.WriteLine(rname + "'s Width is " + width);
        }
        public String getName()
        {
            return name;
        }
        public double getWidth()
        {
            return width;
        }
        public double Area()
        {
            return length * width;
        }
        public String isSquare()
        {

            if (length == width)
            {
                return "yeah";
            }
            return "nah";
        }
        public bool Is_Area_Greater_Than(Rectangle other)
        {
            if (this.Area() > other.Area())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        int CompareTo(object obj)
        {
            int returnVal;
            Rectangle temp = (Rectangle)obj;

            if (this.Area() > temp.Area())
                returnVal = 1;
            else
                if (this.Area() > temp.Area())
                returnVal = -1;
            else
                returnVal = 0;
            return returnVal;
        }

        public int CompareTo(Rectangle other)
        {
            if (this.Area() > other.Area())
            {
                return this.Area().CompareTo(other.Area());
            }
            return this.Area().CompareTo(other.Area());
        }
    }
}
