using Newtonsoft.Json;
using MT.Utils;

namespace UsePackage
{
    internal class Program
    {
        class Product
        {
            public string Name { get; set; }
            public DateTime Expiry { get; set; }
            public string[] Sizes { get; set; }
        }

        class Movie
        {
            public string Name { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string[] Genres { get; set; }
        }

        static void Main(string[] args)
        {
            /* Tao ra chuoi json tu mot doi tuong */
            // Product product = new Product();

            // product.Name = "Apple";
            // product.Expiry = new DateTime(2008, 12, 28);
            // product.Sizes = new string[] { "small" };

            // string json = JsonConvert.SerializeObject(product);
            // Console.WriteLine(json);

            /* Tao ra mot doi tuong */
            // string json =
            //     @"{
            //     'Name': 'Bad Boys',
            //     'ReleaseDate': '1995-4-7T00:00:00',
            //     'Genres': [
            //         'Action',
            //         'Comedy'
            //     ]                    
            // }";

            // var product = JsonConvert.DeserializeObject<Product>(json);
            // Console.WriteLine(product.Name);
            // Movie m = JsonConvert.DeserializeObject<Movie>(json);
            // Console.WriteLine(m.Name);
            // Console.WriteLine(m.ReleaseDate.ToLongDateString());
            // Console.WriteLine(m.Genres[0]);

            double number = 364664763134578;
            var result = ConvertMoneyToText.NumberToText(number);
            Console.WriteLine(result);
        }
    }
}
