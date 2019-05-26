using System;
using System.Text.RegularExpressions;

namespace MascaraTelefone
{
    class Program
    {
        static void Main(string[] args)
        {
            var fone = @"(073)3256-2418";

            var rgx = new Regex(@"[^\d]");
            var resultado = rgx.Replace(fone, "");

            var rgx2 = new Regex(@"^[0]");
            var resultado2 = rgx2.Replace(resultado, "");

            var rgx3 = new Regex(@"^(\d{2})(\d)");
            var resultado3 = rgx3.Replace(resultado2, "$1 $2");

            var rgx4 = new Regex(@"(\d)(\d{4})$");
            var resultado4 = rgx4.Replace(resultado3, "$1-$2");

            Console.WriteLine(resultado4);

            Console.ReadKey();
        }
    }
}
