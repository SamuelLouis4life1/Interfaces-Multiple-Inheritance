﻿using System;


namespace MultipleInheritance.Devices
{
    class ComboDevice : Device, IScanner, IPrinter 
    {
        public void Print (string document)
        {
            Console.WriteLine("Combo device print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Combo device processing " + document);
        }

        public string Scan()
        {
            return "Combo device scan result";
        }
    }
}
