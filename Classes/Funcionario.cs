using System;

namespace POO_Polimorfismo_Sobrecarga.Classes
{
    public class Funcionario
    {
        // sintaxe completa
        // atalho : propfull
        private int myVar;
        public int MyProperty
        {
            get {return myVar;}
            set {myVar = value;}
        }

        // alternativa com sinatxe reduzida:
        // atalho prop

        public string Name {get; set;}
        
        public string[] lista = {"Paulo", "Tsuka", "Thiago", "Fernanda" };
        public void Mostrar(){
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        } // fim de mostrar - lista

        public void Mostrar(int indice)
        {
            Console.WriteLine( lista [indice] );
        } // fim de mostrar - indice 

        public void Mostrar(string busca)
        {
            foreach (var item in lista)
            {
                if (item == busca)
                {}
            }
        } // fim de mostrar busca
    } // fim da classe funcionario
}