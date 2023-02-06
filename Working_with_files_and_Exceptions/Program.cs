using System;
using System.IO;


namespace Working_with_files_and_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string fileLocation = @"D:\test.txt";
            string data;
            string option;
            bool append = true;
            StreamWriter writer;

            while (true)
            {
                //Available options of working with file
                Console.WriteLine(new string('*', 30));
                Console.WriteLine("Choose available option");
                Console.WriteLine("1 => Change Text");
                Console.WriteLine("2 => Add text to file");
                Console.WriteLine("3 => Delete text");
                Console.WriteLine("4 => Display text");
                Console.WriteLine("5 => Show file location");
                Console.WriteLine("6 => Terminate the program");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        //Change Text
                        append = false;
                        writer = new StreamWriter(fileLocation, append);
                        Console.WriteLine("Input text: ");
                        input = Console.ReadLine();
                        writer.WriteLine(input);
                        append = true;
                        writer.Close();
                        break;
                    case "2":
                        //Add text to existing
                        writer = new StreamWriter(fileLocation, append);
                        Console.WriteLine("Input q to quit");
                        while (true)
                        {
                            input = Console.ReadLine();
                            if (input == "q")
                                break;
                            writer.WriteLine(input);
                        }
                        writer.Close();
                        break;
                    case "3":
                        //Delete text
                        append = false;
                        writer = new StreamWriter(fileLocation, append);
                        writer.WriteLine();
                        append = true;
                        writer.Close();
                        break;
                    case "4":
                        //Display text
                        data = File.ReadAllText(fileLocation);
                        Console.WriteLine(data);
                        break;
                    case "5":
                        Console.WriteLine($"File location: {fileLocation}");
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Maybe this option will be added in the next update, but currently it's unavailable");
                        break;
                }

            }
        }
    }
}
