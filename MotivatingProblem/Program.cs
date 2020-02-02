using System;
using System.IO;
using System.Collections.Generic;
using MotivatingProblem.Entities;

/// <summary>
/// a program to read a "hardcode" file containing people's names (one name per line), storing them in a list. 
/// Then, sort the data in that list and display it neatly on the screen.
/// </summary>

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
                    List<Employee> list = new List<Employee>();
                    while (!streamReader.EndOfStream)
                    {
                        list.Add(new Employee(streamReader.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee employee in list)
                    {
                        Console.WriteLine(employee);
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
