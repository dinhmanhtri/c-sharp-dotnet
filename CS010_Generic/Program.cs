namespace CS010_Generic
{
    internal class Program
    {
        // Use generic type for class
        class Product<A>
        {
            private A id;

            public A Id { set; get; }

        }

        // Use generic type for method
        static void Swap<T>(ref T a, ref T b)
        {
            // Hoan doi 2 so khong su dung bien tam
            //a = a + b;
            //b = a - b;
            //a = a - b;

            T temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            // Use generic type for method
            double a = 5;
            double b = 20;

            Console.WriteLine($"a = {a}, b = {b}");

            //Swap(ref a, ref b);
            Swap<double>(ref a, ref b);

            Console.WriteLine($"a = {a}, b = {b}");

            // Use generic type for class
            Product<int> productId = new Product<int>();
            productId.Id = 101;
            Console.WriteLine($"Id = {productId.Id}");

            Console.ReadKey();
        }
    }
}