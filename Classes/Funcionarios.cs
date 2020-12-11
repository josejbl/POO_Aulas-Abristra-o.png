using System;

namespace Sobrecargas.Classes
{
    public class Funcionarios
    {
        public string[] lista = {"Jose","Francisco","Aparecida","Carlos"};
        
        public void Funcao(){
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item);
                Console.ResetColor();
            }

        }
        public void Funcao(int indice){
             Console.ForegroundColor = ConsoleColor.Green;
              Console.WriteLine(lista[indice]);
                Console.ResetColor();
        }
        public void Funcao(string busca){
             foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Red;
               
               if(item == busca){
                     Console.WriteLine("Resultado da busca:"+ item);
               }
                Console.ResetColor();
            }
        }
    }
}