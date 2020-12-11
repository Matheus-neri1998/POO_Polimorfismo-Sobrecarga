using System;

namespace POO_Polimorfismo_Sobrecarga.Classes
{
    public class Funcionario
    {
        // Sintaxe completa
        // Atalho : propfull
        private int myVar;
        public int MyProperty
        {
            get {return myVar;}
            set {myVar = value;}
        }

        // Alternativa com sinatxe reduzida:
        // Atalho prop

        public string Name {get; set;}
        
        // Atividade à partir daqui
        public string[] lista = {"Matheus", "Paulo", "Thiago", "Carlos" };  
        public void Mostrar(){
            foreach (var item in lista)
            {
                Console.WriteLine(item); // lista os nomes
            }
        } // fim de mostrar - lista

        public void Mostrar(int indice)
        {
            Console.WriteLine("Busca por índice : "+ lista [indice] );
        } // fim de mostrar - índice 

        public void Mostrar(string busca)
        {
            foreach (var item in lista)
            {
                if (item == busca){
                    Console.WriteLine("Resultado da busca : "+ item );
                }
            }
        } // fim de mostrar - busca

    } // fim da classe Funcionario
}