namespace CS006_Struct_Enum
{
    internal class Program
    {
        // Kieu du lieu liet ke - enum
        enum HOCLUC
        {
            Kem, TrungBinh, Gioi, Kha   // tuong ung 0, 1, 2, 3
        }

        // Du lieu cau truc - struct
        public struct Student
        {
            // Truong du lieu
            public string name;
            public int age;

            // Constructor
            // Bat buoc phai khoi tao day du name, age => neu khong se loi
            public Student(string _name, int _age)
            {
                name = _name;
                age = _age;
            }
                      
            // Property
            public string Name { set => name = value; get => name; }
            public int Age { set => age = value; get => age; }

            // Method
            public string GetInfo()
            {
                return $"Ho va ten: {name}, tuoi: {age}";
            }

        }
        static void Main(string[] args)
        {
            /* Struct
            Student student1;
            student1.name = "Tri";
            student1.age = 21;

            Student student2 = new Student("Minh", 20);

            Console.WriteLine(student2.GetInfo());
            Console.WriteLine(student1.GetInfo());
            Console.WriteLine(student1.Name);
             */

            HOCLUC hocLuc;
            hocLuc = HOCLUC.Kem;

            int num = (int)HOCLUC.Gioi; // Ep kieu tu enum -> int (3)
            hocLuc = (HOCLUC)(0); // Ep kieu tu int -> enum (Kem)

            switch (hocLuc)
            {
                case HOCLUC.Kem:
                    Console.WriteLine("Hoc luc kem!");
                    break;
                case HOCLUC.TrungBinh:
                    Console.WriteLine("Hoc luc trung binh!");
                    break;
                case HOCLUC.Kha:
                    Console.WriteLine("Hoc luc kha!");
                    break;
                case HOCLUC.Gioi:
                    Console.WriteLine("Hoc luc gioi!");
                    break;
            }    

            Console.ReadKey();
        }
    }
}