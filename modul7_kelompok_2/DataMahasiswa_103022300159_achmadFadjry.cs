using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace modul7_kelompok_02
{
    public class alamat
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class matkul
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public alamat address { get; set; }
        public List<matkul> courses { get; set; }
    }

    class DataMahasiswa_103022300159_achmadFadjry
    {
        public static void ReadJSON()
        {
            string filePath = "jurnal7_1_103022300159.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);
                Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

                Console.WriteLine($"Nama: {data.firstName} {data.lastName}");
                Console.WriteLine($"Gender: {data.gender}");
                Console.WriteLine($"Usia: {data.age}");
                Console.WriteLine("Alamat:");
                Console.WriteLine($"  Jalan: {data.address.streetAddress}");
                Console.WriteLine($"  Kota: {data.address.city}");
                Console.WriteLine($"  Provinsi: {data.address.state}");
                Console.WriteLine("Mata Kuliah:");
                foreach (var course in data.courses)
                {
                    Console.WriteLine($"  - {course.code}: {course.name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat membaca file JSON: " + ex.Message);
            }
        }
    }
}
