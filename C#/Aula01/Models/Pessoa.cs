using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int litros { get; set; }

        public void Pessoinha(){
            Console.Write($"Faça me o favor {Nome} \n" + $"não cague {litros} litros de bosta no armazem denovo");
        }
    }
}