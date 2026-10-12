namespace OOP_lab_1
{
    //    2. Створити клас-нащадок TRPiramid (прямокутна трикутна піраміда, у якій бічне ребро
    //перпендикулярне до катетів і опускається у прямий кут трикутника) на основі класу
    //TRTriangle. Додати поле висоти піраміди, метод знаходження об’єму піраміди та
    //перевизначити відповідні методи.
    public class TRPiramid : TRTriangle
    {
        double high;

        public double High
        {
            get { return high; }


            set { if (value > 0) high = value; }
        }

        public TRPiramid() : base() 
        {
            high = 5;
        }
        

        public TRPiramid(double sideA, double sideB, double high) : base (sideA , sideB)
        {
            High = high;
        }

        public TRPiramid(TRPiramid name) : base(name)
        { 
            High = name.High;
        }
        public override double P()
        {
            double bp = base.P();
            double l1 = high;
            double l2 = Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(high, 2));
            double l3 = Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(high, 2));
            return bp +l1 + l2 + l3;
        }

        public override double S()
        {
            double sTR = base.S();
            double s1 = SideA * high / 2;
            double s2 = SideB * high / 2;
            double s3 = 0.5 * Math.Sqrt(Math.Pow(SideA * High , 2 ) + Math.Pow(SideB * high, 2) + Math.Pow(SideA * SideB , 2));

            return sTR + s1+ s2 + s3;
        }

        public double V()
        {
            return base.S() * high / 3 ;
        }

        public override string ToString()
        {
            return $"Піраміда має катети: {SideA} , {SideB} та висоту {high}";

        }
        public void SetTRPiramid()
        {
            double input;

            while (true)
            {
                Console.Write("Введіть катет А: ");
                string input_str = Console.ReadLine().Replace(",", ".");
                if (double.TryParse(input_str, out input) && input > 0)
                {
                    SideA = input;
                    break; 
                }
                Console.WriteLine("Помилка! Катет має бути числом більшим за 0.");
            }

            while (true)
            {
                Console.Write("Введіть катет B: ");
                string input_str = Console.ReadLine().Replace(",", ".");
                if (double.TryParse(input_str, out input) && input > 0)
                {
                    SideB = input;
                    break;
                }
                Console.WriteLine("Помилка! Катет має бути числом більшим за 0.");
            }

            while (true)
            {
                Console.Write("Введіть висоту піраміди: ");
                string input_str = Console.ReadLine().Replace(",", ".");
                if (double.TryParse(input_str, out input) && input > 0)
                {
                    High = input;
                    break;
                }
                Console.WriteLine("Помилка! Висота має бути числом більшою за 0.");
            }
        }
        public static TRPiramid operator *(TRPiramid name, double number)
        {
            return new TRPiramid(name.SideA * number, name.SideB * number, name.high * number);
        }
        public static TRPiramid operator *(double number, TRPiramid name)
        {
            return name * number;
        }
        public bool Equals(TRPiramid trp)
        {
            if (trp.GetType() == typeof(TRPiramid))
                return (this.SideA == trp.SideA && this.SideB == trp.SideB && this.high == trp.high) ||
                   (this.SideA == trp.SideB && this.SideB == trp.SideA && this.high == trp.high);
            else return false;
        }
    }
}
