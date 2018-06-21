using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesSorterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TrianglesSorter trianglesSorter = new TrianglesSorter();
            Triangles triangle = new Triangles();

            string refresh = "Y";

            while (refresh == "Y" || refresh == "YES")
            {

                triangle.Add(trianglesSorter.Input(), trianglesSorter.Area());

                Console.WriteLine("Продолжить ввод данных? Введите “y” или “yes”");
                refresh = Console.ReadLine().ToUpper();
            }

            triangle.Display();
            Console.ReadKey();
        }
    }
}
