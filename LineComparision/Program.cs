using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to line comparision programs");



            Console.WriteLine("Enter x1: ");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y1: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter x2: ");
            int x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y2: ");
            int y2 = int.Parse(Console.ReadLine());

            Line obj1 = new Line();
            double length1 = obj1.computelength(x1, y1, x2, y2);
            //for line 2
            Console.WriteLine("Enter x1: ");
            int x11 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y1: ");
            int y11 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter x2: ");
            int x22 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter y2: ");
            int y22 = int.Parse(Console.ReadLine());



            Line obj2 = new Line();
            double length2 = obj1.computelength(x11, y11, x22, y22);

            length1 = Math.Round(length1, 3);
            length2 = Math.Round(length2, 3);

            if (length1 == length2)
            {
                Console.WriteLine("Two lines are equal " + length1 + " " + length2);
            }
            else if (length1 > length2)
            {
                Console.WriteLine("Two lines are unequal. Line 1 is greater " + length1 + " " + length2);
            }
            else if (length1 < length2)
            {
                Console.WriteLine("Two lines are unequal. Line 2 is greater " + length1 + " " + length2);
            }
            else
            {
                Console.WriteLine("Two lines are not equal " + length1 + " " + length2);
            }
        }


    }
}
