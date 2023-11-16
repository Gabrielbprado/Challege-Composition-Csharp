using System.Dynamic;
using ChallengeComposition.Entites.Enum;
using System.Text;


namespace ChallengeComposition.entites
{
    class Order
    {

        public Client Client { get; set; }
        public DateTime Moment { get; set; }
        public List<OrderItem> Items {get;set;} = new List<OrderItem>(); 
        public OrderStatus status { get; set;} = new OrderStatus();

        public Order(OrderStatus status,DateTime Moment,Client Client)
        {
            this.status = status;
            this.Moment = Moment;
            this.Client = Client;
        }
        public Order()
        {
           
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);

        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);

        }
        public double Total()
        {
            
            double sum = 0;
            foreach(OrderItem o in Items)
            {
                sum+= o.SubTotal();

            }

            return sum;
            
        }

         public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2"));
            return sb.ToString();
        }
      

    }

}