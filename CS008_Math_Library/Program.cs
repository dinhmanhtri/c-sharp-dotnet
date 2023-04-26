namespace CS008_Math_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hang so PI, E (logarit tự nhiên)
            Console.WriteLine($"Hang so PI = {Math.PI}, hang so E = {Math.E}");

            // Max - min
            double num1 = 2.5, num2 = 2.3, num3 = 2;
            Console.WriteLine($"Max = {Math.Max(Math.Max(num1, num2), num3)}");

            Console.WriteLine($"Max = {Math.Max(3, 5)}");   // 5
            Console.WriteLine($"Min = {Math.Min(6, 2)}");   // 2

            // Abs (tri tuyet doi), Sign (Kiem tra gia tri am, duong, bang 0)
            Console.WriteLine($"Tri tuyet doi cua -23 la: {Math.Abs(-23)}");  // 23
            Console.WriteLine(Math.Sign(-10));  // -1 (-10 < 0)

            // Luong giac (Sin, Cos, Tan, Asin, Acos, Atan)
            Console.WriteLine($"Sin: {Math.Sin(Math.PI / 2)}");
            double deg = 90; // tinh theo goc
            // PI ~ 180
            // ?  ~ X
            double rad = Math.PI * deg / 180;
            Console.WriteLine($"Sin {deg} = {Math.Sin(rad)}");

            // Sqrt (can bac 2), Pow (Luy thua), Log (Logarit)
            Console.WriteLine($"Can bac 2 cua 16:{Math.Sqrt(16)}");
            Console.WriteLine($"Luy thua: {Math.Pow(2, 3)}");
            Console.WriteLine($"Log: {Math.Log(5)}");

            // Lam tron
            Console.WriteLine(Math.Round(6.5)); // 6, lam tron den so nguyen gan nhat
            Console.WriteLine(Math.Ceiling(6.1)); // 7, lam tron den so nguyen lon nhat gan nhat
            Console.WriteLine(Math.Floor(6.8)); // 6, lam tron dat so nguyen nho nhat gan nhat
            Console.WriteLine(Math.Truncate(7.4)); // 7, bo phan thap phan cua so
            Console.ReadKey();
        }
    }
}