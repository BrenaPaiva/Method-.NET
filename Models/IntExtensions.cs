using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    //static, porque ele não vai ser estanciado
    public static class IntExtensions
    {
        public static bool EhPar(this int numero) //this = extendendo o valor da minha variavel
        {
            return numero % 2 == 0;
        }
    }
}