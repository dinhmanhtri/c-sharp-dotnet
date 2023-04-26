# C# markdown

## Struct & Enum

### 1. Struct

- Struct: là kiểu tham trị, gộp các dữ liệu có liên quan thành một nhóm (đóng gói dữ liệu).
- Trong struct có thể chứa: Trường dữ liệu, thuộc tính, phương thức khởi tạo, hằng số, các phương thức, toán tử, sự kiện.
- Example:
 ```C#
 public struct Product
 {
  // Truong du lieu - data field
  public string name;
  public int price;
  
  // Thuoc tinh - properties
  public string Name {set => name = value; get => name;}
  public string Price {set => price = value; get => price;}
  
  // Phuong thuc khoi tao - constructor
  // Note: Co bao nhieu fields, methods phai khoi tao het trong constructor 
  public Product (string _name, int _price)
  {
   name = _name;
   price = _price;
  }

  // Phuong thuc - method
  public string GetInfo() => $"Ten san pham: {name}, gia: {price}";
 }

 Product car = new Product(CX5, 1000); // Truong hop co constructor
 Product car; // Truong hop khong co constructor
 ```

### 2. Enum

- Kiểu liệt kê (enum) khai báo một tập hợp các hằng số có tên. Mặc định giá trị các hằng số là kiểu int và bắt đầu từ 0.
- Ex:
 ```C#
 enum HocLuc {Kem, TrungBinh, Kha, Gioi} // 0, 1, 2, 3
 HocLuc hocLuc;
 int num = (int)HocLuc.Kem; // 0: Ep kieu tu enum -> int
 hocLuc = (HocLuc)(3); // Gioi: Ep kieu tu int -> enum
 ```  

## Basic

### 1. Class and Object

- Class là khuôn mẫu hoặc bản thiết kế để tạo Object.
- Object là 1 thể hiện của Class.

> Mọi đối tượng trong C# đều phải thuộc về lớp.

- Trong C# có 5 loại Class:
  - Abstract Class
  - Concrete Class
  - Sealed Class
  - Partial Class
  - Static Class

### 2. Constructor

- Constructor chịu trách nghiệm khởi tạo các biến của một Class.
- Tên của constructor bắt buộc phải giống với tên Class.
- Constructor không trả về giá trị nào.
- Nếu chúng ta không khởi tạo constructor thì trình biên dịch sẽ tự động khởi tạo một constructor - ngầm định (Implicit Constructor)
=> Khi đó mọi biến và trường khai báo bên trong một lớp đều được khởi tạo giá trị mặc định.
=> Tất cả các kiểu số = 0, Boolean = false, string & object = null.
- Syntax:
 ```C#
 <modifiers> ClassName(param1, param2...)
 {
  //Statements
 }
 ```

- Constructor trong C#:
  - Có tất các phạm vi truy cập: public, private, protected, ...
  - Có thể có tham số hoặc không.
  - Có thể ném ra ngoại lệ (throw) từ constructor.
  - Có thể có logic và tất cả các câu lệnh hợp lệ trong C# ngoại trừ các câu lệnh return có giá trị.

### 3. Types of Constructors in C #
 >
 > Có 5 loại Constructors có sẵn trong C#.
 >
#### Constructor mặc định hoặc không tham số

- Constructor mặc định do trình biên dịch tạo ra: Sẽ gán giá trị mặc định cho các thành viên dữ liệu (non-static variables).
  > Khi nào cần cung cấp constructors một cách rõ ràng?
  => Nếu muốn thực thi một số logic tùy chỉnh hữu ích tại thời điểm tạo đối tượng.

- Constructor mặc định do người dùng định nghĩa: Fix cứng gán giá trị cho data members. Khi khởi tạo đối tượng tất cả sẽ dùng chung một bộ giá trị (**nhược điểm**).

#### Constructor có tham số

- Cần thiết khi khởi động một object với các giá trị do người dùng định nghĩa.

### 4. Inheritance (Tính kế thừa)

- **Lớp cơ sở** (base class) là lớp khác kế thừa.
- **Lớp kế thừa** () là lớp kế thừa lại các thuộc tính và phương thức của lớp cơ sở.
- Syntax:
 ```C#
 class InheritedClass : BaseClass
 {
  // Statement
 }
 ```

#### Thành viên được bảo vệ (protected) của lớp cơ sở

- Các Modify:
  - **public**: Thành viên có thể truy cập được bởi code bất kỳ đâu.
  - **private**:  Chỉ có thể truy cập, gọi bởi các dòng code cùng class.
  - **protected**: Chỉ có thể truy cập, gọi bởi các dòng code cùng class hoặc các class kế thừa nó.
  - **internal**: Truy cập bởi code trong cùng assembly (file).
  - **protected internal**: Truy cập được từ code assembly, hoặc lớp kế thừa .
  - **private protected**: Truy cập được code khi cùng assembly trong cùng lớp, hoặc các lớp kế thừa nó.

#### Lớp niêm phong (sealed)

- Sử dụng sealed để ngăn không cho kế thừa gây mất kiểm soát, nhất là khi dự án lớn, nhiều người tham gia.
- Syntax:
 ```C#
 sealed class A {
 } 
 class B : A { // error: Khong duoc phep ke thua lop bi niem phong
 }
 ```

> C# không hỗ trợ đa kế thừa (mỗi lớp kế thừa chỉ có một lớp cơ sở).

#### Phương thức hủy và khởi tạo khi kế thừa

> Note: Khi có sự kế thừa thì constructor của base class chạy trước, xong đến constructor của class kế thừa.

Tuy nhiên, khi constructor của base class có nhiều tham số hoặc overload thì constructor của class kế thừa phải chỉ định rõ sẽ chạy constructor nào của base class. Ex:

```C#
 class A {
  public A(string mes)
  {
   Console.WriteLine($"Init A string: {mes}");
  }

  public A(int num)
  {
   Console.WriteLine($"Init A num: {num}");
  }
 }

 class B : A
 {
  public B(string txt) : base(2)
  {
   Console.WriteLine($"Init B {txt}");
  }
 }

 new B("Hello");
 // Output: 
 // Init A num: 2
 // Init B Hello
```

Đối với các phương thức hủy, khi đối tượng hủy sẽ thi hành phương thức hủy của lớp kế thừa trước.

#### Chuyển kiểu, tương thích về kiểu khi sử dụng class

Chỉ có thể chuyển kiểu ngược từ lớp kế thừa -> base class (tường minh or ngầm định). Example:

```C#
class Animal
{
};
class FourLegs : Animal
{
};
class Dog : FourLegs
{
};

Dog bun = new Dog();
animal = (Animal)bun; // chuyển kiểu tường minh
animal = bun   // chuyển kiểu ngầm định
FourLegs ani = bun;  // ngầm định
bun = new Animal();  // error: Không thể chuyển kiểu từ cha -> con
```

### 5. Namespace

- Namespace khai báo một phạm vi chứa tập hợp các đối tượng liên quan nhau.
- **Mục đích**: Tổ chức code khoa  học, dễ quản lý, tránh xung đột về tên (có thể khai báo 2 class trùng tên nhau nhưng ở namespace khác nhau).
- Các thành phần được khai báo trong một namespace: namespace con, class, interface, struct, enum, delegate.
- Một namespace có thể định nghĩa ở nhiều file code (.cs) khác nhau. Để sử dụng một thành phần của namespace thì sử dụng từ khóa `using` ở đầu file để nạp.
- Các namespace cũng có thể khai báo lồng nhau.
- `using` có thể được sử dụng để đặt tên tắt cho namespace (tên sử dụng trong phạm vi code) . Ex: `using Text = System.Text;`
- Sử dụng `using` để truy cập trực tiếp phương thức tĩnh. Ex:

```C#
 using static System.Console; // cho biết sử dụng trực tiếp phương thức tĩnh.
 WriteLine("Hello");
```

### 6. Partial, Nested

- `Partial` chia code định nghĩa class, interface, struct ra thành nhiều file => khi biên dịch sẽ tổng hợp lại thành một.

> Note: Trong định nghĩa ở tất các phần đều phải có từ khóa **partial**

- Nested type là kiểu khai báo một class, interface, struct trong thân một class khác. Ex:
 ```C#
 public class Container
 {
  public class Nested
  {
   public Nested() {}
  }
 }

 // Use nested class
 Container.Nested nested = new Container.Nested();
 ```

### 7. Generic

- **Generic** là kiểu đại diện, khi chương trình thực thi thì kiểu dữ liệu cụ thể mới được xác định.
- Tác dụng: Tránh lặp lại code nhiều lần với những giải thuật giống nhau nhưng khác kiểu dữ liệu.
- Phương thức Generic:
 ```C#
 // X & Y la hai kieu du lieu
 indentifier type FunctionName<X, Y> (X x, Y y)
 {
  // code
 }

 // Use generic method
 FunctionName<type1, type2>(param1, param2);
 ```

- Lớp Generic:
 ```C#
 class ClassName<T>
 {
  private T variableName;
  
  // constructor
  public ClassName(T value)
  {
   variableName = value;
  }
  
  // method
  public T MethodName(T param)
  {
   Console.WriteLine(param);
   return variableName;
  }

  // properties
  public T PropertyName {set; get;} 
 }
 ```

### 8. Anonymous type and dynamic type

#### Anonymous Type

- Kiểu vô danh (Anonymous Type) là kiểu không có tên, tạo ra đối tượng chứa các thuộc tính _(read-only)_ mà không cần phải khai báo lớp.
- Sử dụng từ khóa new để tạo ra các đối tượng kiểu vô danh. Example:
 ```C#
 var obj = new {
  property1 = value1;
  property2 = value2;
 }

 Console.WriteLine(obj.property1); // value1
 ```

- Được sử dụng phổ biến trong LINQ.

> Khi có đối tượng kiểu vô danh, nếu dùng nó truyền tham số cho các method - coi nó như các **object** có thể gây lỗi khi build ứng dụng - trình biên dịch kiểm tra và báo lỗi. **Sử dụng khai báo kiểu dynamic để giải quyết vấn đề này**.

#### Dynamic Type

- Biến kiểu động - ngầm định - khai báo với từ khóa `dynamic`,  thì kiểu thực sự của biến đó được xác định bằng đối tượng gán vào ở **thời điểm chạy** (khác với kiểu ngầm định `var` kiểu xác định ngay thời điểm biên dịch). Example: `dynamic myvar`.
- Khai báo method sử dụng tham số kiểu `dynamic`:
 ```C#
 static void TestFunc(dynamic dvar)
 {
  Console.WriteLine(dvar.age); // ở thời điểm biên dịch - không biết dvar có thuộc tính age hay không, nhưng nó vẫn biên dịch
 }

 // Anonymus type
 var myProfile = new {
  name = "Tri",
  age = 20,
  address = "Ha Noi"
 }

 TestFunc(myProfile); // output: 20
 ```

### 9. Null and nullable

- `null` là một giá trị cố định biểu thị không có đối tượng nào cả (biến có giá trị null không tham chiếu đến đối tượng nào).
- `null` chỉ có thể gán được cho các biến kiểu tham chiếu (biến có kiểu dữ liệu là **class**).

> Không thể gán `null` cho những biến có kiểu dữ liệu tham trị như int, float, bool...

- Nếu muốn gán giá trị `null` cho các kiểu dữ liệu tham trị như int, float, double... thì cần khai báo biến đó có khả năng **nullable**.
- Khi nullable có giá trị thì sử dụng `.Value` để truy cập giá trị của nó
 ```C#
 int varName1;
 varName1 = null; //error: Không thể gán null cho biến kiểu tham trị 

 // Use nullable
 int? varName2;
 varName2 = null; //Ok
 varName2 = 10;
 Console.WriteLine(varName2.Value); //Đọc giá trị trong biến nullable;
 ```

> Note: Dạng khai báo đầy đủ của `int?` là `Nullable<int>`

### 10. String

- String trong C# là kiểu tham chiếu.
- **string** là alias của **String**. Theo quy ước sử dụng **string** để khai báo biến, sử dụng **String** để gọi phương thức.
- String trong C# là bất biến, tức là khi được gán lại sẽ tạo ra một đối tượng khác và đối tượng cũ sẽ không mất đi mà chờ .net thu gom. Nếu chuỗi mới giống với chuỗi cũ thì nó sẽ vẫn sử dụng đối tượng cũ.
 ```C#
 string txt = "Hello"; //Tạo ra một đối tượng kiểu string và gán giá trị cho nó
 txt = "Hi"; //Tạo một đối tượng khác và gán giá trị mới, đối tượng cũ sẽ chờ thu gom
 ```

- Chính việc tạo đối tượng mới của **String** nên gây ảnh hưởng đến hiệu năng. Lớp **StringBuilder** sẽ khắc phục vấn đề này (sử dụng cùng 1 vị trí bộ nhớ).
