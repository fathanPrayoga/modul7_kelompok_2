using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class DataMahasiswa_103022300025
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public Address Address { get; set; }          
    public List<Course> Courses { get; set; }  
    
    public static DataMahasiswa_103022300025 ReadJSON(string filePath)
    {
        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<DataMahasiswa_103022300025>(json);
    }

    public void PrintData()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Gender: {Gender}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Address: {Address.StreetAddress}, {Address.City}, {Address.State}");
        Console.WriteLine("Courses:");
        foreach (var course in Courses)
        {
            Console.WriteLine($"  - {course.Code}: {course.Name}");
        }
    }
}

public class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
}

public class Course
{
    public string Code { get; set; }
    public string Name { get; set; }
}
