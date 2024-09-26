﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas1PBO
{
    class Hewan
    {
        public string Nama;
        public int Umur;

        public Hewan(string nama, int umur)
        {
            Nama = nama;
            Umur = umur;
        }

        public virtual string Suara()
        {
            return "Hewan bersuara";
        }
        public virtual string InfoHewan()
        {
            return $"Nama: {Nama}, Umur: {Umur}";
        }
    }

    class Mamalia : Hewan
    {
        public int jumlahKaki;

        public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
        {
            this.jumlahKaki = jumlahKaki;
        }
        public override string Suara()
        {
            return "Hewan mamalia bersuara";
        }
        public override string InfoHewan()
        {
            return base.InfoHewan() + $", Jumlah Kaki: {jumlahKaki}";
        }
    }

    class Reptil : Hewan
    {
        public double panjangTubuh;

        public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
        {
            this.panjangTubuh = panjangTubuh;
        }
        public override string Suara()
        {
            return "Hewan reptil bersuara";
        }
        public override string InfoHewan()
        {
            return base.InfoHewan() + $", Panjang tubuh: {panjangTubuh}";
        }
    }

    class Singa : Mamalia
    {
        public Singa(string Nama, int Umur, int jumlahKaki) : base(Nama, Umur, jumlahKaki)
        {

        }
        public override string Suara()
        {
            return "Singa bersuara";
        }
        public void Mengaum()
        {
            Console.WriteLine("Singa mengaum");
        }
    }

    class Gajah : Mamalia
    {
        public Gajah(string Nama, int Umur, int jumlahKaki) : base(Nama, Umur, jumlahKaki)
        {

        }
        public override string Suara()
        {
            return "Gajah bersuara";
        }
    }

    class Ular : Reptil
    {
        public Ular(string Nama, int Umur, double panjangTubuh) : base(Nama, Umur, panjangTubuh)
        {

        }
        public override string Suara()
        {
            return "Ular bersuara";
        }
        public void Merayap()
        {
            Console.WriteLine("Ular merayap");
        }
    }

    class Buaya : Reptil
    {
        public Buaya(string Nama, int Umur, double panjangTubuh) : base(Nama, Umur, panjangTubuh)
        {

        }
        public override string Suara()
        {
            return "Buaya bersuara";
        }
    }
    class KebunBinatang
    {
        public List<Hewan> listHewan = new List<Hewan>();

        public void TambahHewan(Hewan hewan)
        {
            listHewan.Add(hewan);
        }
        public void DaftarHewan()
        {
            foreach (var hewan in listHewan)
            {
                Console.WriteLine(hewan.InfoHewan());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KebunBinatang kebunBinatang = new KebunBinatang();

            Singa singa = new Singa("Richard", 8, 4);
            Gajah gajah = new Gajah("Donphan", 4, 4);
            Ular ular = new Ular("πthon", 3, 3.14159);
            Buaya buaya = new Buaya("Nero", 3, 3.5);

            kebunBinatang.TambahHewan(singa);
            kebunBinatang.TambahHewan(gajah);
            kebunBinatang.TambahHewan(ular);
            kebunBinatang.TambahHewan(buaya);

            Reptil reptil = new Buaya("Sanppy", 5, 3.8); // Hasil coba untuk no. 5
            kebunBinatang.TambahHewan(reptil); // Hasil coba untuk no. 5

            kebunBinatang.DaftarHewan();

            Console.WriteLine();
            Console.WriteLine(reptil.Suara()); // Hasil coba untuk no. 5

            Console.WriteLine(singa.Suara());
            Console.WriteLine(gajah.Suara());
            Console.WriteLine(ular.Suara());
            Console.WriteLine(buaya.Suara());
            Console.WriteLine();

            singa.Mengaum();
            ular.Merayap();
        }
    }
}
