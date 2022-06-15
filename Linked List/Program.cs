using System;
using System.Collections.Generic;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] customers = {"Customer A", "Customer B" , "Customer C" , "Customer D",
                 "Customer E", "Customer F"};
                
                //Create a new list of customers
                LinkedList<string> list = new(customers);
                //Enumarate  the list items without disturbing its contents
                Display(list, "Customers list");
               

                //Add new node containing the specified value to the beginning of the list
                list.AddFirst("Customer G");
                Display(list,"Add Customer G to the  beginning of the list");


                //Add new node containing the specified value to the end of the list
                list.AddLast("Customer 1");
                Display(list, "Add Customer 1 to the end of the list");

                //Move the first node to be the last node
                LinkedListNode<string> CustomerG = list.First;
                list.RemoveFirst();
                list.AddLast("Customer G");
                Display(list, "Move customer G to the end of the list");

                //Change the contents of the last nodes
                list.RemoveLast();
                list.AddLast("Customer J");
                Display(list, "Change customer G to Customer J");


                //List 2
                LinkedList<string> purchases = new LinkedList<string>();

                purchases.AddLast("PO 0001");
                purchases.AddLast("PO 0001");
                purchases.AddLast("PO 0001");
                purchases.AddLast("PO 0001");
                purchases.AddLast("PO 0001");

                List2(purchases, "Purchases list");


                Console.ReadKey();
            }
            catch (Exception ex)
            {

                throw (ex);
            }
        }

        
        private static void Display(LinkedList<string> customers, string test)
        {
            try
            {
                Console.WriteLine(test);
                foreach (string customer in customers)
                {
                    Console.WriteLine(customer + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static void List2(LinkedList<string> purchases, string po)
        {
            try
            {
                Console.WriteLine(po);
                foreach (string purchase in purchases)
                {
                    Console.WriteLine(purchase+ " ");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

       // ..private static void List2(LinkedList<string>)
    }
}
