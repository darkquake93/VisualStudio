﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle_demo
{
    class Program
    {
        static Circle Create_Circle()
        {
            String name, temp;
            double radius;
            Console.Write("Enter Circle name: ");
            name = Console.ReadLine();
            Console.Write("Declare Radius: ");
            temp = Console.ReadLine();
            radius = double.Parse(temp);
            return new Circle(name, radius);
        }
        static void Main(string[] args)
        {
            Circle c1 = Create_Circle();
            Console.Write("Circle " + c1.Name());
            Console.WriteLine(" created with radius " + c1.Radius());
            Console.WriteLine("Its area is " + c1.Area());
            Console.WriteLine("Its circumference is " + c1.Circum());
            Circle c2 = Create_Circle();
            Console.Write("Circle " + c2.Name());
            Console.WriteLine(" created with radius " + c2.Radius());
            Console.WriteLine("Its area is " + c2.Area());
            Console.WriteLine("Its circumference is " + c2.Circum());

            if (c1.Is_Greater_Than(c2))
            {
                Console.Write("Circle " + c1.Name() + " is greater than ");
                Console.WriteLine("Circle " + c2.Name());
            }
            else if (c2.Is_Greater_Than(c1))
            {
                Console.Write("Circle " + c2.Name() + " is greater than ");
                Console.WriteLine("Circle " + c1.Name());
            }
            else
            {
                Console.Write("Circle " + c1.Name() + " and Circle " + c2.Name());
                Console.WriteLine(" are the same size.");
            }
            
            Console.ReadLine(); // This keeps the window open.
        }
    }
}
