﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marimaba_en_de_Bas
{
    class Program
    {
        static void Main(string[] args)
        {
            Marimba marimba = new Marimba();
            BassGuitar bassGuitar = new BassGuitar();

            bassGuitar.PlayNote("a");
            marimba.PlayNote("e");
            bassGuitar.PlayNote("g");
            marimba.PlayNote("d#");
            bassGuitar.PlayNote("f");
            marimba.PlayNote("e");
            marimba.PlayNote("d#");
            bassGuitar.PlayNote("e");
            marimba.PlayNote("e");

            Console.WriteLine("MarimbaPlaysNote");
            Console.ReadKey();
        }

    }
}
