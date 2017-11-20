using System;
using System.Collections.Generic;

namespace FactoryMethodPattern
{
    public abstract class Pizza
    {
        string name;
        string dough;
        string sauce;
        List<string> toppings = new List<string>();

        public void Prepare(){
            Console.WriteLine("Preparing...");
        }
        public void Bake() {
            Console.WriteLine("Baking...");
        }
        public void Cut(){
            Console.WriteLine("Cutting...");
        }
        public void Box(){
            Console.WriteLine("Boxing...");
        }
        public public string GetName(){
            return this.name;
        }
    }
}
