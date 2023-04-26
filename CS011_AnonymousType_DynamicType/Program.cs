namespace CS011_AnonymousType_DynamicType
{
    internal class Program
    {
        // Use dynamic type
        static void GetInfo(dynamic param)
        {
            // Trong quá trình biên dịch: mặc dù ko biết có 3 thuộc tính này ko nhưng nó vẫn sẽ biên dịch
            // Trong quá trình chạy: nếu ko có 1 trong 3 thuộc tính này sẽ ném ra ngoại lệ
            Console.WriteLine($"Name: {param.name}, age: {param.age}, address: {param.address}");
        }

        static void Main(string[] args)
        {
            // Anonymous type
            var myProfile = new
            {
                name = "MTri",
                age = 21,
                address = "Ha Noi"
            };

            Console.WriteLine(myProfile.name); // output: MTri
            GetInfo(myProfile);
            
            Console.ReadKey();
        }
    }
}