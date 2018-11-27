using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.cs
{
    internal class Game
    //member variables
    {
        public int roundResult;
        Player Player1;
        Player Player2;
        private string input;



        //member methods
        public void DisplayRules()
        {

        }

        public void DetermineNumberOfPlayers()
        {
            Console.WriteLine("How many number of players?");
            string num = Console.ReadLine();
            if (num == "1")
            {
                Player1 = new Human();
                Player2 = new Computer();
            }
            else
            {
                Player1 = new Human();
                Player2 = new Human();
            }
        }

        public void CompareGestures()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 4);

            Console.WriteLine("Please select Rock, Paper, Scissors, Lizard or Spock");
            string input = Console.ReadLine();

            switch (input)
            {
                case "Rock":
                    if (randomNumber == 0)
                    {
                        Console.WriteLine("It's a tie, Computer also chose Rock.");
                    }
                    else if (randomNumber == 1)
                    {
                        Console.WriteLine("You loose, Computer chose Paper. Paper disproves Rock.");
                    }
                    else if (randomNumber == 3)
                    {
                        Console.WriteLine("You win, Computer chose Lizard. Rock crushes Lizard.");
                    
                    }
                    else if (randomNumber == 2)
                    {
                        Console.WriteLine("You won, Computer chose Scissors. Rock crushes Scissors.");
                    }
                    else if (randomNumber == 4)
                    {
                        Console.WriteLine("You lost, Computer chose Spock. Spock vaporizes Rock.");
                    }
                    break;

                case "Paper":
                    if (randomNumber == 1)
                    {
                        Console.WriteLine("It's a tie, Computer also chose Paper.");
                    }
                    else if (randomNumber == 0)
                    {
                        Console.WriteLine("You won! Computer chose Rock. Paper covers Rock.");
                    }
                    else if (randomNumber == 2)
                    {
                        Console.WriteLine("You lost, Computer chose Scissors. Scissors cut Paper.");
       
                    }
                    else if (randomNumber == 3)
                    {
                        Console.WriteLine("You lost, Computer chose Lizard. Lizard eats paper.");
                    }
                
                    else if (randomNumber == 4)
                    {
                        Console.WriteLine("You won! Computer chose Spock. Paper disproves Spock.");
                    }
                    break;

                case "Scissors":
                    if (randomNumber == 2)
                    {
                        Console.WriteLine("It's a tie, Computer also chose Scissors.");
                    }
                    else if (randomNumber == 1)
                    {
                        Console.WriteLine("You won! Computer chose Paper. Scissors cuts Paper.");
                    }
                    else if (randomNumber == 4)
                    {
                        Console.WriteLine("You lost, Computer chose Spock. Spock smashes Scissors.");
                        
                    }
                    else if (randomNumber == 3)
                    {
                        Console.WriteLine("You won! Computer chose Lizard. Scissors decapitates Lizard.");
                    }
                    else if (randomNumber == 0)
                    {
                        Console.WriteLine("You lost, Computer chose Rock. Rock crushes Scissors.");
                    }
                    break;

                case "Lizard":
                    if (randomNumber == 3)
                    {
                        Console.WriteLine("It's a tie, Computer also chose Lizard.");
                    }
                    else if (randomNumber == 0)
                    {
                        Console.WriteLine("You lost, Computer chose Rock crushes Lizard");
                    }
                    else if (randomNumber == 4)
                    {
                        Console.WriteLine("You won! Computer chose Spock. Lizard poisons Spock.");
                    }
                    else if (randomNumber == 1)
                    {
                        Console.WriteLine("You won! Computer chose Paper. Lizard eats Paper.");
                    }
                    else if (randomNumber == 2)
                    {
                        Console.WriteLine("You lost, Computer chose Scissors. Scissors decapitates Lizard");
                    }
                    break;

                case "Spock":
                    if (randomNumber == 4)
                    {
                        Console.WriteLine("It's a tie, Computer chose Spock.");
                    }
                    else if (randomNumber == 3)
                    {
                        Console.WriteLine("You lost, Computer chose Lizard. Lizard poisons Spock.");
                    }
                    else if (randomNumber == 2)
                    {
                        Console.WriteLine("You won! Computer chose Scissors. Spock smashes Scissors.");
                    }
                    else if (randomNumber == 0)
                    {
                        Console.WriteLine("You won! Computer chose Rock. Spock vaporizes Rock.");
                    }
                    else if (randomNumber == 1)
                    {
                        Console.WriteLine("You lost, Computer chose Paper. Paper disproves Spock.");
                    }
                    break;
            }
        }
        
        public void DetermineRoundWinner(Player Player1, Player Player2)
        {
            Player1.score = 0;
            Player2.score = 0;
            if (Player1.score > Player2.score)
            {
                Player2.score++;
            }
            else
            {
                Player1.score++;
            }
            if (Player2.score >= 3)
            {
                Console.WriteLine("Computer player won three rounds!");
            }
            if (Player1.score == 3)
            {
                Console.WriteLine("Human player won three rounds!");

            }
        }

        public void DetermineGameWinner(Player Player1, Player Player2)
        {
            
        }
        public void RunGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
            Random randomNumber = new Random();
            DisplayRules(); //the order of how the game should go
            SetName();
            DetermineNumberOfPlayers();


            
          
       
        }
    }
}
