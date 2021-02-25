using System;

namespace Exercises_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Obj
    {
        private string name;
        private string owner;
        private int length;
        private int count;

        public Obj(string name, string ownerName, int objLength, int count) 
        {
            this.name = name;
            owner = ownerName;
            length = objLength;
            this.count = count;
        }
    }
}
