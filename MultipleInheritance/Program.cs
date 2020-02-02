using MultipleInheritance.Devices;
using System;


namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer() { SerialNumber = 1080 };
            printer.ProcessDoc("My letter");
            printer.Print("My letter");

            Scanner scanner = new Scanner() { SerialNumber = 2020 };
            scanner.ProcessDoc("My email");
            Console.WriteLine(scanner.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
