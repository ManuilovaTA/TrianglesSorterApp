using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrianglesSorterApp
{
    public class TrianglesSorter
    {
        public double a, b, c, P, S;
        string name;
        string[] input;

        public string Input()
        {
            Console.WriteLine("Формат ввода параметров треугольника (разделитель - запятая): " +
                "\n\t <имя>, <длина стороны>, <длина стороны>, <длина стороны>");
            string tmp = Console.ReadLine();
            input = Regex.Split(tmp, @",\s+");
            name = input[0];

            if (!Double.TryParse(input[1], out a))
            {
                Console.WriteLine("Введен неправильный формат!");
                Input();
            }
            if (!Double.TryParse(input[2], out b))
            {
                Console.WriteLine("Введен неправильный формат!");
                Input();
            }
            if (!Double.TryParse(input[3], out c))
            {
                Console.WriteLine("Введен неправильный формат!");
                Input();
            }
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Введено отрицательное число!");
                Input();
            }

            return name;
        }

        public double Area()
        {
            if (a + b > c && a + c > b && c + b > a)
            {
                P = (a + b + c) * 0.5;
                S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            }
            else
            {
                Console.WriteLine("Стороны треугольнека введены неправильно!");
                Input();
            }

            return S;
        }
    }
}
