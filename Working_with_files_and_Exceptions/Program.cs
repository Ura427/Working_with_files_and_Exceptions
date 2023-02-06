using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_files_and_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = default;
            string nameOfFile = default;
            string fileLocation = default; //Should have possibility to be changed permanently
            string data;


            //StreamWriter writer = new StreamWriter(@"D:\test.txt");
            StreamReader reader = new StreamReader(@"D:\test.txt");

            data = File.ReadAllText(@"D:\test.txt");
            //data = reader.ReadLine();
            //while(data != null)
            //{
            //    data += reader.ReadLine();
            //}

            Console.WriteLine(data);
            Console.ReadLine();

            //while (input != "quit")
            //{


            //    //Available options working with file

            //    //1.Change Text

            //StreamWriter writer = new StreamWriter(@"D:\test.txt");

            //Console.WriteLine("Input text: ");
            //input = Console.ReadLine();
            //writer.WriteLine(input);

            //writer.Close();

            //    //2.Add text to existing
            //StreamWriter writer = new StreamWriter(@"D:\test.txt", true);

            //writer.WriteLine("Does it work?");
            //writer.Write("And this?2");
            //writer.Close();
            //    //3.Delete text
            //StreamWriter writer = new StreamWriter(@"D:\test.txt");
            //writer.WriteLine();
            //writer.Close();
            //    //4.Search for specific word
            //    //5.Replace words
            //    //6.Insert words
            //    //7.Display text
            //try
            //{
            //    StreamReader reader = new StreamReader(@"D:\test.txt");
            //    data = reader.ReadLine();

            //    while (data != null)
            //    {
            //        Console.WriteLine(data);
            //        data = reader.ReadLine();
            //    }

            //    Console.ReadLine();

            //}
            //catch
            //{
            //    Console.WriteLine("Something bad happened");
            //}
            //} string input = default;
            string nameOfFile = default;
            string fileLocation = default; //Should have possibility to be changed permanently
            string data;


            //StreamWriter writer = new StreamWriter(@"D:\test.txt");
            StreamReader reader = new StreamReader(@"D:\test.txt");

            data = File.ReadAllText(@"D:\test.txt");
            //data = reader.ReadLine();
            //while(data != null)
            //{
            //    data += reader.ReadLine();
            //}

            Console.WriteLine(data);
            Console.ReadLine();

            //while (input != "quit")
            //{


            //    //Available options working with file

            //    //1.Change Text

            //StreamWriter writer = new StreamWriter(@"D:\test.txt");

            //Console.WriteLine("Input text: ");
            //input = Console.ReadLine();
            //writer.WriteLine(input);

            //writer.Close();

            //    //2.Add text to existing
            //StreamWriter writer = new StreamWriter(@"D:\test.txt", true);

            //writer.WriteLine("Does it work?");
            //writer.Write("And this?2");
            //writer.Close();
            //    //3.Delete text
            //StreamWriter writer = new StreamWriter(@"D:\test.txt");
            //writer.WriteLine();
            //writer.Close();
            //    //4.Search for specific word
            //    //5.Replace words
            //    //6.Insert words
            //    //7.Display text
            //try
            //{
            //    StreamReader reader = new StreamReader(@"D:\test.txt");
            //    data = reader.ReadLine();

            //    while (data != null)
            //    {
            //        Console.WriteLine(data);
            //        data = reader.ReadLine();
            //    }

            //    Console.ReadLine();

            //}
            //catch
            //{
            //    Console.WriteLine("Something bad happened");
            //}
            //}
        }
    }
}
