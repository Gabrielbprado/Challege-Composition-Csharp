using System.Dynamic;
using ChallengeComposition.Entites.Enum;

namespace ChallengeComposition.entites
{
    class Order
    {

        DateTime Moment;
        public List<OrderItem> status {get;set;} = new List<OrderItem>(); 
        public Client Client { get; set; }

        public void AddItem(OrderItem item)
        {
            status.Add(item);

        }
        public void RemoveItem(OrderItem item)
        {
            status.Remove(item);

        }
        public double total()
        {
            
            return 0;
        }

      

    }

}