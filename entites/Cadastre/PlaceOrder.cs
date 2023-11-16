using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using ChallengeComposition.Entites.Enum;

namespace ChallengeComposition.entites.Cadastre
{

    class PlaceOrder
    {
        OrderStatus status;
        Order Order = new Order();
        Client C {get;set;}
        OrderItem orderItem;
        public PlaceOrder()
        {
            Cadastre();

        }
        private void Cadastre()
        {

            Console.WriteLine("Enter Cliente Data: ");
            Console.Write("Name:");
            string Name = Console.ReadLine() ?? "Usuer";
            Console.Write("Email:");
            string Email = Console.ReadLine() ?? "Email Generic";
            Console.WriteLine("Birth Date: (DD/MM/YYYY):");
            DateTime.TryParse(Console.ReadLine(), out DateTime Birth);
            C =  new Client(Birth,Name,Email);
            Console.WriteLine("Enter order data");
            Console.Write("Status PendingPayment, Processing, Shipped, Delivered: ");
            Enum.TryParse<OrderStatus>(Console.ReadLine().ToLower(), out status);
            Console.Write("How many item to this order ?: ");
              int.TryParse(Console.ReadLine(), out  int item);
                Order order = new Order(status, DateTime.Now, C);
            
             AddOrder(item);
            
        }

            void AddOrder(int item)
            {
                 for(int i = 1;i<=item;i++)
                {
                    Console.WriteLine($"Enter #{i} Data: ");
                    Console.Write("Product Name: ");
                    string Productname = Console.ReadLine() ?? "Undefined";
                    Console.Write("Product Price: ");
                    double ProductPrice = double.Parse(Console.ReadLine());
                    Console.Write("Quantity: ");
                    int quantity = int.Parse(Console.ReadLine());
                     orderItem = new OrderItem(quantity,ProductPrice,Productname);
                    
                    Order.AddItem(orderItem);
                    
                    
                }
                Sumary();

            }

            void Sumary()
            {
                
                Console.WriteLine("ORDER SUMMARY:");
               Console.WriteLine(Order.ToString());
                SearchingItems();
                 }

                 void SearchingItems()
                 {
                    foreach(OrderItem item in Order.Items)
                    {
                        Console.WriteLine(item.ToString());

                    }
                  Console.WriteLine($"Total Pice: ${orderItem.SubTotal().ToString()} ");

                 }


    }

} 