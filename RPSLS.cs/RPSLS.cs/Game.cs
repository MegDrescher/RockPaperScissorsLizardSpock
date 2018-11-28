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
        
        Player Player1;
        Player Player2;




        //member methods
        public void DisplayRules()
        {
            Console.WriteLine("How to play RPSLS: Rock crushes Scissors. Scissors cuts Paper. Paper covers Rock. Rock crushes Lizard. Lizard poisons Spock. Spock smashes Scissors. Scissors decapitates Lizard. Lizard eats Paper. Paper disproves Spock. Spock vaporizes Rock.");
           
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
                        Console.WriteLine("You lost, Computer chose Paper. Paper disproves Rock.");
                        Player2.score++;
                    }
                    else if (randomNumber == 3)
                    {
                        Console.WriteLine("You won! Computer chose Lizard. Rock crushes Lizard.");
                        Player1.score++;
                    }
                    else if (randomNumber == 2)
                    {
                        Console.WriteLine("You won! Computer chose Scissors. Rock crushes Scissors.");
                        Player1.score++;
                    }
                    else if (randomNumber == 4)
                    {
                        Console.WriteLine("You lost, Computer chose Spock. Spock vaporizes Rock.");
                        Player2.score++;
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
                        Player1.score++;
                    }
                    else if (randomNumber == 2)
                    {
                        Console.WriteLine("You lost, Computer chose Scissors. Scissors cut Paper.");
                        Player2.score++;
                    }
                    else if (randomNumber == 3)
                    {
                        Console.WriteLine("You lost, Computer chose Lizard. Lizard eats paper.");
                        Player2.score++;
                    }

                    else if (randomNumber == 4)
                    {
                        Console.WriteLine("You won! Computer chose Spock. Paper disproves Spock.");
                        Player1.score++;
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
                        Player1.score++;
                    }
                    else if (randomNumber == 4)
                    {
                        Console.WriteLine("You lost, Computer chose Spock. Spock smashes Scissors.");
                        Player2.score++;
                    }
                    else if (randomNumber == 3)
                    {
                        Console.WriteLine("You won! Computer chose Lizard. Scissors decapitates Lizard.");
                        Player1.score++;
                    }
                    else if (randomNumber == 0)
                    {
                        Console.WriteLine("You lost, Computer chose Rock. Rock crushes Scissors.");
                        Player2.score++;
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
                        Player2.score++;
                    }
                    else if (randomNumber == 4)
                    {
                        Console.WriteLine("You won! Computer chose Spock. Lizard poisons Spock.");
                        Player1.score++;
                    }
                    else if (randomNumber == 1)
                    {
                        Console.WriteLine("You won! Computer chose Paper. Lizard eats Paper.");
                        Player1.score++;
                    }
                    else if (randomNumber == 2)
                    {
                        Console.WriteLine("You lost, Computer chose Scissors. Scissors decapitates Lizard");
                        Player2.score++;
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
                        Player2.score++;
                    }
                    else if (randomNumber == 2)
                    {
                        Console.WriteLine("You won! Computer chose Scissors. Spock smashes Scissors.");
                        Player1.score++;
                    }
                    else if (randomNumber == 0)
                    {
                        Console.WriteLine("You won! Computer chose Rock. Spock vaporizes Rock.");
                        Player1.score++;
                    }
                    else if (randomNumber == 1)
                    {
                        Console.WriteLine("You lost, Computer chose Paper. Paper disproves Spock.");
                        Player2.score++;
                    }
                    break;
            }
        }

        public void DetermineRoundWinner()
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
        

        public void DetermineGameWinner()
        {
            if (Player1.score <= Player2.score)
            {
                Console.WriteLine("Player 2 won RPSLS!");
            
            }
            else
            {
                Console.WriteLine("Player1 won RPSLS!");
            }
        }

        public void RunGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
            Random randomNumber = new Random();
            DisplayRules();
            DetermineNumberOfPlayers();
            Player1.SetName();
            Player2.SetName();

            Player1.ChooseGesture();
            Player2.ChooseGesture();
            CompareGestures();
            DetermineRoundWinner();
            DetermineGameWinner();
        }
    }
 }
