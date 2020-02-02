using System;
using System.IO;
using System.Collections.Generic;

namespace MotivatingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\sa\Documents\New folder\file4.txt";
            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!streamReader.EndOfStream)
                    {
                        list.Add(streamReader.ReadLine());
                    }
                    list.Sort();
                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
