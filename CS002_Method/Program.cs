using System;

namespace CS002_Method;

class Program
{
    /*
        <Access Modifiers> <return type> <name_method>(<parameters>)
        {
            // Các câu lệnh trong phương thức
        }
    */

    

    static void FullName(string ho, string ten, string tenDem = "")
    {
        Console.WriteLine($"{ho} {tenDem} {ten}");
    }

    static void ThamChieuThamTri(ref int x)
    {
        x *= x;
        System.Console.WriteLine(x);
    }


    static void Main(string[] args)
    {
        FullName("Dinh", "Tri", "Manh"); // Dinh Manh Tri
        // Truyen tham so trong phuong thuc voi ten => Ko quan trong thu tu tham so
        FullName(ho: "Dinh", tenDem: "Manh", ten: "Tri"); // Dinh Manh Tri

        /*
            ref cần khởi tạo giá trị
            out không cần khởi tạo trước
            các tham số như class, object mặc định là kiểu tham chiếu
        */
        int x = 10;
        ThamChieuThamTri(ref x);
        Console.WriteLine(x); // 100

        int y = 5;
        Console.WriteLine(TinhToan.TinhGiaiThua(y));
        double z = 5.5;
        Console.WriteLine(TinhToan.TinhGiaiThua(z));    
    }
}
