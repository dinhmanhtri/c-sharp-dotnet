namespace CS007_Inheritance
{
    internal class Program
    {
        // Lop bi niem phong (khong cho phep ke thua)
        sealed class School
        {
            // ...
        }

        class Animal
        {
            public Animal(int num)
            {
                Console.WriteLine($"Animal have {num} legs");
            }

            public Animal(string name)
            {
                Console.WriteLine($"Animal name: {name}");
            }
        }

        class Dog : Animal
        {
            // Chi ro constructor nao cua base class
            public Dog() : base("Bun")
            {
                Console.WriteLine("Dog have 4 legs");
            }
        }

        static void Main(string[] args)
        {
            Dog bun = new Dog();

            Animal a = new Animal(4);
            a = (Animal)bun;   // Chuyen kieu tu lop con ve lop cha
            Console.ReadKey();


        }
    }
}