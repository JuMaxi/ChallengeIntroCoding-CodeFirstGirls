using System;

namespace ChallengeIntroCoding
{
    internal class Problem3
    {
        private int[,] GiveInputMatrix()
        {
            int[,] Matrix = new int[,]
            {
                {1,  4,   7,   12,  15,  1000},
                {2,  5,   19,  31,  32,  1001},
                {3,  8,   24,  33,  35,  1002},
                {40, 41,  42,  44,  45,  1003},
                {99, 100, 103, 106, 128, 1004}
            };

            return Matrix;
        }

        private int ChooseNumber()
        {
            Console.WriteLine("Please, type the number: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            return Number;
        }

        private void WriteReturn(int Row, int Column, bool Found)
        {
            if(Found == true)
            {
                Console.WriteLine("[" + Row + "," + (Column) + "]");
            }
            else
            {
                Console.WriteLine("The number was not found in this Matrix.");
            }
        }
        public void FindNumber()
        {
            int[,] Matrix = GiveInputMatrix();
            int Number = ChooseNumber();

            int Row = 0;
            int Column = Matrix.GetLength(1) - 1;
            bool Found = false;
            

            while (Row < Matrix.GetLength(0) && Column >= 0)
            {
                if (Number == Matrix[Row, Column])
                {
                    Found= true;
                    break;
                }
                else
                {
                    if (Number < Matrix[Row, Column])
                    {
                        Column--;
                    }
                    else
                    {
                        Row++;
                    }
                }
            }
            WriteReturn(Row, Column, Found);
        }
    }
}
