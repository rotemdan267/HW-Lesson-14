using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_14
{
    class Program
    {
        static void Main(string[] args)
        {

            Car c1 = new Car("abc", false, true);
            Car c2 = new Car("abcd", false, false);
            try
            {
                Car c3 = new Car("abcde", true, false);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            Car c4 = new Car("ab", false, true);
            Car c5 = new Car("abc", false, true);

            Car c6 = new Car("abc", false, true);
            Car c7 = null;

            string[] types = new string[] { "abc", "abcd", "abcde" };

            Garage g = new Garage(types);

            g.cars = new Car[5] { c1, c2, c6, c4, c5 };

            try
            {
                g.AddCar(c7);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
