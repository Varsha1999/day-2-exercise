using System;


namespace productmanagement
{
    class Program
    {
        static void Main(string[] args)
        {

            Mobile mobile = new Mobile();
            mobile.SetMobileData(1001, "X", "iphone", 78000, 12, "12MP", "Toughened glass");
            mobile.Display();
            Console.ReadLine();

            Product p1 = new Mobile(1002, "8", "iphone", 48000, 8, "5MP", "Toughened glass");
            
            

            

            Refrigerator refrigerator = new Refrigerator();
            refrigerator.SetRefrigeratorData(1001, "X", "onida", 78000, 2, "plastic");
            refrigerator.Display();
            Console.ReadLine();

            Product p2 = new Refrigerator(1002, "y", "kenstar", 48000, 3, "glass");
            DisplayProduct(p1);
            DisplayProduct(p2);
        }

        static void DisplayProduct(Product product)
        {
            if (product.GetType() == typeof(Mobile))
                ((Mobile)product).Display();

            if (product.GetType() == typeof(Refrigerator))
                ((Refrigerator)product).Display();


        }


    }
}