using System;
using System.Collections.Generic;
using System.Text;

namespace Example.BT_Ôn_tập
{
    public class Cat : Animal
    {
        private string eyeColor;
        private string ownerName;

        public string EyeColor { get => eyeColor; set => eyeColor = value; }
        public string OwnerName { get => ownerName; set => ownerName = value; }

        public Cat()
        {

        }
        public Cat(string name, string Oname, string Coat, string Leg, string Wing, string Eye)
        {
            CoatColor = Coat;
            Legs = Leg;
            Name = name;
            Wings = false;
            EyeColor = Eye;
            OwnerName = Oname;
        }
        public override void Flying()
        {
            if (Wings)
                Console.WriteLine("flying");
            else
                Console.WriteLine("Not flyinng");
        }

        //public string Input()
        //{
        //    return Name;
        //    return OwnerName;
        //    return CoatColor;
        //}
        public void Input()
        {
            Console.WriteLine("Cat {0} of {1} is coat color {2}", Name, OwnerName, CoatColor);

        }
    }
}
