using System;
using System.IO;

namespace SampleConApp
{
    class FileExample
    {
        static string filename = @"..\..\MyData.csv";
        static void Main(string[] args)
        {
            //writingExample();

            //readingExample();

            //readNamesFromCSVFile();

            //writeToCSVFile();
        }

        private static void writeToCSVFile()
        {
            StreamWriter writer = new StreamWriter(filename,true);//true makes the writer to append the existing file.
            writer.WriteLine("10001,Phaniraj,Bangalore");
            writer.Flush();
            writer.Close();
        }

        private static void readNamesFromCSVFile()
        {
            string[] lines = File.ReadAllLines(filename);
            foreach(var line in lines)
            {
                var words = line.Split(',');
                Console.WriteLine(words[1]);
            }
        }

        private static void readingExample()
        {
            StreamReader reader = new StreamReader("MyFile.txt");
            string data = reader.ReadToEnd();
            Console.WriteLine(data);
        }

        private static void writingExample()
        {
            StreamWriter writer = new StreamWriter("MyFile.txt");//Create the text files...
            writer.WriteLine("My Name is Phaniraj");
            writer.Flush();//Cleaning the buffer. 
            writer.Close();//Closes the stream.
        }
    }
}
