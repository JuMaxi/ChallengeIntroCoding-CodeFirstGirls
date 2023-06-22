using System;

namespace ChallengeIntroCoding
{
    internal class Problem5
    {
        private string[] WriteDigitsRandomCreditCard()
        {
            string[] DigitsCreditCard = new string[19];

            int Position = 0; 

            while(Position < DigitsCreditCard.Length)
            {
                var Random = new Random();
                int Number = Random.Next(0, 10);

                if ((Position + 1) % 5 == 0)
                {
                    DigitsCreditCard[Position] = " ";
                }
                else
                {
                    DigitsCreditCard[Position] = Number.ToString();
                }
                Position++;
            }
            return DigitsCreditCard;
        }

        public string[] HideCreditCardDigits()
        {
            string[] DigitsCreditCard = WriteDigitsRandomCreditCard();

            int Position = 0;

            while(Position < DigitsCreditCard.Length - 4)
            {
                if (DigitsCreditCard[Position] != " ")
                {
                    DigitsCreditCard[Position] = "X";
                }
                Position++;
            }
            return DigitsCreditCard;
        }
    }
}
