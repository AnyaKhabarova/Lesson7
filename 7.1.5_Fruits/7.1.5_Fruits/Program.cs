using System;

namespace _7._1._5_Fruits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Food { }
    class Vegies: Food { }
    class Fruits: Food { }
    class Apple: Fruits { }
    class Banana: Fruits { }
    class Pear: Fruits { }
    class Potato: Vegies { }
    class Carrot: Vegies { }
}
