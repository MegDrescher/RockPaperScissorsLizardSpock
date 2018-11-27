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
        Player P1;
        Player P2;



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
                P1 = new Human();
                P2 = new Computer();
            }
            else
            {
                P1 = new Human();
                P2 = new Human();
            }


        }

        public void CompareGestures()
        {

        }

        public void DetermineRoundWinner()
        {

        }

        public void DetermineGameWinner()
        {

        }
        public void RunGame()
        {

        }
    }





}
