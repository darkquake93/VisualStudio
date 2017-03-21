using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList emp1 = new ArrayList();
            emp1.Add(new Employee("David", "Jones", 26));
            emp1.Add(new Employee("Tim", "Peake", 15));
            emp1.Add(new Employee("Richard", "Sample", 7));
            Console.WriteLine("List of Employees: ");
            foreach (Employee e in emp1)
            {
                Console.WriteLine(e.name);
            }

            emp1.Sort();
            Console.WriteLine("List of Employees After Sorting: ");
            foreach (Employee e in emp1)
            {
                Console.WriteLine(e.name);
            }
            Console.ReadLine();

        }
    }
}
