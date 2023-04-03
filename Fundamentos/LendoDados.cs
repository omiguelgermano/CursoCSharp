using System;
using System.Globalization; // Utiliza o padrão universal para separação de casas decimais

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar() {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine()); // Converte a string para inteiro por meio do atributo Parse

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);// Utiliza o padrão universal para separação de casas decimais

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
