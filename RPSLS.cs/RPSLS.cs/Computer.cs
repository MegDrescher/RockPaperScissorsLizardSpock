using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.cs
{
    public class Computer : Player
    {
        public Computer()
        {


        }

        public override void ChooseGesture()
        {
            //create an instance of the random class
            Random rand = new Random();
            int index = rand.Next(gestures.Count);
            Console.WriteLine(gestures[index]);


        }

    }

}
}