using System;

namespace CS003_Class
{
    /*
        <Access Modifiers> class Class_Name {
            // khai báo các thành viên dữ  liệu (thuộc tính, biến trường dữ liệu)
            // khai báo các thành viên  hàm (phương thức)
        }
    */

    class Vukhi
    {
        // TRUONG DU LIEU
        public string name = "Ten vu khi"; // Neu khong chi ra access modifier => mac dinh la private
        int doSatThuong = 0;

        // THUOC TINH

        // "get", "set" tu dong
        public string NoiSanXuat { get; set; }

        public int SatThuong
        {
            // Khi chi co "set" thi thuoc tinh chi co the gan ma khong the doc va nguoc lai
            // Thi hanh khi su dung toan tu =
            set { doSatThuong = value; }
            // Thi hanh khi truy cap
            get { return doSatThuong; }
        }

        // PHUONG THUC KHOI TAO (CONSTRUCTOR)
        public Vukhi()
        {
            Console.WriteLine("Khoi tao");
        }

        public Vukhi(string name, int doSatThuong)
        {
            this.name = name;
            this.doSatThuong = doSatThuong;
        }

        // PHUONG THUC
        public void ThietLapSatThuong(int doSatThuong)
        {
            this.doSatThuong = doSatThuong;
            // this - ref
        }

        public void TanCong()
        {
            Console.Write(name);
            for (int i = 0; i < doSatThuong; i++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
    }
}
