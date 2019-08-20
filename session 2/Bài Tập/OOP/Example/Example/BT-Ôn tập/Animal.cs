using System;
using System.Collections.Generic;
using System.Text;

namespace Example.BT_Ôn_tập
{
    public abstract class Animal
    {
        private string name;
        private string coatColor;
        private string legs;
        private bool wings;

        public string Name { get => name; set => name = value; }
        public string CoatColor { get => coatColor; set => coatColor = value; }
        public string Legs { get => legs; set => legs = value; }
        public bool Wings { get => wings; set => wings = value; }
      

        public Animal()
        {

        }
        public Animal(string Coat, string Leg, string name, string Wing)
        {
            CoatColor = Coat;
            Legs = Leg;
            Name = name;
            Wings = false;
        }

        public abstract void Flying();

    }
}
