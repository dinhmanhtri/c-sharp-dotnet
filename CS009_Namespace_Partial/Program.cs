using MyNamespace;
using Ns2 = MyNamespace.MyNamespace2; // Ns2: Ten viet tat cho namespace 
using static System.Console; // Nap cac phuong thuc tinh cua System.Console
using static System.Math;

using PartialClass;
namespace CS009_Namespace_Partial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // use namespace
            Class1.Greet();
            Ns2.Class1.Greet();

            // Sau khi nap cac static method co the su dung truc tiep luon
            WriteLine("Load static method from System.Console");
            WriteLine(Max(PI, 3.15));   //3.15

            // Use partial class
            Product iphone = new Product();
            iphone.Name = "12 promax";
            iphone.Price = 20;
            iphone.Description = "This is iphone 12 promax";
            iphone.FactoryInfo = new Product.Manufactory();
            iphone.FactoryInfo.Name = "Apple";
            iphone.FactoryInfo.Address = "China";
            iphone.GetInfo();

            Console.ReadKey();
        }
    }
}