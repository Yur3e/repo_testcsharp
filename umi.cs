//APRENDENDO C# 

// importa funcionalidades básicas
using System;

//'namespace" é usado para organizar o código e evitar conflitos de nomes
namespace ExemploClasses

{
    public class Carro
    {
        public string Marca { get; set; }   
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public bool ligado { get; private set; }
        public Carro(string marca, string modelo, int ano)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.ligado = false;
        }

        public void Ligar()
        {
            if (!this.Ligado)
            {
                this.ligado = true;
                Console.WriteLine($"o{this.Modelo} ligou.");
            }
            else
            {
                Console.WriteLine($"O {this.Modelo} já estava ligado.");
            }
        }
        class Programa
        {
            public static void Main(string[] args)
            {
                Carro meuCarro = new Carro("Volkwagen", "Fusca", 1975);
                Carro outroCarro = new Carro("Tesla", "Model S", 2024);
                meuCarro.Descrever(); //Saída:
                meuCarro.Ligar();
                outroCarro.Descrever;
                outroCarro.Ligar;
            }
        }
    }
}