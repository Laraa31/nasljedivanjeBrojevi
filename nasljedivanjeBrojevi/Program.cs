using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasljedivanjeBrojevi
{
    public class Brojevi
    {
        double broj;

        public double Broj { get => broj; set => broj = value; }

        public virtual double ApsVrijednost()
        {
            return Broj;
        }
    }

    public class Cijeli : Brojevi
    {
        public override double ApsVrijednost()
        {
            return Broj < 0 ? -Broj : Broj;
        }
    }

    public class Decimalni: Brojevi
    {
        public override double ApsVrijednost()
        {
            return Broj < 0 ? -Broj : Broj;
        }
    }

    public class Pozitivni : Cijeli
    {
        public override double ApsVrijednost()
        {
            return Broj;
        }
    }

    public class Negativni : Cijeli
    {
        public override double ApsVrijednost()
        {
            double apsBroj = Broj*(-1);
            return apsBroj;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            

            Pozitivni x=new Pozitivni();
            x.Broj =100;
            Console.WriteLine(x.ApsVrijednost());

            Negativni y = new Negativni();
            y.Broj = -100;
            Console.WriteLine(y.ApsVrijednost());

            Decimalni z = new Decimalni();
            z.Broj=-100.45;
            Console.WriteLine(z.ApsVrijednost());



            Console.ReadKey();
        }
    }
}
