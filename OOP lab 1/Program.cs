namespace OOP_lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("\nОБЕРІТЬ ТЕСТ");
                Console.WriteLine("1 — Тест масиву ");
                Console.WriteLine("2 — Тест трикутника ");
                Console.WriteLine("3 — Тест піраміди ");
                Console.WriteLine("0 — Вихід");
                Console.Write("Ваш вибір: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        ArrTest();
                        break;
                    case "2":
                        TRTriangleTest();
                        break;
                    case "3":
                        TRPiramidTest();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Невірний вибір! Спробуйте ще раз.");
                        break;
                }
            }

           
        }
        static void TRTriangleTest()
        {
            Console.Write("\nСтворення трикутника номер 1:");

            var tr1 = new TRTriangle();
            tr1.SetTRTriangle();
            Console.WriteLine(tr1.ToString() + $"та гіпотенузу {tr1.Hipotenusa()}");
            Console.WriteLine($"Периметр {tr1.P()} та площу {tr1.S()}");

        L2:
            Console.WriteLine("\nВведіть число на яке помножити трикутник: ");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Значення не може бути менше нуля !");
                goto L2;
            }
            tr1 = num * tr1;
            Console.WriteLine($"Після множення на {num} маємо таке: ");
            Console.WriteLine(tr1.ToString() + $"та гіпотенузу {tr1.Hipotenusa()}");
            Console.WriteLine($"Периметр {tr1.P()} та площу {tr1.S()}");


            Console.Write("\nСтврення трикутника номер 2:");

            var tr2 = new TRTriangle();
            tr2.SetTRTriangle();
            tr2.GetTRTriangle();

            Console.WriteLine("Порівняння трикутників 1 та 2 :" + tr1.Equals(tr2));


        }
        static void TRPiramidTest()
        {
            Console.WriteLine("Створення піраміди 1 ");
            var pir1 = new TRPiramid();
            pir1.SetTRPiramid();
            Console.WriteLine(pir1.ToString());
            Console.WriteLine($"Піраміда має периметр {pir1.P()}, площу {pir1.S()}, та об'єм {pir1.V()}");
            double input;
            while (true)
            {
                Console.Write("Введіть число на яке помножити піраміду: ");
                input = double.Parse(Console.ReadLine());
                if (input >= 0)
                {
                    pir1 = input * pir1;
                    break;
                }
                Console.WriteLine("Хибне занчення , спробуйте ще раз");
            }
            Console.Write("Тепер: ");
            Console.WriteLine(pir1.ToString());
            Console.WriteLine($"Піраміда має периметр {pir1.P()}, площу {pir1.S()}, та об'єм {pir1.V()}");

            Console.WriteLine("Створення піраміди 2:");
            var pir2 = new TRPiramid();
            pir2.SetTRPiramid();
            Console.WriteLine(pir2.ToString());
            Console.WriteLine($"Піраміда має периметр {pir2.P()}, площу {pir2.S()}, та об'єм {pir2.V()}");

            Console.WriteLine("Порпівняння піраміди 1 та 2: " + pir1.Equals(pir2));
        }
        static void ArrTest()
        {
            Console.Write("Створення масиву\nВведіть розмір масиву : ");
            int size = int.Parse(Console.ReadLine());
            var array = new MyArray(size);
            array.SetArr();
            Console.WriteLine("\nОтримано масив: ");
            array.GetArrStr();
        Label:
            Console.WriteLine("\nЯкий елемент бажаєте замінити? (індекс): ");
            int choice = int.Parse(Console.ReadLine());
            if (choice < 0 || choice >= size)
            {
                Console.WriteLine("Значення хибне/за межами масиву");
                goto Label;
            }
            Console.WriteLine($"\nВведіть значення для [{choice}]: ");
            int val = int.Parse(Console.ReadLine());
            array[choice] = val;
            Console.WriteLine("\nОновлений масив: ");
            array.GetArrStr();
            Console.WriteLine($"\nМаксимальне значення в масиві: {array.MaxValueInArr()}, мінімальне значення в масиві : {array.MinValueInArr()}");
        }

    }
}
