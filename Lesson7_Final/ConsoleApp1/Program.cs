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
        public string Address;
        public Delivery(string address)
        {
            Address = address;
        }

        public void DisplayAddress()
        {
            Console.WriteLine(Address);
        }
    }

    class HomeDelivery : Delivery
    {
        public DateTime DeliveryTime;
        public HomeDelivery(string address, DateTime deliveryTime): base(address) { DeliveryTime = deliveryTime; }
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
