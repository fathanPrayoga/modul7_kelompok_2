using System;
using System.IO;
using System.Text.Json;

namespace tpmodul7_kelompok_02
{
    public class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }

    public class GlossDef
    {
        public string para { get; set; }
        public string[] GlossSeeAlso { get; set; }
    }

    public class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }

    public class GlossDiv
    {
        public string title { get; set; }
        public GlossList GlossList { get; set; }
    }

    public class Glossary
    {
        public string title { get; set; }
        public GlossDiv GlossDiv { get; set; }
    }

    public class RootObject
    {
        public Glossary glossary { get; set; }
    }

    class DataGlossary
    {
        public static void ReadJSON()
        {
            string filePath = "jurnal7_3_103022300159.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);
                RootObject data = JsonSerializer.Deserialize<RootObject>(jsonString);

                var entry = data.glossary.GlossDiv.GlossList.GlossEntry;

                Console.WriteLine("=== GLOSS ENTRY ===");
                Console.WriteLine($"ID         : {entry.ID}");
                Console.WriteLine($"SortAs     : {entry.SortAs}");
                Console.WriteLine($"Term       : {entry.GlossTerm}");
                Console.WriteLine($"Acronym    : {entry.Acronym}");
                Console.WriteLine($"Abbrev     : {entry.Abbrev}");
                Console.WriteLine($"Definition : {entry.GlossDef.para}");
                Console.WriteLine("See Also   : " + string.Join(", ", entry.GlossDef.GlossSeeAlso));
                Console.WriteLine($"See        : {entry.GlossSee}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat membaca file JSON: " + ex.Message);
            }
        }
    }
}
