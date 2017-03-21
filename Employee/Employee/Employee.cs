using System;

namespace Employee
{
    public class Employee : IComparable
    {
        public String name;
        public String family;
        public int idNumber = 0;

        public Employee(String n, String fm, int i)
        {
            name = n;
            family = fm;
            idNumber = i;
        }
        int IComparable.CompareTo(object obj)
        {
            int returnVal;
            Employee temp = (Employee)obj;

            if (this.idNumber > temp.idNumber)
                returnVal = 1;
            else
                if (this.idNumber > temp.idNumber)
                returnVal = -1;
            else
                returnVal = 0;
                    return returnVal;
        }

    }
}
