namespace OOP_lab_1
{
    public class MyArray

    //1. Реалізувати клас, що представляє одновимірний масив і містить опис індексатора
    //для доступу до елементів.Передбачити методи введення/виведення, знаходження
    //максимального та мінімального елементів.
    {
        private int[] arr;

        public MyArray()
        {
            Console.Write("Створення масиву\nВведіть розмір масиву : ");
            while (true)
            {
                int size = int.Parse(Console.ReadLine());
                if (size > 0)
                {
                    arr = new int[size];
                    break;
                }
                else Console.Write("\nХибні значення , введіть розмір масиву ще раз: ");
            }

        }
        public int IndexValidator()
        {
            int choice;
            while (true)
            {
                Console.Write("\nЯкий елемент бажаєте обрати? (індекс): ");
                choice = int.Parse(Console.ReadLine());

                if (choice >= 0 && choice < arr.Length)
                {
                    break;
                }

                Console.WriteLine("Значення хибне/за межами масиву! Спробуйте ще раз.");
            }
            return choice;
        }
        public int this[int i]
        {
            get
            {
               if (i>= 0 && i < arr.Length)
                {
                    return arr[i];
                }
               else
                {
                    Console.WriteLine("Елемент не знайдено");
                    return 0;
                }
              
            }
            set
            {
                if (i >= 0 && i <= arr.Length)
                {
                    arr[i] = value;
                }
                else Console.WriteLine("Елемент не знайдено.");
            }
        }

        public void SetArr()
        {
            Console.WriteLine("\nЗаповнення масиву: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Введіть елемент {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void GetArrStr()
        {
            Console.WriteLine("\nМасив зараз:");

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public int MaxValueInArr()
        {
            int max = this.arr[0];

            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        public int MinValueInArr()
        {
            int min = this.arr[0];

            foreach (int i in arr)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }
    

    }
}
