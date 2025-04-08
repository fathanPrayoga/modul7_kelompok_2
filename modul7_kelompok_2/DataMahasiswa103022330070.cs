using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace modul7_kelompok_2
{
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    public class Course
    {
        public string code { get; set; }
        public string name{ get; set; }
    }
    public class DataMahasiswa103022330070
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Course> courses { get; set; }

        public void ReadJSON()
        {
            string filename = "jurnal7_1_103022330070.json";
            string jsonString = File.ReadAllText(filename);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            DataMahasiswa103022330070 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa103022330070>(jsonString, options);
            Console.WriteLine("DATA MAHASISWA");
            Console.WriteLine($"Nama Lengkap: {mahasiswa.firstName} {mahasiswa.lastName}");
            Console.WriteLine($"gender: {mahasiswa.gender}");
            Console.WriteLine($"usia: {mahasiswa.age}");
            Console.WriteLine(" ");
            Console.WriteLine("ALAMAT");
            Console.WriteLine($"jalan: {mahasiswa.address.streetAddress}");
            Console.WriteLine($"kota: {mahasiswa.address.city}");
            Console.WriteLine($"provinsi: {mahasiswa.address.state}");
            Console.WriteLine(" ");
            Console.WriteLine("MATA KULIAH");
            foreach (var course in mahasiswa.courses)
            {
                Console.WriteLine($"- Kode: {course.code}, Nama: {course.name}");
            }


        }
    }
}
