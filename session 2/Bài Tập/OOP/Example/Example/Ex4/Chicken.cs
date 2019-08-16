using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Ex4
{
    public class Chicken : Animal, IEdible
    {
        public override string MakeSound()
        {
            return "chip chip";
        }
        // Interface k cần override
        //public override string HowToEat():   K cần
        public string HowToEat()
        {
            return "rice";
        }
    }
}
