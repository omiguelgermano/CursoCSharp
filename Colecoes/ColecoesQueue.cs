using System;
using System.Collections;
using System.Collections.Generic;

//> Queue<string> Fila - FiFo(first In First Out)
//Por ser uma coleção GENERICA, sera usando o 'using System.Collections.Generic'
namespace CursoCSharp.Colecoes {
    class ColecoesQueue {
        public static void Executar() {
            var fila = new Queue<string>();// Utiliza Collections Generic

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano");

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            Console.WriteLine(fila.Peek()); // Peek() é um method -> Pega o primeiro da fila,
                                            // mas não o exclui da lista
            Console.WriteLine(fila.Count); // Conta o total
            Console.WriteLine(fila.Dequeue()); //Excluir o primeiro da fila, Desenfileira
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            // Valores Dinamicos, estrutura Heterogena,
            // Estrutura que aceita Repetição (linha 29 - Coleções Queue)
            var salada = new Queue(); // Utiliza apenas o Queue do Collection
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
