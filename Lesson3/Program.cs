using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            double a = double.Parse(Console.ReadLine());       
            Console.WriteLine("enter 2nd number");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("enter 3rd number");
            double c = double.Parse(Console.ReadLine());
            //printing the sum of all 3 numbers
            Console.WriteLine("the sum of numbers is {0}", a+b+c);
            //printing the avg of all 3 numbers
            Console.WriteLine("the avg of numbers is {0}", (a + b + c)/3);
            //printing their multiplexing
            Console.WriteLine("their multiplying is {0}", a*b*c);

            Console.WriteLine("enter width of rectangle");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("enter length of rectangle");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("the size of the rectangle is {0}", width*length);

            Console.WriteLine("enter radius of circle");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("the diameter of circle is {0}", r+r);
            double pai = 3.14;
            Console.WriteLine("the size of circle is {0}", 2*pai*r);

            //Console.WriteLine("enter length of movie in minutes");
            //double fullSize = double.Parse(Console.ReadLine());
            //int hours = (int)fullSize/60;
            //int minutes = (int)fullSize % 60;
            //Console.WriteLine("hours is {0}",hours);
            //Console.WriteLine("minutes is {0}", minutes);

            Console.WriteLine("enter length of movie in minutes");
            int fullSize = int.Parse(Console.ReadLine());
            Console.WriteLine("hours is {0}",fullSize/60);
            Console.WriteLine("minutes is {0}", fullSize % 60);


            Console.WriteLine("enter 4 digits number");
            int theNum = int.Parse(Console.ReadLine());
            Console.WriteLine("the thousands is {0}", theNum / 1000);
            Console.WriteLine("the hundreds is {0}", (theNum % 1000)/100);
            Console.WriteLine("the tens is {0}", (theNum % 100)/10);
            Console.WriteLine("the ones is {0}",theNum %10);

            Console.WriteLine("enter two digits number");
            int twoDigitsNum = int.Parse(Console.ReadLine());
            Console.WriteLine("the sum is {0}", ((twoDigitsNum / 10) + (twoDigitsNum % 10)));




        }
    }
}
