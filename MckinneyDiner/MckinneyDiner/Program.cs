using System;
using System.Collections;
using System.Collections.Generic;

namespace Diner
{
    public class MckinneyDiner
    {
        private Queue<int> waitingQueue = new Queue<int>();

        public void addCustomerToQueue(int parameter)
        {
            waitingQueue.Enqueue(parameter);
        }

        public void showCustomer()
        {
            Console.Write("This is the amount of customers that need to be seated: " +
                                 waitingQueue.Count);
                   
        }
        public void actualCustomer()
        {
            foreach (var item in waitingQueue)
            {
                Console.WriteLine("Customer: " + item);
            }
        }
        public void CustomerSeated()
        {
            waitingQueue.Dequeue();
        }


        static void Main(string[] args)
        {
            MckinneyDiner restaurantCustomer = new MckinneyDiner();
            restaurantCustomer.addCustomerToQueue(1);
            restaurantCustomer.addCustomerToQueue(2);
            restaurantCustomer.addCustomerToQueue(3);
            restaurantCustomer.addCustomerToQueue(4);
            restaurantCustomer.addCustomerToQueue(5);
            restaurantCustomer.addCustomerToQueue(6);

            restaurantCustomer.CustomerSeated();

            restaurantCustomer.actualCustomer();

            MckinneyDiner Cutomerpaid = new MckinneyDiner();
            Console.WriteLine("Customer 1 has paid for their meal!");
            Console.WriteLine("The server can place the dishes back and seat the next customer!");


        }

    }
}
