namespace OOP_lab_1
{
    public class TRTriangle
    {
        double sideA ;
        double sideB ;
            
        public double SideA
        {
            get 
            { 
                return sideA; 
            }
            set 
            {
                if (value > 0) sideA = value; 
                else Console.WriteLine("Сторона має бути більше ніж нуль! ");
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
                if (value > 0) sideB = value; 
                else Console.WriteLine("Сторона має бути більше ніж нуль! ");
            }
        }

        public TRTriangle()
        {
            sideA = 3;
            sideB = 4;
        }
        
        public TRTriangle(double sideA, double sideB)
        {
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
        public double ValueValidator()
        {
            double side;
            while (true)
            {
                Console.Write("\nВведіть довжину сторони:  ");
                side = double.Parse(Console.ReadLine().Replace('.',','));

                if (side > 0)
                {
                    break;
                }

                Console.WriteLine("Значення хибне/за межами масиву! Спробуйте ще раз.");
            }
            return side;
        }
        public void SetTRTriangle()
        {
      
            Console.Write("\nВведіть катет А: ");
            SideA = ValueValidator();
            //this.SideA = sideA;      

            Console.Write("\nВведіть катет Б: ");
            double sideB = ValueValidator();
            this.SideB = sideB;
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

        public bool Equals(TRTriangle trt)
        {
            if(trt.GetType() == typeof(TRTriangle) && trt != null)
            return (trt.sideA == sideA && trt.sideB == sideB || trt.sideA == sideB && trt.sideB == sideA) ;
            else return false;
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
