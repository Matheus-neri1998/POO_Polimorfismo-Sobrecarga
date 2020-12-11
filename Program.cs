using System;
using POO_Polimorfismo_Sobrecarga.Classes;

namespace POO_Polimorfismo_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
           Funcionario funcionario = new Funcionario();
           funcionario.Mostrar(); // lista os nomes
           funcionario.Mostrar("Matheus");
           funcionario.Mostrar(2); // mostra a busca e o resultado por índice

           Console.Beep(900, 5000); // reproduz um barulho
        }
    }
}
