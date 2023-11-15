namespace ChallengeComposition.entites
{
    class OrderItem
    {

        public int quantity { get; set; }
        public double price {get;set;}

        public double subTotal()
        {
            return price*quantity;

        }

    }

}