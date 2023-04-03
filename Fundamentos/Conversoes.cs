using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {

            int inteiro = 10;
            double quebrado = inteiro; // conversão implicita, QUANDO NÃO HA A POSSIBILIDADE DE PERDER INFORMAÇÕES
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;//CONVERSÃO EXPLICITA | forçando a conversão, sabendo que pode perder dados, visto que o valor é double e a conversão é para inteiro.
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);// Convertendo String para inteiro. Porém pode ocorrer erro se o usuário digital letra
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);// outra forma de converter String em inteiro
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            //----------------------------------------------------------

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);// caso o usuário não digite um número, o TryParse, atribui o valor padrão para número inteiros, que é o 0 [ZERO].
            Console.WriteLine("Resultado 1: {0}", numero1);
            /*
             * O CÓDIGO DE BAIXO É O MESMO CÓDIGO DE CIMA, COM A REDUÇÃO DE DUAS LINHAS
             * E JOGANDO A ENTRADA DE DADOS PARA DENTRO DO 'TryParse'.
             */
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);

            //----------------------------------------------------------
        }
    }
}
