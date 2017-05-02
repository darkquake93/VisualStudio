using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAttempt
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle("Bob",-23434,10);
            Rectangle r2 = new Rectangle("Joe",10,10);
            Console.WriteLine(r1.getName() + "'s Area is: " + r1.Area());
            Console.WriteLine(r2.getName() + "'s Area is: " + r2.Area());
            Console.WriteLine("is " + r1.getName() + " a square? " + r1.isSquare());
            Console.WriteLine("is " + r2.getName() + " a square? " + r2.isSquare());
            if (r1.Is_Area_Greater_Than(r2))
            {
                Console.WriteLine(r1.getName() + "'s Area is larger than that of " + r2.getName() + "'s Area");
            }
            else if (r2.Is_Area_Greater_Than(r1))
            {
                Console.WriteLine(r2.getName() + "'s Area is larger than that of " + r1.getName() + "'s Area");
            }
            else
            {
                Console.WriteLine(r1.getName() + "'s Area is equal to " + r2.getName() + "'s Area");
            }

            // Create a list of rectangles.
            List<Rectangle> rectangleList = new List<Rectangle>();


            // Add rectangles to the list.
            Console.WriteLine();
            rectangleList.Add(new Rectangle("blardy",5,9) );
            rectangleList.Add(new Rectangle("blardo", 34, 76));
            rectangleList.Add(new Rectangle("rec1", 6, 4));
            rectangleList.Add(new Rectangle("rec2", 7, 3));
            rectangleList.Add(new Rectangle("rec3", 5, 2));
            rectangleList.Add(new Rectangle("sq1", 4, 4));
            rectangleList.Add(new Rectangle("sq2", 5, 5));



            rectangleList.Sort();


            Console.WriteLine("List of Rectangles After Sorting: ");
            foreach (Rectangle r in rectangleList)
            {
                Console.WriteLine(r.getName() + " Area: " + r.Area());
            }
            
            Console.WriteLine("Other stuff: ");
            
            Console.WriteLine();

            double maxArea = 0;
            String maxAreaName = "";
            foreach (Rectangle arectangle in rectangleList)
            {
                if (arectangle.length == arectangle.width)
                {
                    Console.WriteLine(arectangle.getName() + " is a square");
                }
                if (arectangle.Area() > maxArea)
                {
                    maxArea = arectangle.Area();
                    maxAreaName = arectangle.getName();
                }
                
            }

            Console.WriteLine(maxAreaName + " has largest Area of " + maxArea);

           




            Console.ReadLine();
            //Keeps console open
        }



    }
}
