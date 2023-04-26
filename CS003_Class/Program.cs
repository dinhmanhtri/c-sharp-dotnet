namespace CS003_Class;

/*
    - Tính đa hình (polymorphism): Overloading là cách thức triển khai tính đa hình.
    - Tính đóng gói: Sử dụng các Access Modifiers (public, private, internal, protected)
    khi khai báo class, method, property, trường dữ liệu (biến)
    - Thuộc tính accessor có thể khai báo thiếu set hoặc get, nếu thiếu set nó trở thành loại chỉ đọc (readonly). Sử dụng set rất tiện lợi cho thao tác kiểm tra tính hợp lệ của dữ liệu khi gán, hoặc tự động thực hiện một số tác vụ mỗi khi dữ liệu được gán.
*/

// Muon quan ly qua trinh thu hoi thi phai ke thua IDispoable
class Student : IDisposable
{
    public string name;

    public Student(string name)
    {
        this.name = name;
        Console.WriteLine($"Khoi tao: {name}");
    }

    // Ham huy duoc chay tu dong khi doi tuong duoc giai phong khoi bo nho (ko con bien nao tham chieu den no nua)
    // Khong the biet duoc luc nao dotnet thu hoi bo nho => Luc nao thieu bo nho can giai phong thi moi thu hoi
    // Khai bao ham huy
    ~Student()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Huy " + name);
        Console.ResetColor();
    }

    public void Dispose()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Huy (boi dispose) " + name);
        Console.ResetColor();
    }
}

class Program
{
    // Phuong thuc dispose se duoc goi cuoi cung khi ra khoi pham vi method TestDispose()
    static void TestDispose()
    {
        using Student sv = new Student("Sinh vien 3");
    }

    static void Main(string[] args)
    {
        TestDispose();
        // Su dung ket hop voi Dispose giai phong bo nho (ra ngoai khoi ngoai using doi tuong se duoc giai phong)
        using (Student student = new Student("Sinh vien 2"))
        {
            // ...
        }

        /*
        Student student;
        // Test phuong thuc huy
        for (int i = 0; i < 100000; i++)
        {
            student = new Student("Sinh vien " + i);
            student = null;
        }
        student = null; // ko con tham chieu den doi tuong student nua => Thu hoi bo nho => Goi phuong thuc huy
        // GC.Collect(); // Doi voi dotnet framework => thu hoi tat ca doi tuong khong co tham chieu
        */

        /*
        Vukhi sungLuc; // Khai bao => null
        sungLuc = new Vukhi(); // Khoi tao => Khi khoi tao mot doi tuong constructor se duoc chay dau tien
        sungLuc.name = "Sung luc";
        sungLuc.ThietLapSatThuong(5);

        sungLuc.NoiSanXuat = "My";
        Console.WriteLine(sungLuc.NoiSanXuat);

        sungLuc.SatThuong = 10; // gan thuoc tinh - get
        Console.WriteLine(sungLuc.SatThuong);   // doc thuoc tinh - set

        Vukhi sungTruong = new Vukhi("Sung Truong", 15);

        sungLuc.TanCong();
        sungTruong.TanCong();
        */
    }
}
