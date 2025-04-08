using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace modul7_kelompok_2
{
    public class TeamMembers_103022300025
    {
        public List<TeamMember> members { get; set; }

        public static TeamMembers_103022300025 ReadJSON(string path)
        {
            string jsonData = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<TeamMembers_103022300025>(jsonData);
        }

        public void PrintData()
        {
            Console.WriteLine("Team Members:");
            foreach (var member in members)
            {
                Console.WriteLine($"{member.nim} - {member.firstName} {member.lastName} ({member.age} y/o, {member.gender})");
            }
        }
    }

    public class TeamMember
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }
}
