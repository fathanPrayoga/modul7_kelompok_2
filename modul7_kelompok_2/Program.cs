
using modul7_kelompok_2;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        DataMahasiswa103022330070 dataMahasiswa = new DataMahasiswa103022330070();

        dataMahasiswa.ReadJSON();

        TeamMembers103022330070 team = new TeamMembers103022330070();
        team.ReadJSON();
    }
}

