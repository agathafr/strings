﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentBank.Models;
using StudentBank.Models.Funcionarios;
using Humanizer;

namespace StudentBank.AgencySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            Console.WriteLine(url);
            string argumentos = url.Substring(7);
            Console.WriteLine(argumentos);

            Console.ReadLine();
        }
    }
}
