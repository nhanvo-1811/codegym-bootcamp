using System;
using System.Collections.Generic;
using System.Text;
// [Thực hành] Lớp Animal và interface Edible khóa Java
namespace Example.Ex4
{
    public abstract class Animal
    {
        protected int Height;
        protected int Weight;

        //protected Animal(int height, int weight)
        //{
        //    this.Height = height;
        //    this.Weight = weight;
        //}
        //public abstract int are();
        public abstract string MakeSound();
    }
}
