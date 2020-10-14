using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ParsingCSV
{
    class Program
    {
        static void Main(string[] args)
        {

            ReadCsv();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        public static void ReadCsv()
        {

            string a = AppDomain.CurrentDomain.BaseDirectory;


            string filename = "persons.csv";
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"csv\", filename);
            
            List<Person> persons = new List<Person>();

            persons = File.ReadAllLines(path)
                        .Skip(1)
                        .Select(v => Person.FromCsv(v))
                        .ToList();

            //Person a = new Person(1, "John", "Doe", "1234567890", "johndoe@jdoe.com");
            //Person b = new Person(2, "Jane", "Doe", "9876543210", "janedow@jdoe.com");

            //persons.Add(a);
            //persons.Add(b);

            Console.ReadLine();
        }
    }
}
