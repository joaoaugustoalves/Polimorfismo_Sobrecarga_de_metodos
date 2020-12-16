using System;
using POOL_Polimorfismo.Classe;

namespace POOL_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
             Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar("paulo");
            fun.Mostrar(2);

        }
    }
}
