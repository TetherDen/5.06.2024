namespace HW_05._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Money usd = new Money("USD", 1525, 10);
            //usd.FractionalPart += 10;
            //Console.WriteLine(usd);


            Product prod = null;
            Product prod2 = null;
            try
            {
                //prod = new Product("banana", "USD", -10, 1000);
                prod = new Product("banana", "USD", 10, 50);
                prod2 = new Product("Orange", "UAH", 30, 10);

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine(prod);
            Console.WriteLine(prod2);

            try
            {
                //prod2.ReducePrice(100, 10);
                prod.ReducePrice(10, 10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine(prod);


            Device dev = new Teapot("teaport name", "teapot description");
            if(dev is Teapot)
            {
                (dev as Teapot).Sound();
            }
            dev.Show();
            dev.Desc();
            Console.WriteLine("");

            dev = new Microwave("microwave name", "microwave description");
            if (dev is Microwave)
            {
                (dev as Microwave).Sound();
            }
            dev.Show();
            dev.Desc();
            Console.WriteLine("");

            dev = new Car("car name", "car description");
            if (dev is Car)
            {
                (dev as Car).Sound();
            }
            dev.Show();
            dev.Desc();
            Console.WriteLine("");

            dev = new Steamboat("boat name", "boat desc");
            if (dev is Steamboat)
            {
                (dev as Steamboat).Sound();
            }
            dev.Show();
            dev.Desc();
        }
    }
}
