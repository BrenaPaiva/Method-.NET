using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class ExemploExcecao
    {
        public void M1()
        {
            try{
                M4();
            }catch (Exception e) {
                Console.WriteLine("Eceção tratada" + e.StackTrace); //Message
            }
            M2();
        }
        public void M2()
        {
            M3();
        }
        public void M3()
        {
            M4();
        }
        public void M4()
        {
            throw new Exception("Ocorreu uma exceção");
        }
    }
}