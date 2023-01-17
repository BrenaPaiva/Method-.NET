using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _name;
        private int _idade;

        public string Name { 
            get =>_name.ToUpper();
            
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _name = value;
            }
             }
        public int Age {
            get => _idade;

            set 
        {
            if( value < 0)
            {
                    throw new ArgumentException("Idade Inválida");
                }
                _idade = value;
        } }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Name} {Sobrenome}".ToUpper();
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto} e Idade: {Age}");
        }
    }
}