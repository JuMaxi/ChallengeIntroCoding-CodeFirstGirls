using System;

namespace ChallengeIntroCoding
{
    internal class Problem1
    {
        private int InsertGrade()
        {
            Console.WriteLine("Please, type the Student's grade:");
            int Grade = Convert.ToInt32(Console.ReadLine());

            return Grade;
        }

        public void WriteReport()
        {
            int Grade = InsertGrade();

            if (Grade < 40)
            {
                Console.WriteLine("Failed. Grade is: " + Grade);
            }
            else
            {
                Grade = RoundUp(Grade);

                if (Grade > 80)
                {
                    Console.WriteLine("Passed with Distinction! Grade is: " + Grade);
                }
                else
                {
                    Console.WriteLine("Passed! Grade is: " + Grade);
                }
            }
        }
        private int RoundUp(int Grade)
        {
            int NextMultipleFive = (Grade + 5) - (Grade % 5);

            if ((NextMultipleFive - Grade) < 3)
            {
                Grade = NextMultipleFive;
            }
            return Grade;
        }
    }
}
