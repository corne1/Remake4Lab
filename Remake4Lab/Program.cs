using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remake4Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            var matrix = new Matrix(N);

            matrix.FillMatrix();

            matrix.DisplayMatrix();

            var res = matrix.FindMaxVertex();

            Console.WriteLine("Вершина(ы) с макс. степенью: " + res);
            Console.ReadLine();
        }
    }
}
