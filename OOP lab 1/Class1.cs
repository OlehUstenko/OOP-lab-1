
//1. Реалізувати клас, що представляє одновимірний масив і містить опис індексатора
//для доступу до елементів.Передбачити методи введення/виведення, знаходження
//максимального та мінімального елементів.


namespace OOP_lab_1
{
    internal class MyArray
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

        public void Set_Arr(int[] arr)
        {
            this.arr = arr;
        }

        public void Get_Arr_Str()
        {
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
