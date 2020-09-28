using System;

namespace Line_Problem
{
    class Program
    {

        static float CalulateLength(int x1, int x2, int y1, int y2)
        {
            float length = (float)Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return length;
        }

        static void Main(string[] args)
        {
            //Welcome msg
            Console.WriteLine("Welcome to Line Comparison Problem!");
            
            //variables

            float[] length = new float[2];


            //Taking coordinate inputs from the user for 2 lines
            for (int i = 0; i <= 1; i++)
            {
                int x1 = 0, x2 = 0, y1 = 0, y2 = 0;

                Console.WriteLine("Enter the coordinates of Line " + (i + 1));

                Console.WriteLine("Enter the coordinates of X");

                x1 = Convert.ToInt32(Console.ReadLine());

                x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the coordinates of Y");

                y1 = Convert.ToInt32(Console.ReadLine());

                y2 = Convert.ToInt32(Console.ReadLine());

                length[i] = CalulateLength(x1, x2, y1, y2);

            }



            if (length[0].Equals(length[1]))
            {
                Console.WriteLine("Lines have equal length.");
            }
            else
            {
                Console.WriteLine("Lines are not equal in length!");
            }



        }
    }
}