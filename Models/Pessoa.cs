using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _name;
        public string Name { 
            get
            {
                return _name.ToUpper();
            }
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _name = value;
            }
             }
        public int Age { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Name} e Idade: {Age}");
        }
    }
}