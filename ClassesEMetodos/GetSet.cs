using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class Moto {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada) {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() {
        }

        public string GetMarca() {
            return Marca;
        }
        public void SetMarca(string marca) {
            Marca = marca;
        }
        public string GetModelo() {
            return Modelo;
        }
        public void SetModelo(string modelo) {
            Modelo = modelo;
        }
        public uint GetCilindrada() {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada) {
            // ENTENDENDO QUE CILINDRADA DE UMA MOTO SÓ PODE CONTER VALOR POSITIVO.
            //FAREMOS UMA REGRA NO SET

            // O metodo Set, permite criar regras para settar o valor conforme Regras do campo.

            // porém se o valor for settado direto no Construtor,
            // o sistema deixara passar, pois não temos esta regra no construtor.
            // faremos esta regfra direto no construtor, volta à linha 18
            
            // 1 Opção
            //if (cilindrada > 0) {
            //    Cilindrada = cilindrada;
            //}

            // 2 - opção POSSIBILIDADE
            //Cilindrada = Math.Abs(cilindrada); // Esta função converte todo valor negativo para
                                                 //positivo.
            
            // 3 - Opção
            Cilindrada = cilindrada; // Define o parametro 'U'INT uint que determina que o valor
                                     // só sera escrito de forma pisitiva
        }
    }
    internal class GetSet {

        public static void Executar() {
            var moto1 = new Moto("Yamaha", "Crosser", 150);
            var moto2 = new Moto("Yamaha", "Lander", 250);

            Console.WriteLine(moto1.GetMarca() + " " + moto1.GetModelo() + " " + moto1.GetCilindrada());
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());

            var moto3 = new Moto();
            moto3.SetMarca("Honda");
            moto3.SetModelo("CG Titan");
            moto3.SetCilindrada(150);
            Console.WriteLine(moto3.GetMarca() + " " + moto3.GetModelo() + " " + moto3.GetCilindrada());

        }
    }
}
