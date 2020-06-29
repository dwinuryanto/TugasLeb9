using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tugas8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Karyawan> listKaryawan = new List<Karyawan>();

            void Tampilan()
            {
                int Urut = 1;

                foreach (Karyawan karyawan in listKaryawan)
                {
                    Console.WriteLine("{0}. {2}, NIK: {1}, Nama: {4} , Gaji: {3}, ", Urut, karyawan.NIK, karyawan.Nama, karyawan.Gaji(), karyawan.JK);

                     Urut++;
                }
            }

            void tambahKarTap(string nama, string nik, string jk, double gajibulanan)
            {
                listKaryawan.Add(new KaryawanTetap { Nama = nama, NIK = nik, GajiBulanan = gajibulanan, JK = jk });
            }

            void tambahKaHar(string nama, string nik, string jk, int jumjamkerja, int upah)
            {
                listKaryawan.Add(new KaryawanHarian { Nama = nama, NIK = nik, JK = jk, JumJamKerja = jumjamkerja, UpahPerJam = upah });
            }

            void tambahSales(string nama, string nik, string jk, int jumlahpenjualan, int Upah)
            {
                listKaryawan.Add(new Sales { Nama = nama, NIK = nik, JK = jk, JumlahPenjualan = jumlahpenjualan, Upah = Upah });
            }

            void hapusdata()
            {
                int no = 1;
                int jum_karyawan = 0;

                foreach (Karyawan karyawan in listKaryawan)
                {
                    Console.WriteLine("{0}. Nik: {1}", no, karyawan.NIK);

                    no++;
                    jum_karyawan += 1;
                }
                Console.WriteLine();
                Console.Write("Pilih Data Yang Ingin Dihapus [1-");
                Console.Write(jum_karyawan);
                Console.Write("] : ");
                int index_nik = int.Parse(Console.ReadLine());
                index_nik = index_nik - 1;

                listKaryawan.RemoveAt(index_nik);
                Console.WriteLine();
                Console.WriteLine("Data Karyawan Berhasil Dihapus ");
                Console.WriteLine();
                Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
            }

            bool keluar = false;
            while (keluar == false)
            {
                Console.Title = "Tugas Lab 9 (Pertemuan 12)- Polymorphsim, Inheritance, Abstraction & Collection Part #2";
                Console.WriteLine("Pilih Menu Aplikasi :");
                Console.WriteLine();
                Console.WriteLine("1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Keluar");
                Console.WriteLine();
                Console.Write("Nomer Menu [1..4] = ");
                int pilih = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
                if (pilih < 1)
                {
                    Console.WriteLine("Maaf, Menu Yang Anda Pilih Tidak Tersedia");
                }
                else if (pilih > 4)
                {
                    Console.WriteLine("Maaf, Menu Yang Anda Pilih Tidak Tersedia");
                }
                else if (pilih == 1)
                {
                    Console.WriteLine("Tambah Data Karyawan");
                    Console.WriteLine();
                    Console.Write("Jenis Karyawan [1. Karyawan Tetap, 2. Karyawan Harian, 3. Sales] : ");
                    int jk = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (jk == 1)
                    {
                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string nama = Console.ReadLine();
                        Console.Write("Gaji Bulanan = ");
                        int gj = int.Parse(Console.ReadLine());
                        string jenis = "Karyawan Tetap";

                        tambahKarTap(jenis, nik, nama, gj);
                    }
                    else if (jk == 2)
                    {
                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string nama = Console.ReadLine();
                        Console.Write("Jumlah Jam Kerja = ");
                        int jamkerja = int.Parse(Console.ReadLine());
                        Console.Write("Upah Per Jam = ");
                        int upah = int.Parse(Console.ReadLine());
                        string jenis = "Karyawan Harian";

                        tambahKaHar(jenis, nik, nama, jamkerja, upah);
                    }
                    else if (jk == 3)
                    {

                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string nama = Console.ReadLine();
                        Console.Write("Jumlah Jual = ");
                        int jumlahjual = int.Parse(Console.ReadLine());
                        Console.Write("Upah = ");
                        int Upah = int.Parse(Console.ReadLine());
                        string jenis = "Sales";

                        tambahSales(jenis, nik, nama, jumlahjual, Upah);
                    }
                    else
                    {
                        Console.WriteLine("Menu salah");
                    }
                    Console.WriteLine();
                    Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");


                }
                else if (pilih == 2)
                {
                    hapusdata();
                }
                else if (pilih == 3)
                {
                    Console.WriteLine("Data Karyawan");
                    Console.WriteLine();
                    Tampilan();

                    Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
                }
                else if ( pilih == 4)
                {
                    keluar = true;
                }

                Console.ReadLine();
            }
        }
    }
}
