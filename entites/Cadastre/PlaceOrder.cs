using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using ChallengeComposition.Entites.Enum;

namespace ChallengeComposition.entites.Cadastre
{

    class PlaceOrder
    {
        int item = 0;
    

        public void Cadastre()
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
              int.TryParse(Console.ReadLine(), out  item);
             new Client(Birth,Name,Email);
        }

            void Order()
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
                    new OrderItem(quantity,ProductPrice,Productname);
                    
                }

            }

            void Sumary()
            {
                
                Console.WriteLine("ORDER SUMMARY:");
                Console.Write($"Order Moment: {DateTime.Now}");
                

            }

    }

}