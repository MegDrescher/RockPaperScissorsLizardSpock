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
     
            switch (index)
            {
                case 0:
                    Console.WriteLine("You selected 0(zero)"+index);
                    index = gestures.Count;
                    break;
                case 1:
                    Console.WriteLine("You seleced 1(one)"+index);
                    index = gestures.Count;
                    break;
                case 2:
                    Console.WriteLine("You seleced 2(two)"+index);
                    index = gestures.Count;
                    break;
                case 3:
                    Console.WriteLine("You selected 3(three)"+index);
                    index = gestures.Count;
                    break;
                case 4:
                    Console.WriteLine("You selected 4(four)"+index);
                    index = gestures.Count;
                    break;
            }
        }
    }
}
