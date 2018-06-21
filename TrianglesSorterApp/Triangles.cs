using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesSorterApp
{
    class Triangles
    {
        Dictionary<string, double> triangle = new Dictionary<string, double>();

        public void Add(string name, double triangleArea)
        {
            triangle.Add(name, triangleArea);
        }
        public void Display()
        {
            int count = 1;

            foreach (KeyValuePair<string, double> keyValue in triangle.OrderBy(key => key.Value))
            {
                Console.WriteLine("{0}. [{1}]: {2} cm", count++, keyValue.Key, keyValue.Value);
            }
        }
    }
}
