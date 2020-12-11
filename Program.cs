using System;
using Sobrecargas.Classes;

namespace Sobrecargas
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios fun = new Funcionarios();

            fun.Funcao();
            fun.Funcao("francisco");
            fun.Funcao(0);


            Console.Beep();
            
        }
    }
}
