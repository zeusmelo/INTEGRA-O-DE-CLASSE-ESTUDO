﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEC_GUANABARA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lutador[] l = new Lutador[6];
            l[0] = new Lutador("Pretty Boy", "França", 31, 1.75, 68.9, 11,3, 1);
            l[1] = new Lutador("Putscript", "Brasil", 29,1.68, 57.8, 15,2,3);

            l[2] = new Lutador ("Snapshadow", "EUA", 35, 1.65, 80.9,12,2,1);
            l[3] = new Lutador("Dead Code", "Australia", 28, 1.93, 81.6, 13, 0, 2);

            l[4] = new Lutador("UFOcobol", "Brasil", 37, 1.70, 119.3, 5, 4, 3);
            l[5] = new Lutador("Nerdaart", "EUA", 30, 1.81, 105.7, 12, 2, 4);

            Luta uEC01 = new Luta();
            uEC01.MarcarLuta(l[2], l[3]);
            uEC01.Lutar();
            Console.ReadKey();


        }
    }
}
