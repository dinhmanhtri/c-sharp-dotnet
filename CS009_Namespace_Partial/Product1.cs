using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Product
    {
        public Manufactory FactoryInfo { set; get; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"{Name}: {Price}$ ({Description})");
            FactoryInfo.ShowInfo();
        }

    }
}
