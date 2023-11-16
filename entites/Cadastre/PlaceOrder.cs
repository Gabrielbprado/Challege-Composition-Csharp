using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using ChallengeComposition.Entites.Enum;

namespace ChallengeComposition.entites.Cadastre
{

    class PlaceOrder
    {
        OrderStatus status;
        Order order = new Order();
        Client c {get;set;}
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
            Console.WriteLine("Enter order data");
            Console.Write("Status PendingPayment, Processing, Shipped, Delivered: ");
            Enum.TryParse<OrderStatus>(Console.ReadLine().ToLower(), out status);
            Console.Write("How many item to this order ?: ");
              int.TryParse(Console.ReadLine(), out  int item);
            Client c =  new Client(Birth,Name,Email);
            this.c = c;
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
                    
                    order.AddItem(orderItem);
                    
                    
                }
                Sumary();

            }

            void Sumary()
            {
                
                Console.WriteLine("ORDER SUMMARY:");
                Console.WriteLine($"Order Moment: {DateTime.Now.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Order status: {status.ToString()}");
                Console.WriteLine($"Client: {c.Name} {c.BirthDate.ToString("dd/MM/yyyy")} - {c.Email}");
                Console.WriteLine("Order Items");
                SearchingItems();
                 }

                 void SearchingItems()
                 {
                    foreach(OrderItem item in order.status)
                    {
                        Console.WriteLine(item.ToString());

                    }
                   // Console.WriteLine($"Total Pice: ${orderItem.SubTotal} ");

                 }


    }

} 