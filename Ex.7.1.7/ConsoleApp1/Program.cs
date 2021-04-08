using System;

namespace ConsoleApp1
{
       class SmartHelper
    {
        private string name;

        public SmartHelper(string name)
        {
            this.name = name;
        }

        public void Greetings(string name)
        {
            Console.WriteLine("Hi, {0}, I'm AI helper {1}", name, this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SmartHelper helper = new SmartHelper("Moses");
            helper.Greetings("Anya");

            Console.ReadKey();
        }

    }

}
