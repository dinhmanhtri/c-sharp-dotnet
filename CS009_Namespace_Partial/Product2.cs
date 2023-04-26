using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Product
    {
        public class Manufactory
        {
            public string Name { get; set; }
            public string Address { get; set; }

            public void ShowInfo() => Console.WriteLine($"Factory name: {Name}, address: {Address}");
        }

        public string Description { get; set; }

    }
}
