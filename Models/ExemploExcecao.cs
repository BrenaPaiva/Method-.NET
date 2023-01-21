using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class ExemploExcecao
    {
        public void Method1()
        {
            try{
                Method4();
            }catch (Exception e) {
                Console.WriteLine("Exceção tratada. " + e.Message); //Se não tiver ninguém, ele irá exibir o StackTrace(Minha mensagem gigante)
            }
            
        }
        public void Method2()
        {
            Method3();
        }
        public void Method3()
        {
            Method4();
        }
        public void Method4()
        {
            throw new Exception("Ocorreu uma exceção");
        }
    }
}