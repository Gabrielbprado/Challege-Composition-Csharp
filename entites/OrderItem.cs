namespace ChallengeComposition.entites
{
    class OrderItem
    {
        Order order = new Order();       

        public Product Product { get; set; }
        public OrderItem(int Quantity, double Price,string name)
        {


            this.Quantity = Quantity;
            this.Price+= Price;
            Product product = new Product(name,Price);
            order.AddItem(this);
        }

        public int Quantity { get; set; }
        public double Price {get;set;}
    



        public double SubTotal()
        {
            return Price*Quantity;

        }

        public override string ToString()
        {
            return $"{Product.Name}, {Product.Price}, Quantity: {Quantity}, Subtotal: ${Product.Price}  ";
        }

    }

}