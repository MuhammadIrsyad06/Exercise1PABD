using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exercise1PABD
{
    class Program
    {
        public void CreateTabel()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection ("data source=MUHAMMAD-IRSYAD;database=Exercise1;Integrated Security=TRUE");
                con.Open();

                SqlCommand ob = new SqlCommand("create table Obat (Id_Obat char(4) primary key," +
                    "Nama_Obat varchar(100), Jumlah varchar(3), Jenis_Obat varchar(100))", con);
                ob.ExecuteNonQuery();
                SqlCommand pt = new SqlCommand("create table Petugas (Id_Petugas char(5) primary key," +
                   "Nama varchar(50), NIK char(16), HP char(12), Alamat varchar(100))", con);
                pt.ExecuteNonQuery();
                SqlCommand pb = new SqlCommand("create table Pembeli (Id_Pembeli char(5) primary key," +
                   "Nama varchar(50), Umur char(2))", con);
                pb.ExecuteNonQuery();
                SqlCommand ts = new SqlCommand("create table Transaksi (Id_Transaksi char(3) primary key," +
                  "Waktu_Transaksi char(5),Tanggal_Transaksi char(8), Id_Pembeli char(5) foreign key references Pembeli(Id_Pembeli), Id_Petugas char(5) foreign key references Petugas(Id_Petugas)," +
                  "Id_Obat char(4) foreign key references Obat(Id_Obat))", con);
                ts.ExecuteNonQuery();

                Console.WriteLine("Tabel Berhasil DIbuat!!");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Perhatikan lagi ada yang salah!! " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        public void InsertTabel()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=MUHAMMAD-IRSYAD;database=Exercise1;Integrated Security=TRUE");
                con.Open();

                SqlCommand ob = new SqlCommand("insert into Obat (Id_Obat, Nama_Obat, Jumlah, Jenis_Obat)" +
                    "values('AB01','Panadol','2', 'Sakit Kepala')", con);
                ob.ExecuteNonQuery();
                SqlCommand ob1 = new SqlCommand("insert into Obat (Id_Obat, Nama_Obat, Jumlah, Jenis_Obat)" +
                    "values('AB02','Paracetamol','4', 'Penurun Panas')", con);
                ob1.ExecuteNonQuery();
                SqlCommand ob2 = new SqlCommand("insert into Obat (Id_Obat, Nama_Obat, Jumlah, Jenis_Obat)" +
                    "values('AB05','Bye-Bye Fever','2', 'Penurun Panas')", con);
                ob2.ExecuteNonQuery();
                SqlCommand ob3 = new SqlCommand("insert into Obat (Id_Obat, Nama_Obat, Jumlah, Jenis_Obat)" +
                    "values('AB10','Antangin','5', 'Pencegah Kembung')", con);
                ob3.ExecuteNonQuery();
                SqlCommand ob4 = new SqlCommand("insert into Obat (Id_Obat, Nama_Obat, Jumlah, Jenis_Obat)" +
                    "values('AB15','Komix','3', 'Obat Batuk')", con);
                ob4.ExecuteNonQuery();

                SqlCommand pt = new SqlCommand("insert into Petugas (Id_Petugas, Nama, NIK, HP,Alamat)" +
                    "values('KF001','Irsyad','1308030609020001', '081377559034','Gamping')", con);
                pt.ExecuteNonQuery();
                SqlCommand pt1 = new SqlCommand("insert into Petugas (Id_Petugas, Nama, NIK, HP,Alamat)" +
                    "values('KF002','Supra','1308030512020003', '082250398591','Bantul')", con);
                pt1.ExecuteNonQuery();
                SqlCommand pt2 = new SqlCommand("insert into Petugas (Id_Petugas, Nama, NIK, HP,Alamat)" +
                    "values('KF003','Anto','1308031510050005', '081231205903','Sleman')", con);
                pt2.ExecuteNonQuery();
                SqlCommand pt3 = new SqlCommand("insert into Petugas (Id_Petugas, Nama, NIK, HP,Alamat)" +
                    "values('KF004','Mulya','1308030403970001', '085298104018','Kaliurang')", con);
                pt3.ExecuteNonQuery();
                SqlCommand pt4 = new SqlCommand("insert into Petugas (Id_Petugas, Nama, NIK, HP,Alamat)" +
                    "values('KF005','Lance','1308030902010001', '081380429438','Wonosari')", con);
                pt4.ExecuteNonQuery();

                SqlCommand pb = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama, Umur)" +
                    "values('CH001','Makmur','27')", con);
                pb.ExecuteNonQuery();
                SqlCommand pb1 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama, Umur)" +
                    "values('CH002','Mawar','19')", con);
                pb1.ExecuteNonQuery();
                SqlCommand pb2 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama, Umur)" +
                    "values('CH003','Pola','25')", con);
                pb2.ExecuteNonQuery();
                SqlCommand pb3 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama, Umur)" +
                    "values('CH004','Zainab','40')", con);
                pb3.ExecuteNonQuery();
                SqlCommand pb4 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama, Umur)" +
                    "values('CH005','Ulfa','20')", con);
                pb4.ExecuteNonQuery();

                SqlCommand ts = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Pembeli, Id_Petugas, Id_Obat, Waktu_Transaksi, Tanggal_Transaksi)" +
                    "values('010','CH002','KF003','AB10','10.50','12022022')", con);
                ts.ExecuteNonQuery();
                SqlCommand ts1 = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Pembeli, Id_Petugas, Id_Obat, Waktu_Transaksi, Tanggal_Transaksi)" +
                    "values('011','CH004','KF002','AB15','13.40','15022022')", con);
                ts1.ExecuteNonQuery();
                SqlCommand ts2 = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Pembeli, Id_Petugas, Id_Obat, Waktu_Transaksi, Tanggal_Transaksi)" +
                    "values('012','CH005','KF003','AB02','16.15','06012022')", con);
                ts2.ExecuteNonQuery();
                SqlCommand ts3 = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Pembeli, Id_Petugas, Id_Obat, Waktu_Transaksi, Tanggal_Transaksi)" +
                    "values('013','CH003','KF005','AB05','20.30','24032022')", con);
                ts3.ExecuteNonQuery();
                SqlCommand ts4 = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Pembeli, Id_Petugas, Id_Obat, Waktu_Transaksi, Tanggal_Transaksi)" +
                    "values('014','CH001','KF004','AB01','14.01','27042022')", con);
                ts4.ExecuteNonQuery();

                Console.WriteLine("Sukses!!!");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Gagal Menginput data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        public void Data()
        {
            while(true)
            {
                try
                {
                    int choose;
                    Console.WriteLine("Apotek Irsyad Farma24");
                    Console.WriteLine("Silahkan Pilih");
                    Console.WriteLine("==============");
                    Console.WriteLine("1. Membuat Tabel");
                    Console.WriteLine("2. Menginput Data");
                    Console.WriteLine("3. Keluar");
                    Console.Write("Pilih 1/2/3 = ");
                    choose = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");

                    switch (choose)
                    {
                        case 1:
                            CreateTabel();
                            break;
                        case 2:
                            InsertTabel();
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak tersedia");
                            break;
                            

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Silahkan pilih angka 1-3");
                }
            }
        }
        static void Main(string[]args)
        {
            Program p = new Program();
            p.Data();
        }
    }
}
