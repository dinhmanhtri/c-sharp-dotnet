namespace CS013_VirtualMethod_Abstract_Interface;
class Program
{
    // 
    abstract class Product
    {
        protected double Price {set; get;}

        // Use abstract method: Method khong co noi dung, khi extend can phai override
        public abstract void ProductInfo();

        // // Use virtual method
        // public virtual void ProductInfo()
        // {
        //     Console.WriteLine($"Gia san pham {Price}");
        // }

        // Use abstract method

        public void Test() => ProductInfo();
    }

    class Iphone : Product
    {
        public Iphone() => Price = 500;

        // Override method
        public override void ProductInfo()
        {
            Console.WriteLine($"Day la iphone");
            // base.ProductInfo(); // Truy cap den phuong thuc cua base class
            Console.WriteLine($"Gia: {Price}");
        }
    }

    // Use abstract class: Class khong the khoi tao
    abstract class Animal
    {
        protected int age {set; get;}
        abstract public void GetInfo();

        public void Test() => GetInfo();
    }

    class Dog : Animal
    {
        public Dog() => age = 2;

        public override void GetInfo()
        {
            Console.WriteLine($"Age of dog: {age}");
        }
    }

    static void Main(string[] args)
    {
        Iphone xsMax = new Iphone();
        xsMax.Test();
    }
}
