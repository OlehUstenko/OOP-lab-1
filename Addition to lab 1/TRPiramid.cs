using System;
using System.Collections.Generic;
using System.Text;

namespace Addition_to_lab_1
{
    internal class TRPiramid : TRTriangleF
    {
        double height;

        public double Height
        {
            get { return height; }


            set { if (value > 0) height = value; }
        }

        public TRPiramid() : base()
        {
            height = 5;
        }


        public TRPiramid(double sideA, double sideB, double high) : base(sideA, sideB)
        {
            Height = high;
        }

        public TRPiramid(TRPiramid name) : base(name)
        {
            height = name.Height;
        }
        public override double Perimetr()
        {
            double bp = base.Perimetr();
            double l1 = height;
            double l2 = Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(height, 2));
            double l3 = Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(height, 2));
            return bp + l1 + l2 + l3;
        }

        public override double Area()
        {
            double sTR = base.Area();
            double s1 = SideA * height / 2;
            double s2 = SideB * height / 2;
            double s3 = 0.5 * Math.Sqrt(Math.Pow(SideA * Height, 2) + Math.Pow(SideB * height, 2) + Math.Pow(SideA * SideB, 2));

            return sTR + s1 + s2 + s3;
        }

        public double Volume()
        {
            return base.Area() * height / 3;
        }

        public override string ToString()
        {
            return $"Піраміда має катети: {SideA} , {SideB} та висоту {height}";

        }
        public void SetTRPiramid()
        {
            double input;

            while (true)
            {
                Console.Write("Введіть катет А: ");
                if (double.TryParse(Console.ReadLine(), out input) && input > 0)
                {
                    SideA = input;
                    break;
                }
                Console.WriteLine("Помилка! Катет має бути числом більшим за 0.");
            }

            while (true)
            {
                Console.Write("Введіть катет B: ");
                if (double.TryParse(Console.ReadLine(), out input) && input > 0)
                {
                    SideB = input;
                    break;
                }
                Console.WriteLine("Помилка! Катет має бути числом більшим за 0.");
            }

            while (true)
            {
                Console.Write("Введіть висоту піраміди: ");
                if (double.TryParse(Console.ReadLine(), out input) && input > 0)
                {
                    Height = input;
                    break;
                }
                Console.WriteLine("Помилка! Висота має бути числом більшою за 0.");
            }
        }
        public static TRPiramid operator *(TRPiramid name, double number)
        {
            return new TRPiramid(name.SideA * number, name.SideB * number, name.height * number);
        }
        public static TRPiramid operator *(double number, TRPiramid name)
        {
            return name * number;
        }
        }
}
