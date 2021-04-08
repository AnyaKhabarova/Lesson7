using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    abstract class Delivery
    {
        public string Address { get; set; }
    }

    class HomeDelivery : Delivery
    {
        private string address;
        public DateTime DeliveryTime;
        public string Address { get { return address; } set { address = value; } }
        public HomeDelivery(string address, DateTime deliveryTime): base(address){DeliveryTime= deliveryTime);
    }

    class PickPointDelivery : Delivery
    {
        /* ... */
    }

    class ShopDelivery : Delivery
    {
        /* ... */
    }

    class Order<TDelivery,TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        
    }
}
