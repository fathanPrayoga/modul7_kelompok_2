using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace tpmodul7_kelompok_02
{
    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public class Team
    {
        public List<Member> members { get; set; }
    }

    class TeamMembers_103022300159_achmadFadjry
    {
        public static void ReadJSON()
        {
            string filePath = "jurnal7_2_103022300159.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);
                Team team = JsonSerializer.Deserialize<Team>(jsonString);

                Console.WriteLine("Team member list:");
                foreach (var member in team.members)
                {
                    Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat membaca file JSON: " + ex.Message);
            }
        }
    }
}
