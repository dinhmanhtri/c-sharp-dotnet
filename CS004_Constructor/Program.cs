namespace CS004_Constructor;

/*
- Phương thức khởi tạo có tên giống lớp, không có kiểu trả về.
-
*/
class Product
{
    // Khai báo trường dữ liệu (biến)
    private string name;
    private decimal price;

    // Khai báo phương thức khởi tạo 2 tham số
    public Product(string name, decimal price)
    {
        this.name = name;
        this.price = price;
    }

    // Khai báo phương thức khởi tạo 0 tham số
    public Product()
    {
        this.name = "Khong ten";
        this.price = 0;
    }

    // Khai báo thuộc tính Name - lấy hoặc thiết lập tên sản phẩm
    public string Name
    {
        set { this.name = value; }
        get { return name; }
    }
}

// Trong lớp có các phương thức mà thực hiện một biểu thức đơn giản, thì bạn có thể gán ngay biểu thức vào tên phương thức bằng ký hiệu =>, kể cả setter và getter
class Category
{
    private string categoryName;

    public Category(string categoryName) => this.categoryName = categoryName;

    public string CategoryName
    {
        set => this.categoryName = value;
        get => this.categoryName;
    }
}

// Kế thừa phương thức khởi tạo của lớp base
class CategoryMobile : Category
{
    private string description;
    /*
        Khi phương thức khởi tạo này được gọi, nó gọi phương thức khởi tạo có
        một tham số của lớp cơ sở (Category) trước, rồi mới thi hành các code
        trong thân của phương thức khởi tạo này
    */
    public CategoryMobile(string nameofCategory, string description) : base(nameofCategory)
    {
        this.description = description;
    }

    public string Description
    {
        set => description = value;
        get => description;
    }
}

// Phương thức khởi tạo riêng tư
/*
Khi xây dựng một số lớp đặc biệt, nhất là những lớp tiện ích chỉ chứa thành viên tĩnh, bạn mong muốn chỉ ra một cách tường minh lớp này không được phép tạo đối tượng, lớp này không được phép kế thừa thì hãy cho vào một phương thức khởi tạo không tham số và chỉ ra trạng thái truy cập là private
*/
class MyLib
{
    public static double PI = 3.14;

    private MyLib()
    {

    }
}

// Phương thức khởi tạo tĩnh
/*
    Khi xây dựng một số lớp đặc biệt, nhất là những lớp tiện ích chỉ chứa thành viên tĩnh, bạn mong muốn chỉ ra một cách tường minh lớp này không được phép tạo đối tượng, lớp này không được phép kế thừa thì hãy cho vào một phương thức khởi tạo không tham số và chỉ ra trạng thái truy cập là private
*/
class MyColorCode
{
    public static string color_primary;
    public static string color_success;
    public static string color_danger;
    public static string color_warning;
    public static string color_info;

    // Phương thức khởi tạo tĩnh, được gọi khi lần đầu truy cập một thành viên dữ liệu tĩnh    
    static MyColorCode()
    {
        Console.WriteLine("Static MyColorCode Constructor call");   
        color_danger = "Red";
        color_info = "Cyan";
        color_primary = "Navy";
        color_success = "Green";
        color_warning = "Yellow";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Constructor được thi hành ngay khi khởi tạo đối tượng
        Product product = new Product();
        Console.WriteLine(product.Name); // Khong ten

        Product product1 = new Product("Laptop", 20000);
        Console.WriteLine(product1.Name); // Laptop

        CategoryMobile cat1 = new CategoryMobile("Dien thoai", "Danh muc cac loai dien thoai");
        Console.WriteLine(cat1.CategoryName);
        Console.WriteLine(cat1.Description);

        Console.WriteLine(MyColorCode.color_danger);
        Console.WriteLine(MyColorCode.color_info);        
    }
}
