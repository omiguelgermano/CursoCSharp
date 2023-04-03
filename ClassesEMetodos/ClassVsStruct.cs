using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Class vs Struct */

namespace CursoCSharp.ClassesEMetodos {

    // o tipo primitivo 'int' é um struct
    // no Struct, uma atribuição é feita por VALOR e NÃO por referência.
    // (NÃO OCUPAM O MESMO ESPAÇO NA MEMÓRIA)
    public struct SPonto {
        public int X;
        public int Y;
    }

    // o tipo primitivo 'string' é uma class
    // na class, a atribuição é feita por REFERÊNCIA e NÃO por valor.
    // (OCUPAM O MESMO ESPAÇO NA MEMÓRIA)
    public class CPonto2 {
        public int X;
        public int Y;
    }

    internal class ClassVsStruct {
        public static void Executar() {
            Console.WriteLine("Class vs Struct");

            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; // Atribuição por VALOR!!!
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X:{0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 X:{0}", copiaPonto1.X);

            CPonto2 ponto2 = new CPonto2 { X = 2, Y = 4 };
            CPonto2 copiaPonto2 = ponto2; // Atribuição por REFERÊNCIA!!!
            ponto2.X = 4;

            Console.WriteLine("Ponto 2 X:{0}", ponto2.X);
            Console.WriteLine("Copia Ponto 2 X:{0}", copiaPonto2.X);
        }
    }
}
