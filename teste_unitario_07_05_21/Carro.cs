using System;
using System.Collections.Generic;
using System.Text;

namespace teste_unitario_07_05_21
{
    public class Carro {
        // atributos - metodos de acesso e modificadores (getters e setters)
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Potencia { get; set; }
        public int Velocidade { get; set; }
        // metodo construtor
        public Carro(int potencia, int velocidade)
        {
            this.Potencia = potencia;
            this.Velocidade = velocidade;
        }
        public Carro(string marca, string modelo, int ano)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
        }

        public void Acelerar() {
            Velocidade = Velocidade + 10;
        }
        private void Parar() {
            Velocidade = 0;
        }

        public void Reduzir() {
            while (Velocidade>10)
            {
                Velocidade = Velocidade - 7;
            }

        }

        public void Frear()
        {
            Reduzir();
            Parar();
        }

    }
}
