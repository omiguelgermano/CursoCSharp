using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Pessoa {
        public string Nome;//Atributo
        public int Idade;//Atributo

        public string Apresentar() {//Método/Comportamento
            return string.Format(
                "Olá! Me chamado {0} e tenho {1} anos.", Nome, Idade);
        }

        public void ApresentarNoConsole() { 
            Console.WriteLine(Apresentar());
        }

        public void Zerar() { // Método para zerar os dados de um objeto
            Nome = "";
            Idade = 0;
        }
    }
}
