using System;

namespace Workshop
{
    internal class Program
    {
       

        public  class CeltoFarConvert
        {
            
            //Static method
            public static void CelsiusToFarhenite()
            {
                double Celsius, Farhenite;
                Console.WriteLine("Enter Temprature in Celsius ");
                Celsius =Convert.ToDouble(Console.ReadLine());
                Farhenite = (Celsius * 9 / 5) +32;
                Console.WriteLine("The Temprature In Farhenite:"+ Farhenite);
            }
            //Static method
            public static void FarheniteToCelsius()
            {
                double Celsius, Farhenite;
                Console.WriteLine("Enter Temprature in Farhenite ");
                Farhenite = Convert.ToDouble(Console.ReadLine());
                Celsius = (Farhenite - 32) * (5/9);
                Console.WriteLine("The Temprature In Celsius:" + Celsius);
            }
        }
        static void Main(string[] args)
        {
            

            //User gets to Decide What to Convert
            Console.WriteLine("In What unit do you want to Convert");
            Console.WriteLine("1 For Celsius To Farhenite \n 2 For Farhenite To Celsius");
            int conv = Convert.ToInt32(Console.ReadLine());
            switch(conv)
            {
                case 1:
                    Console.WriteLine("For Celsius To Farhenite");
                    CeltoFarConvert.CelsiusToFarhenite();
                    break;
                case 2:
                    Console.WriteLine("Farhenite To Celsius");
                    CeltoFarConvert.FarheniteToCelsius();
                    break;
            }

        }
    }
}
