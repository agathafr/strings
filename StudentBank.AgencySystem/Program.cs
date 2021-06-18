using System;
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
            string url = "pagina?argumentos";

            Console.WriteLine(url);
            string argumentos = url.Substring(7);
            Console.WriteLine(argumentos);

            Console.ReadLine();
        }

        static void diferencaDatas()
        {
            DateTime dataFimPagamento = new DateTime(2021, 6, 30);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(40); //dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            //Console.WriteLine(mensagem);

            Console.ReadLine();
        }

    }
}
