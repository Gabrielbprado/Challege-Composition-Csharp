using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using ChallengeComposition.Entites.Enum;

namespace ChallengeComposition.entites.Cadastre
{

    class PlaceOrder
    {
        
        Client c {get;set;}
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
            Console.Write("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many item to this order ?");
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
                    Console.Write("Product Name:");
                    string Productname = Console.ReadLine() ?? "Undefined";
                    Console.Write("Product Price: ");
                    double ProductPrice = double.Parse(Console.ReadLine());
                    Console.Write("Quantity");
                    int quantity = int.Parse(Console.ReadLine());
                    OrderItem orderItem = new OrderItem(quantity,ProductPrice,Productname);
                    Order order = new Order();
                    
                    order.AddItem(orderItem);
                    
                    
                }
                Sumary();

            }

            void Sumary()
            {
                
                Console.WriteLine("ORDER SUMMARY:");
                Console.Write($"Order Moment: {DateTime.Now}");
                Console.WriteLine($"Order status: aaa");
                Console.WriteLine($"Client: {c.Name} {c.BirthDate.ToString("dd/MM/yyyy")} - {c.Email}");
                Console.WriteLine("Order Items");


            }

    }

} 