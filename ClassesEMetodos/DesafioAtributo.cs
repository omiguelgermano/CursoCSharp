using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class DesafioAtributo {
        int a = 10; 
        /*
         *  ^ Atributo de Instancia, e sabemos 
         *  que atributo de instancia não pode
         *  ser acessado por um metodo de classe.          *
         */

        public static void Executar() {
        //    Console.WriteLine(a); // Não rola, pq o metodo de classe
                                  // não acessa atributos de instancia.

            var oi = new DesafioAtributo(); // Preciso instanciar a classe 'DesafioAtributo'
                                            // para ter acesso ao Atribudo de Instancia
            Console.WriteLine(oi.a); // <- Atributo de Instancia acessivel

            //Outra possibilidade!
            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}
