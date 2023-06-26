using Spectre.Console;
using System;

namespace ChallengeIntroCoding
{
    internal class Program
    {
        private void CallClass(string Option)
        {
           if(Option == "Problem #1")
            {
                Problem1 Problem1 = new Problem1();
                Problem1.WriteReport();
            }
           if(Option == "Problem #2")
            {
                Problem2 Problem2 = new Problem2();
                Problem2.WriteArrayInt();
            }
           if(Option == "Problem #3")
            {
                Problem3 Problem3 = new Problem3();
                Problem3.FindNumber();
            }
           if(Option == "Problem #4")
            {
                Problem4 Problem4 = new Problem4();
                Problem4.CheckLookUpTable();
            }
           if(Option == "Problem #5")
            {
                Problem5 Problem5 = new Problem5();
                Problem5.HideCreditCardDigits();
            }
        }

        static void Main(string[] args)
        {
            string Option = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Please select the [green]challenge[/] and press [red]ENTER[/]:")
                    .PageSize(10)
                    .AddChoices(new[] {
                        "Problem #1", "Problem #2", "Problem #3",
                        "Problem #4", "Problem #5", "Exit"
                    }));

           Program Program = new Program();
           Program.CallClass(Option);
        }
    }
}
