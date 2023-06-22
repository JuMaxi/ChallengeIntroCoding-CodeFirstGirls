using System;
using System.Collections.Generic;

namespace ChallengeIntroCoding
{
    internal class Problem4
    {
        private string WriteFactorial()
        {
            Console.Write("Type a Number between 0 and 25 or Type E to Exit: ");
            string Input = Console.ReadLine();
            Input = Input.ToUpper();

            return Input;
        }

        private void VerifyValidFactorial(long Factorial)
        {
            if (Factorial < 0 || Factorial > 25)
            {
                throw new Exception("The number must be greater than 0 and less or equal 25. Type a number between 0 and 25 to continue.");
            }
        }
        private long CalculateFactorial(long Factorial)
        {
            VerifyValidFactorial(Factorial);

            if (Factorial == 0)
            {
                return 1;
            }
            else
            {
                long N = Factorial - 1;

                while (N >= 1)
                {
                    Factorial = Factorial * N;
                    N--;
                }
            }
            return Factorial;
        }

        public void CheckLookUpTable()
        {
            Dictionary<long, long> Factoriais = new Dictionary<long, long>();
            string Input = WriteFactorial();

            while (Input != "E")
            {
                long Number = Convert.ToInt64(Input);

                if (Factoriais.ContainsKey(Number))
                {
                    Console.WriteLine(Number + "! = " + Factoriais[Number]);
                    Console.WriteLine(" ");
                }
                else
                {
                    Factoriais.Add(Number, CalculateFactorial(Number));
                    Console.WriteLine(Number + "! = " + Factoriais[Number]);
                    Console.WriteLine(" ");
                }
                Input = WriteFactorial();
            }
        }

    }
}
