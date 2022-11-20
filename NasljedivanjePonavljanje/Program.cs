using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljedivanjePonavljanje
{
    class Brojevi
    {
        double broj;
        public double Broj { get => broj; set => broj = value; }
        public virtual double ApsVrijednost()
        {
            return 0;
        }
    }
    class Cijeli : Brojevi
    {
        public override double ApsVrijednost()
        {
            return Broj;
        }
    }
    class Decimalni : Brojevi
    {
        public override double ApsVrijednost()
        {
            return Broj;
        }
    }
    class Pozitivni : Cijeli
    {
        public override double ApsVrijednost()
        {
            return Broj;
        }
    }
    class Negativni :Cijeli
    {
        public override double ApsVrijednost()
        {
            return Broj;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pozitivni x = new Pozitivni();
            Negativni y = new Negativni();
            Decimalni z = new Decimalni();
            x.Broj = 100;
            y.Broj = -100;
            z.Broj = 100.45;

            Console.WriteLine("Pozitivni broj x je " + x.ApsVrijednost() + ".");
            Console.WriteLine("\r\nNegativni broj y je " + y.ApsVrijednost() + ".");
            Console.WriteLine("\r\nDecimalni broj z je " + z.ApsVrijednost() + ".");
            Console.ReadLine();
        }
    }
}
