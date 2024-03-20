// See https://aka.ms/new-console-template for more information
// Read each line of a file called person.inp and then relace characters 5-16 with a string then save the file as person2.inp

using System;
using System.IO;
using System.Text;

string inputFilePath = "person.inp";
string outputFilePath = "person2.inp";

try
{
    using (var reader = new StreamReader(inputFilePath))
    using (var writer = new StreamWriter(outputFilePath, false, Encoding.UTF8))
    {
       
        string [] numbers = {"07436125725", "07436125729", "07423702379", "07791158636", "07807437759"};
        string[] emails =
        {
            "cmtest1@harbour.scot ",
            "cmtest2@harbour.scot ",
            "cmtest3@harbour.scot ",
            "360Test1@harbour.scot",
            "360Test2@harbour.scot",
            "360Test3@harbour.scot"
        };
        
        while (!reader.EndOfStream)
        {
            foreach (var number in numbers)
            {
                var line = reader.ReadLine();
                if (line == null) continue;

                // Ensure line is exactly 500 characters long, pad if necessary
            

                // Replace characters at positions 82 to 86 with "hello"
                // Note: Arrays and strings are 0-indexed in C#, so positions start from 0
                line = line.Remove(204, 11).Insert(204, number);

                writer.WriteLine(line);
            }
        }
    }

    Console.WriteLine("File processed successfully.");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

