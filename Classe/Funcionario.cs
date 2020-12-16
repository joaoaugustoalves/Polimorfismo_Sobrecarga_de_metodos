using System;

namespace POOL_Polimorfismo.Classe
{
   public class Funcionario
    {
        //sintaxe completa
        //atalho:propfull
    //    private int myVar;
    //    public int MyProperty
    //    {
    //        get { return myVar; }
    //        set { myVar = value; }
    //    }
        
    //     //alternstiva com menos sintax 
    //         public string Name {get; set;}

    //         public string nome;

        //atividade dia 11-12
        public string[] lista = {"paulo" , "tsuka" , "thiago"};

        public void Mostrar(){
            foreach (var item in lista){
                Console.WriteLine(item);
            }
        }

        public void Mostrar(int indice){
            Console.WriteLine("Busca por indice : " + lista[indice]);
        }

        public void Mostrar(string busca){
            foreach (var item in lista){
                if(item == busca){
                Console.WriteLine("resultado da busca: " + item);
                }
            }
        }
    }
}