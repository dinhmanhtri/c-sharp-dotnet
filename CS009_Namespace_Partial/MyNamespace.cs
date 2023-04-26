using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Nested namespace
namespace MyNamespace
{
    public class Class1
    {
        public static void Greet()
        {
            Console.WriteLine("Hello from MyNamespace");
        }

    }

    namespace MyNamespace2
    {
        public class Class1
        {
            public static void Greet()
            {
                Console.WriteLine("Hello from MyNamespace/MyNamespace2");
            }
        }
    }
}
