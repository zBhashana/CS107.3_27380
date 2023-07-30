using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_04_Q1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertValues obj = new ConvertValues();

            Console.WriteLine("Enter the kilometer value: ");
            double km = double.Parse(Console.ReadLine());

            double meter = obj.kilometerToMeter(km);


            Console.WriteLine("{0} kilometers = {1} meters", km, meter);
        }
    }

    class ConvertValues
    {
        public double kilometerToMeter(double km)
        {
            double meter = km * 1000;

            return meter;
        }
    }
}
