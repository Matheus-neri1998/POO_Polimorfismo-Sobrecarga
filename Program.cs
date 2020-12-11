using System;
using POO_Polimorfismo_Sobrecarga.Classes;

namespace POO_Polimorfismo_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
           Funcionario fun = new Funcionario();
           fun.Mostrar();
           fun.Mostrar("Matheus");
           fun.Mostrar(2);

           Console.Beep(900, 5000);
        }
    }
}
