using System;

namespace ChallengeIntroCoding
{
    internal class Problem2
    {
        public int[] WriteArrayInt()
        {
            int[] Numbers = new int[100];

            for (int Position = 0; Position <= Numbers.Length - 1; Position++)
            {
                var Random = new Random();
                Numbers[Position] = Random.Next(1, 501);
            }
            Numbers = SortArrayInt(Numbers);

            return Numbers;
        }

        private int[] SortArrayInt(int[] Numbers)
        {
            int FirstIndex = 0;

            while(FirstIndex < Numbers.Length)
            {
                int SecondIndex = 0;

                while (SecondIndex < Numbers.Length - 1 - FirstIndex)
                {
                    if (Numbers[SecondIndex] > Numbers[SecondIndex + 1])
                    {
                        int Num = Numbers[SecondIndex];
                        Numbers[SecondIndex] = Numbers[SecondIndex + 1];
                        Numbers[SecondIndex + 1] = Num;
                    }
                    SecondIndex++;
                }
                FirstIndex++;
            }
            return Numbers;
        }
    }
}
