using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobie M1 = new Mobie();

            MobileCatalog catalog = new MobileCatalog();
            catalog.Add(new Mobie(1001, "samsung", "note", 15000, "available in black and blue colors"));
            catalog.Add(new Mobie(1002, "one plus", "7pro", 45000, "available in black, red and blue colors"));

            var m = catalog.GetMobile(1002);
            m.Display();
            Console.ReadLine();
        }
    }
}
