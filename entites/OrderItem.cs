namespace ChallengeComposition.entites
{
    class OrderItem
    {
        Order order = new Order();       


        public OrderItem(int quantity, double price,string name)
        {


            this.quantity = quantity;
            this.price = price;
            Product product = new Product(name,price);
            order.AddItem(this);
        }

        public int quantity { get; set; }
        public double price {get;set;}
    



        public double subTotal()
        {
            return price*=quantity;

        }

    }

}