namespace OOP_lab_1
{
    //    2. Створити клас-нащадок TRPiramid (прямокутна трикутна піраміда, у якій бічне ребро
    //перпендикулярне до катетів і опускається у прямий кут трикутника) на основі класу
    //TRTriangle. Додати поле висоти піраміди, метод знаходження об’єму піраміди та
    //перевизначити відповідні методи.
    internal class TRPiramid : TRTriangle
    {
        double high;

        public double High
        {
            get { return high; }
            set { if (value > 0) high = value; }
        }

        public TRPiramid() : base() { }
        

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

        public void V()
        {
            double result = base.S() * high / 3 ;
            Console.WriteLine($"Об'єм піраміди : {result}");
        }

        public override string ToString()
        {
            return $"Піраміда має катети: {SideA} , {SideB} та висоту {high}";

        }
        public void SetTRPiramid()
        {
            Console.Write("Введіть катет А: ");
            SideA = double.Parse(Console.ReadLine());

            Console.Write("Введіть катет B: ");
            SideB = double.Parse(Console.ReadLine());

            Console.Write("Введіть висоту піраміди");
            High = double.Parse(Console.ReadLine());
        }

        public bool Equals(TRPiramid other)
        {
            return (this.SideA == other.SideA && this.SideB == other.SideB && this.high == other.high) ||
                   (this.SideA == other.SideB && this.SideB == other.SideA && this.high == other.high);
        }
    }
}
