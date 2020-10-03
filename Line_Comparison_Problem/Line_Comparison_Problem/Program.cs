using System;
namespace Line_Comparison_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation!");
            ComparisonClass line = new ComparisonClass();
            double[] lineLength = new double[2];
            for (int numOfLines = 0; numOfLines < 2; numOfLines++)
            {
                lineLength[numOfLines] = line.calculateLength();
            }
            line.compareLength(lineLength[0], lineLength[1]);
        }
    }
}
