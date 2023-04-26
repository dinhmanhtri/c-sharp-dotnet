using System;
using System.Text;
namespace CS005_String;

class Program
{
    static void Main(string[] args)
    {
        string notify;
        // @ o truoc: Viet chuoi nguyen ban
        notify = @"Xin chào ""Moi nguoi""";
        Console.WriteLine(notify);
        int year = 2023;

        // year can le phai, phia truoc la 10 khoang trang
        string info = $"Xin chao {year, 10}, nam sau la nam {year + 1}";
        Console.WriteLine(info);

        // Ket hop vua co the chen bieu thuc va co the xuong dong
        string thongbao;
        string name = "Dinh Manh Tri";
        string gender = "Nam";
        thongbao = $@"
            Ho ten: {name, 10}
            Nam Sinh: {year, 10}
            Gioi Tinh: {gender, 10}
        ";
        Console.WriteLine(thongbao);

        // string length
        string nameString = "Alexander MC Queen";
        Console.WriteLine(nameString.Length);

        // Trim string
        string mes = "  Hello everyone ***";
        Console.WriteLine(mes.Trim('*'));

        // Chuyen thanh chuoi viet thuong
        string mes1 = "Xin Chao Tat Ca Moi Nguoi";
        Console.WriteLine(mes1.ToLower());

        // Thay the chuoi
        string mes2 = "Xin chao tat ca moi nguoi!";
        Console.WriteLine(mes2.Replace("Xin chao", "Chao mung"));

        // Insert chuoi vao vi tri bat ky
        string mes3 = "Hello moi nguoi";
        Console.WriteLine(mes3.Insert(5, " tat ca"));

        // Lay ra chuoi con
        Console.WriteLine(mes3.Substring(0, 10)); // Hello moi n

        // Xoa chuoi con
        Console.WriteLine(mes3.Substring(0, 6)); // moi nguoi

        // Chia cac chuoi con thanh mang
        string[] subStrings = mes3.Split(" ");
        foreach (var item in subStrings)
        {
            Console.Write(item + "+");
        }

        // Hop cac chuoi trong mang thanh mot chuoi
        string[] mes4 = {
            "Halo",
            "Hi",
            "Xin chao",
            "Helu"
        };

        string result = string.Join(",", mes4);
        Console.WriteLine(result);

        // StringBuilder - khuyen khich su dung khi xay dung chuoi, hieu nang tot hon
        StringBuilder thongBao = new StringBuilder();
        thongBao.Append("Xin");
        thongBao.Append(" chao cac ban");
        thongBao.Replace("Xin chao", "Chao mung");
        Console.WriteLine(thongBao.ToString());
        Console.ReadLine();
    }
}
