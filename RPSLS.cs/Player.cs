using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.cs
{
    public class Player
    {//member variables
        public int name;
        public string chosenGesture;
        List<string> gestures;
        public Player(string chosenGesture, int name, string gestures)
        {
            this.name = name;
            this.chosenGesture = chosenGesture;
           
        }
        
     
     public void SetName()
        {

        }

        public void ChooseGesture()
        {
            List<string> gestures = new List<string>();
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Insert(1, "rock");
            gestures.Insert(2, "paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Insert(3, "scissors");
            gestures.Insert(4, "lizard");
            gestures.Add("spock");
            gestures.Insert(5, "spock");

            foreach(string gesture in gestures)
            {
                Console.WriteLine(gesture);

            }
         
        
   
        }

         
    }


        


    
       







    }
       
      

        //methods SetName()  ChooseGesture()}
