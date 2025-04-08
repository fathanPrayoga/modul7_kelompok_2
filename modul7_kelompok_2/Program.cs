using System;
using modul7_kelompok_2;

class Program
{
    static void Main(string[] args)
    {
        var data = DataMahasiswa_103022300025.ReadJSON(@"jurnal7_1_103022300025.json");
        Console.WriteLine("===== DATA MAHASISWA =====");
        data.PrintData();

        Console.WriteLine(); 

        var team = TeamMembers_103022300025.ReadJSON(@"jurnal7_2_103022300025.json");
        Console.WriteLine("===== TEAM MEMBERS =====");
        team.PrintData();
    }
}
