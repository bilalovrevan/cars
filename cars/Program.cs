
            using System;

namespace _29._11._2021
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("avtomobil sayini daxil edin: ");
                int len = Convert.ToInt32(Console.ReadLine());
                Cars[] avtomobil = new Cars[len];
                for (int i = 0; i < len; i++)
                {
                    Cars car = new Cars();
                    Console.Write($"{i + 1} marka adini daxil edin: ");
                    car.marka = Console.ReadLine();
                    Console.Write($"{i + 1} model adini daxil edin: ");
                    car.model = Console.ReadLine();
                    Console.Write($"{i + 1} buraxilis ilini adini daxil edin: ");
                    car.year = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"{i + 1} qiymetini daxil edin: ");
                    car.price = Convert.ToDouble(Console.ReadLine());
                    avtomobil[i] = car;

                }
                foreach (var car in avtomobil)
                {
                    string name = car.Fullname();
                    Console.WriteLine(name);
                }

            }
        }
    }


