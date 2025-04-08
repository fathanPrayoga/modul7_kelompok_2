
class Program
{
    static void Main(string[] args)
    {
        var data = DataMahasiswa_103022300025.ReadJSON(@"jurnal7_1_103022300025.json");
        data.PrintData();
    }
}
