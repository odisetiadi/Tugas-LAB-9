using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLab9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KaryawanTetap> karyawantetap = new List<KaryawanTetap>();
            List<KaryawanHarian> karyawanharian = new List<KaryawanHarian>();
            List<Sales> sales = new List<Sales>();

        menu:
            Console.WriteLine("1. Input Data Karyawan");
            Console.WriteLine("2. Lihat Data Karyawan");
            Console.WriteLine("3. Hapus Data Karyawan");
            Console.WriteLine("4. Keluar");
            Console.WriteLine();
            Console.Write("Silahkan Pilih [1-4] : ");
            int pilihan;
            int pil;
            pilihan = int.Parse(Console.ReadLine());

            if (pilihan == 1)
            {
                Console.WriteLine("1. Input Data Karyawan Tetap");
                Console.WriteLine("2. Input Data Karyawan Harian");
                Console.WriteLine("3. Input Data Sales");
                Console.WriteLine();
                Console.Write("Silahkan Pilih [1-3] : ");
                pil = int.Parse(Console.ReadLine());

                if (pil == 1)
                {
                    string nik, nama;
                    double gajibulanan;
                    Console.WriteLine("Masukan Nik : ");
                    nik = Console.ReadLine();
                    Console.WriteLine("Masukan Nama : ");
                    nama = Console.ReadLine();
                    Console.WriteLine("Masukan Gaji Bulanan : ");
                    gajibulanan = int.Parse(Console.ReadLine());

                    karyawantetap.Add(new KaryawanTetap() { Nik = nik, Nama = nama, GajiBulanan = gajibulanan });
                }

                else if (pil == 2)
                {
                    string nik, nama;
                    double jam;
                    double upah;
                    Console.WriteLine("Masukan Nik : ");
                    nik = Console.ReadLine();
                    Console.WriteLine("Masukan Nama : ");
                    nama = Console.ReadLine();
                    Console.WriteLine("Masukan Jumlah Jam : ");
                    jam = int.Parse(Console.ReadLine());
                    Console.WriteLine("Masukan Jumlah Upah : ");
                    upah = int.Parse(Console.ReadLine());

                    karyawanharian.Add(new KaryawanHarian() { Nik = nik, Nama = nama, JumlahJamKerja = jam, UpahPerJam = upah });
                }

                else if (pil == 3)
                {
                    string nik, nama;
                    double jual;
                    double komisi;
                    Console.WriteLine("Masukan Nik : ");
                    nik = Console.ReadLine();
                    Console.WriteLine("Masukan Nama : ");
                    nama = Console.ReadLine();
                    Console.WriteLine("Masukan Jumlah Penjualan : ");
                    jual = int.Parse(Console.ReadLine());
                    Console.WriteLine("Masukan Komisi : ");
                    komisi = int.Parse(Console.ReadLine());

                    sales.Add(new Sales() { Nik = nik, Nama = nama, JumlahPenjualan = jual, Komisi = komisi });
                }
                Console.WriteLine("Tekan Enter Untuk Lanjut");
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }

            else if (pilihan == 2)
            {
                Console.WriteLine("Data Karyawan");
                Console.WriteLine();
                int no = 1;
                foreach (Karyawan karyawan in karyawantetap)
                {
                    Console.WriteLine("{0}. Nik : {1}, Nama : {2}, Gaji : {3}, Karyawan Tetap",
                    no, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                    no++;
                }

                foreach (Karyawan karyawan in karyawanharian)
                {
                    Console.WriteLine("{0}. Nik : {1}, Nama : {2}, Gaji : {3}, Karyawan Harian",
                    no, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                    no++;
                }

                foreach (Karyawan karyawan in sales)
                {
                    Console.WriteLine("{0}. Nik : {1}, Nama : {2}, Gaji : {3}, Sales",
                    no, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                    no++;
                }

                Console.WriteLine("Tekan Enter Untuk Lanjut");
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }
            else if (pilihan == 3)
            {
                Console.WriteLine("Hapus Karyawan");
                Console.WriteLine();
                string hapus;
                Console.WriteLine("Masukan Nik yang ingin dihapus : ");
                hapus = Console.ReadLine();
                int i = 0;
                foreach (Karyawan karyawan in karyawantetap)
                {
                    if (hapus == karyawan.Nik)
                    {
                        karyawantetap.RemoveAt(i);
                        break;
                    }
                    i++;
                }
                i = 0;
                foreach (Karyawan karyawan in karyawanharian)
                {
                    if (hapus == karyawan.Nik)
                    {
                        karyawanharian.RemoveAt(i);
                        break;
                    }
                    i++;
                }
                i = 0;
                foreach (Karyawan karyawan in sales)
                {
                    if (hapus == karyawan.Nik)
                    {
                        sales.RemoveAt(i);
                        break;
                    }
                    i++;
                }
                Console.WriteLine("Data Berhasil dihapus");
                Console.WriteLine("Tekan Enter Untuk Lanjut");
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }

            else
            {
                Console.WriteLine("Terima Kasih");
            }

            Console.ReadKey(true);
            Console.Clear();
        }
    }
}