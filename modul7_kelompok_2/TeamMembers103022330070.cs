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
    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public class TeamMembersData
    {
        public List<Member> members { get; set; }
    }
    public class TeamMembers103022330070
    {
        public void ReadJSON()
        {
            string filename = "jurnal7_2_103022330070.json";
            string jsonString = File.ReadAllText(filename);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            TeamMembersData teamData = JsonSerializer.Deserialize<TeamMembersData>(jsonString, options);

            Console.WriteLine("list team member:");
            if (teamData?.members != null)
            {
                foreach(var member in teamData.members)
                {
                    Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} {member.age} {member.gender}");
                }
            }
        }
    }
}
