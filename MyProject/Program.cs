using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject {
    internal class Program {
        static void Main(string[] args) {

            // Задача 1. Найти сумму двух целых (вещественных) чисел и вывести результат на экран.
            Console.Write("num_1 = ");
            int num_1 = int.Parse(Console.ReadLine());

            Console.Write("num_2 = ");
            int num_2 = int.Parse(Console.ReadLine());

            int sum = num_1 + num_2;
            Console.Write("sum = ");

            Console.Write(sum);
            //



            // Задача 2. Вычислить периметр квадрата и вывести результат на экран.
            Console.Write("Сторона = ");
            int side = Convert.ToInt32(Console.ReadLine());
            int perimetr = 4 * side;

            Console.WriteLine($"Периметр = {perimetr}");
            //



            // Задача 3. Вычислить длину окружности и площадь круга и вывести результаты на экран.
            Console.Write("R = ");

            int radius = int.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"S = {area:f2}");
            //

            Console.ReadLine();
        }
    }
}
