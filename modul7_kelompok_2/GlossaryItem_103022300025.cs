using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace modul7_kelompok_2
{
    public class GlossaryItem_103022300025
    {
        public Glossary glossary { get; set; }

        public static GlossaryItem_103022300025 ReadJSON(string path)
        {
            string jsonData = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<GlossaryItem_103022300025>(jsonData);
        }

        public void PrintData()
        {
            Console.WriteLine("Glossary Title: " + glossary.title);
            Console.WriteLine("GlossDiv Title: " + glossary.GlossDiv.title);
            Console.WriteLine("GlossEntry ID: " + glossary.GlossDiv.GlossList.GlossEntry.ID);
            Console.WriteLine("GlossTerm: " + glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);
            Console.WriteLine("Acronym: " + glossary.GlossDiv.GlossList.GlossEntry.Acronym);
            Console.WriteLine("Abbrev: " + glossary.GlossDiv.GlossList.GlossEntry.Abbrev);
            Console.WriteLine("Definition: " + glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);
            Console.WriteLine("GlossSeeAlso: " + string.Join(", ", glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso));
            Console.WriteLine("GlossSee: " + glossary.GlossDiv.GlossList.GlossEntry.GlossSee);
        }
    }

    public class Glossary
    {
        public string title { get; set; }
        public GlossDiv GlossDiv { get; set; }
    }

    public class GlossDiv
    {
        public string title { get; set; }
        public GlossList GlossList { get; set; }
    }

    public class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }

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
        public List<string> GlossSeeAlso { get; set; }
    }
}
