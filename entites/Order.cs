using ChallengeComposition.Entites.Enum;

namespace ChallengeComposition.entites
{
    class Order
    {

        DateTime Moment;
        List<OrderItem> status = new List<OrderItem>();

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