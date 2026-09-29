namespace OOP_lab_1
{
    internal class MyArray
    //1. Реалізувати клас, що представляє одновимірний масив і містить опис індексатора
    //для доступу до елементів.Передбачити методи введення/виведення, знаходження
    //максимального та мінімального елементів.
    {
        private int[] arr;

        public MyArray(int size)
        {
            arr = new int[size];
        }
        public int this[int i]
        {
            get
            {
                return arr[i];
            }
            set
            {
                arr[i] = value;
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
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public int MaxValueInArr()
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("Масив порожній!");
                return 0;
            }
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
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("Масив порожній!");
                return 0;
            }
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
