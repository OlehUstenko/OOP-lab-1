namespace OOP_lab_1
{
    public class TRTriangle
    {
        double sideA;
        double sideB;
            
        public double SideA
        {
            get 
            { 
                return sideA; 
            }
            set 
            {
                if (value > 0) sideA = value; else Console.WriteLine("Сторона має бути більше ніж нуль! ");
            }
        }
       
        public double SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                if (value > 0) sideB = value; else Console.WriteLine("Сторона має бути більше ніж нуль! ");
            }
        }

        public TRTriangle()
        {
        }
        
        public TRTriangle(double sideA, double sideB)
        {
            if (sideA < 0 || sideB < 0)
            {
                Console.WriteLine("Хибні значення, трикутник не створений.");
                return;
            }
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public TRTriangle(TRTriangle triangle)
        {
            this.sideA = triangle.sideA;
            this.sideB = triangle.sideB;
        }

        public override string ToString()
        {
            return $"Прямокутний трикутник має катети: {sideA} та {sideB}";

        }

        public void SetTRTriangle()
        {
        SA:
            Console.Write("\nВведіть катет А: ");
            double sideA = double.Parse(Console.ReadLine());
            if (sideA < 0)
            {
                Console.WriteLine("Хибні значення");
                goto SA;
            }
        SB:
            Console.Write("\nВведіть катет Б: ");
            double sideB = double.Parse(Console.ReadLine());
            if (sideB < 0)
            {
                Console.WriteLine("Хибні значення");
                goto SB;
            }
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public void GetTRTriangle()
        {
            Console.WriteLine(ToString());
        }

        public virtual double S()
        {
            return (sideA * sideB) / 2;
        }

        public double Hipotenusa()
        {
            return Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }

        public virtual double P()
        {
            return sideA + sideB + Hipotenusa();
        }

        public bool Equals(TRTriangle name)
        {
            if (name == null) return false;
            return (name.sideA == sideA && name.sideB == sideB || name.sideA == sideB && name.sideB == sideA) ;
            
        }
        
        public static TRTriangle operator *(TRTriangle name, double number)
        {
            return new TRTriangle(name.sideA * number, name.sideB * number);
        }

        public static TRTriangle operator *(double number, TRTriangle name)
        {
            return name * number;
        }
        
    }
}
