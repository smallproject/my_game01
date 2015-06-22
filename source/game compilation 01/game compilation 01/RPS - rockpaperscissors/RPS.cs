using System;
using System.Linq.Expressions;

namespace game_compilation_01.RPS___rockpaperscissors
{
    public class RPS
    {
        public RPS()
        {
            Console.WriteLine("Let's play! Rock, paper, scissors!");
            Console.WriteLine("what is your choice?");
            main();

            repeat();
        }

        public void repeat()
        {
            loop:
            Console.WriteLine("Do you want to repeat?(Y/N)");
            string choice = Console.ReadLine();

            if (choice.Equals(null))
            {
                return;
            }

            if (choice.ToUpper() == "Y")
            {
               //Console.WriteLine("How many times do you want to repeat the game?"); 
                main();
                goto loop;
            }
        }


        public void main()
        {
            Console.Write("User choice: ");
            string userchoice = Console.ReadLine();

            string computerChoiceText = computerChoice();
            Console.WriteLine("Computer choice: {0}", computerChoiceText);

            string result = compare(userchoice, computerChoiceText);
            Console.WriteLine(result);
            Console.WriteLine();
        }

        private Random random = new Random();
        private int AI;
        private string computerChoice()
        {
            AI = random.Next(1, 3);

            switch (AI)
            {
                case 1:
                    return "rock";
                case 2:
                    return "paper";
                case 3:
                    return "scissors";
            }

            return null;
        }

        private string compare(string choice1, string choice2)
        {
            if (choice1 == choice2)
            {
                return "It's a tie!";
            }
            else
            {
                if (choice1 == "rock")
                {
                    if (choice2 == "paper")
                    {
                        return "paper wins!";
                    }
                    else
                    {
                        return "rock wins!";
                    }
                }
                if (choice1 == "paper")
                {
                    if (choice2 == "scissors")
                    {
                        return "scissors wins!";
                    }
                    else
                    {
                        return "paper wins!";
                    }
                }
                if (choice1 == "scissors")
                {
                    if (choice2 == "rock")
                    {
                        return "rock wins!";
                    }
                    else
                    {
                        return "scissors wins!";
                    }
                }
                
            }
            return null;
        }

    }

    
}
