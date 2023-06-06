using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEC_GUANABARA
{
    internal class Lutador: ILutador
    {
        private string nome;
        private string nacionalidade;
        private int idade;
        private double altura;
        private double peso;
        private string categoria; //leve, medio, pesado
        private int vitorias;
        private int derrotas;
        private int empates;
        private double life;
      

        public string GetNome
        {
           get { return nome; }
        }
        public string GetNacionalidade
        {
            get { return nacionalidade; }
        }
        public int GetIdade { get { return idade; } } 
        public double GetAltura { get { return altura; } }
        public double GetPeso { get {  return peso; } }
        public string GetCategoria { get { return categoria; } }
        public int GetVitorias { get {  return vitorias; } }
        public int GetDerrotas { get {  return derrotas; } }
        public int GetEmpates { get {  return empates; } }

        public double GetLife { get { return life; } }

        public void SetNome(string i)
        {
            nome = i;
        }
        public void SetNacionalidade(string i)
        {
            nacionalidade = i;
        }
        public void SetIdade (int i)
        {
            idade = i;
        }

        public void SetAltura (double i)
        {
            altura = i;
        }

        public void SetPeso(double i)
        {
            peso = i;
            SetCategoria();
        }

        public void SetLife (double dano)
        {
            this.life = life - dano;
        }
        private void SetCategoria()
        {
            if (peso < 52.5)
                categoria = "invalido - pouquissimo peso";
            else if (peso <= 70.3)
                categoria = "leve";
            else if (peso <= 83.9)
                categoria = "medio";
            else if (peso <= 120.2)
                categoria = "pesado";
            else
                categoria = "invalido - muito peso";
        }

        public void SetVitoria(int i)
        {
            vitorias = i;
        }

        public void SetDerrota(int i)
        {
            derrotas = i;
        }

        public void SetEmpates(int i)
        {
           empates = i;
        }

        public Lutador(string nome, string nacionalidade, int idade, double altura, double peso, int vitorias, int derrotas, int empates)
        {
            this.life = 30;
            this.nome = nome;
            this.nacionalidade = nacionalidade;
            this.idade = idade;
            this.altura =  altura;
            SetPeso(peso);
            this.vitorias = vitorias;
            this.derrotas = derrotas;
            this.empates = empates;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Ladies and Gentleman o lutador: {nome} \n natural do país: {nacionalidade} \n com a alutura: {altura} pesando: {peso} idade: {idade} \n com o cartel de vitorias: {vitorias} derrotas: {derrotas} empates: {empates}");
        }

        public void Status()
        {
            Console.WriteLine(GetNome);
            Console.WriteLine($"É um peso: {GetCategoria}");
            Console.WriteLine($" vitorias: {vitorias} derrotas: {derrotas} empates: {empates}");
        }

        public void GanharLuta()
        {
            SetVitoria(GetVitorias + 1);
        }

        public void PerderLuta()
        {
            SetDerrota(GetDerrotas + 1);
        }

        public void EmpatarLuta()
        {
            SetEmpates(GetEmpates + 1);
        }
    }
}
