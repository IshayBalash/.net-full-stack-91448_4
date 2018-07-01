namespace _02_Map_full_object_to_partial_object
{
    class Program
    {
        static void Main(string[] args)
        {

            //---------------------MAP Product TO FullProduct----------------------------
            Product p1 = new Product { Name = "Computer", Price = 10000, Description = "The best thing in the world" };


            FullProduct p2 = new FullProduct
            {
                ProductId = 1,
                ProductName = p1.Name,
                ProductPrice = p1.Price,
                ProductDescription = p1.Description,
                ProductSecretCode = 11
            };




            //---------------------MAP FullProduct TO Product----------------------------

            FullProduct p3 = new FullProduct
            {
                ProductId = 2,
                ProductName = "Phone",
                ProductPrice = 2000,
                ProductDescription = "The way to talk with other people",
                ProductSecretCode = 11
            };


            Product p4 = new Product { Name = p3.ProductName, Price = p3.ProductPrice, Description = p3.ProductDescription };
        }
    }
}
