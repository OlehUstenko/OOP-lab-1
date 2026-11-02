using OOP_lab_1;
using System.Text;

namespace Addition_to_lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.WriteLine("Тест HashSet<TRTriangle>");

            HashSet<TRTriangle> set1 = new HashSet<TRTriangle>();

            TRTriangle t1 = new TRTriangle(3, 4);
            set1.Add(t1);

            TRTriangle t2 = new TRTriangle(3, 4);
            Console.WriteLine($"Чи знайдено t2 (ідентичний) у HashSet<TRTriangle>? {set1.Contains(t2)}");
            // Результат Contains булевий.


            Console.WriteLine("\nТест HashSet<TRTriangleF> ");

            HashSet<TRTriangleF> set2 = new HashSet<TRTriangleF>();

            TRTriangleF tf1 = new TRTriangleF(3, 4);
            set2.Add(tf1);

            TRTriangleF tf2 = new TRTriangleF(3, 4);
            Console.WriteLine($"Чи знайдено tf2 (ідентичний) у HashSet<TRTriangleF>? {set2.Contains(tf2)}");
            

            Console.WriteLine("\nТест HashSet<TRPiramid>");

            HashSet<TRPiramid> set3 = new HashSet<TRPiramid>();

            for (int i = 1; i <= 5; i++) set3.Add(new TRPiramid(3, 4, i));

            Console.WriteLine($"Кількість елементів у HashSet<TRPiramid>: {set3.Count}");


            Console.WriteLine("\nТест HashSet<TRPiramidF>");

            HashSet<TRPiramidF> set4 = new HashSet<TRPiramidF>();
            for (int i = 1; i <= 5; i++)
            {
                set4.Add(new TRPiramidF(3, 4, i));
            }
            Console.WriteLine($"Кількість елементів у HashSet<TRPiramidF>: {set4.Count}");


            // Якщо спробуємо додати ще раз ті самі піраміди
            for (int i = 1; i <= 5; i++)
            {
                set4.Add(new TRPiramidF(3, 4, i));
            }
            Console.WriteLine($"Кількість унікальних елементів у HashSet<TRPiramidF>: {set4.Count}");
        }
    }
}
