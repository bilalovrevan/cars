using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._11._2021
{
    internal class Cars
    {
        public string marka;
        public string model;
        public int year;
        public double price;
        public string Fullname()
        {
            return $"{marka} {model} {year} {price}";
        }
    }
}
