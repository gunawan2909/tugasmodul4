using System;
using System.Collections.Generic;
using System.Text;

namespace tugas
{
    class abc
    {
        static void senin()
        {
            String[] x = { "Sistem digital pada pukul08.50-10.30", "Praktikum DKP pada pukul 18.00-18.50", "Konsep Jaringan Komputer pada pukul 20.00-21.40" };

            foreach (String y in x)
            {
                Console.WriteLine(y + ". " + x);
            }
        }
        static void selasa()
        {
            String[] x = { "Algoritma dan Pemprogaman pada pukul 08.50-10.30", "Fisika dasar 2 pada pukul 12.30-14.10" };

            foreach (String y in x)
            {
                Console.WriteLine(y + ". " + x);
            }
        }
        static void rabu()
        {
            String[] x = { "Kalkulus 2 pada pukul 12.40-15.10", "Kecakapan Antar Personal pada pukul 15.10-16.50" };

            foreach (String y in x)
            {
                Console.WriteLine(y + ". " + x);
            }
        }
        static void kamis()
        {
            String[] x = { "Kewarganegaraan pada pukul 08.20-10.00", "Metode Penelitian pada pukul 12.30-14.10" };
            Console.WriteLine("Mata kuliah :");
            foreach (String y in x)
            {
                Console.WriteLine(y + ". " + x);
            }
        }
        static void jumat()
        {
            String[] x = { "Etika Provesi pada jam 07.00-08,40", "Elektonika dasar pada jam 14.00-16.30", "Praktimu Fisika dasar pada pukul 18.00-18.50" };
            Console.WriteLine("Mata kuliah :");
            foreach (String y in x)
            {
                Console.WriteLine(y + ". " + x);
            }
        }
    }
}