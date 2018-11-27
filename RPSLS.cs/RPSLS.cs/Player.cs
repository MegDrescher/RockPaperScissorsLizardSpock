using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.cs
{
    public class Player
    {//member variables
        public string name;
        public string chosenGesture;
        public List<string> gestures;
        public int score;
        public Player()
        {
            gestures = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
        }


        public virtual void SetName()
        {
            Console.WriteLine("Enter your name: \n");
            string name = Console.ReadLine();
        }

        public virtual void ChooseGesture()
        {
            Console.WriteLine("Player One, Choose one out of five gestures.");
            string gestures = Console.ReadLine();

            switch (gestures)
            {
                case "Rock":
                    Console.WriteLine("You selected Rock" + gestures);
                    chosenGesture = "Rock";
                    break;
                case "Paper":
                    Console.WriteLine("You selected Paper" + gestures);
                    chosenGesture = "Paper";
                    break;
                case "Scissors":
                    Console.WriteLine("You selected Scissors" + gestures);
                    chosenGesture = "Scissors";
                    break;
                case "Lizard":
                    Console.WriteLine("You selected Lizard" + gestures);
                    chosenGesture = "Lizard";
                    break;
                case "Spock":
                    Console.WriteLine("You selected Spock" + gestures);
                    chosenGesture = "Spock";
                    break;

            }

        }

    }
}
