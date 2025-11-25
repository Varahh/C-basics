using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Class5_Task2
{
    public class MyMatrix
    {
        int rows, cols;
        int[,] matrix;
        public MyMatrix (int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = new int[rows,cols];
        }

        public void InitialiseMatrix()
        {
            Random rnd = new Random();
            for (int i = 0; i < this.rows; i++) {
                for (int j = 0; j < this.cols; j++)
                {
                    this.matrix[i,j] = rnd.Next(-10,10);
                }
            }
        }

        public void Resize(int newRows, int newCols)
        {
            int[,] newMatrix = new int[newRows, newCols];

            for (int i = 0; i < newRows; i++)
            {
                for (int j = 0; j < newCols; j++)
                {
                    newMatrix[i, j] = this.matrix[i,j];
                }
            }
            this.matrix = newMatrix;
            this.rows = newRows;
            this.cols = newCols;
        }

        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(this.matrix[i, j] + " ");
                }
                Console.WriteLine();    
            }
        }

        public void TPrint()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(this.matrix[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMatrix mat = new MyMatrix(3, 3);
            mat.InitialiseMatrix();
            mat.Print();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            mat.TPrint();
            Console.WriteLine();
            mat.Resize(2, 2);
            mat.Print();

        }
    }
}
