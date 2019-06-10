using System.Collections.Generic;

namespace Remake4Lab
{
    class Matrix
    {
        private int[,] _Matrix { get; }
        public List<int> Vertexes { get; set; }
        public List<int> Output { get; }
        private int N { get; }
        public Matrix(int n)
        {
            N = n;
            _Matrix = new int[N, N];
            Vertexes = new List<int>();
            Output = new List<int>();
            SendVertex();
        }

        private void SendVertex()
        {
            for (int i = 0; i < N; i++)
            {
                Vertexes.Add(i+1);
            }
        }

        public void FillMatrix()
        {
            var rnd = new System.Random();
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (i == j) { _Matrix[i, j] = 0; }
                    else {
                        _Matrix[i, j] = rnd.Next(0,2);
                        _Matrix[j, i] = _Matrix[i, j];
                    }
                }
            }
        }
        public void DisplayMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                
                for (int j = 0; j < N; j++)
                {
                    System.Console.Write(_Matrix[i,j] + " ");
                }
                System.Console.WriteLine();
            }
        }
        public int FindMaxVertex()
        {
            int result = 0;
            int count = 0, 
                max = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (_Matrix[i, j] > 0)
                    {
                        count++;
                    }
                }   
                if(i == 0) { max = count; }
                if (count > max)
                {
                    max = count;
                    result = Vertexes[i];
                }
                System.Console.WriteLine($" кол. ребер: {count} вершины: {Vertexes[i]}");
                count = 0;
            }            
            return result;
        }
    }
}
