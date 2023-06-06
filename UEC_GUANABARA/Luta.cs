using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UEC_GUANABARA
{
    internal class Luta
    {
        //relacionamento TEMUM == agregação.
        private Lutador desafiado; //instancias da outra classe; Tipo Abstrato.
        private Lutador desafiante;
        private int rounds;
        private bool aprovada;

           public Lutador GetDesafiado { get { return desafiado; } }
           public Lutador SetDesafiado { set { desafiado = value; } }

        public Lutador GetDesafiante { get { return desafiante; } }
        public Lutador SetDesafiante { set { desafiante = value; } }

        public int GetRounds { get { return rounds; } }
        public int SetRounds { set { rounds = value; } }

        public bool GetAprovada { get { return aprovada; } }
        public bool SetAprovada { set { aprovada = value; } }

 
        //Métodos
        public void MarcarLuta(Lutador l1, Lutador l2)
        {
            if (l1.GetCategoria == l2.GetCategoria && l1 != l2)
            {
                Console.WriteLine("Lets Get ready to rumble");
                SetAprovada = true;
                this.desafiado = l1;
                this.desafiante = l2;
            }
            else
            {
                Console.WriteLine("Caracteristicas incompativeis para a realização do evento");
                this.aprovada = false;
                this.desafiado = null;
                this.desafiante = null;
            }
        }
        public void Apresentacao()
        {
            Console.WriteLine("APRESENTANDO LUTADOR DESAFIADO");
            desafiado.Apresentar();
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("APRESENTANDO LUTADOR DESAFIANTE");
            desafiante.Apresentar();
            Thread.Sleep(3000);
            
        }
        public void Lutar()
        {
            this.rounds = 1;
            Console.Clear();
            Random rand = new Random();   
      
            int jogadaDesafiante;
            int jogadaDesafiado;
            if (GetAprovada == true)
            {
                Console.Clear();
                  Apresentacao();

                // AÇAO

                while (rounds <= 5 && desafiado.GetLife >0 || desafiante.GetLife > 0)
                {
                    Console.Clear();
                    Console.WriteLine($"ROUND Nº{rounds}");
                    Thread.Sleep(1000);


                    if (desafiado.GetLife > 0)
                    {

                        Console.WriteLine($"{desafiante.GetNome} ATACA!");
                        jogadaDesafiante = rand.Next(3);
                        switch (jogadaDesafiante)
                        {
                            case 0:
                                Console.Clear();
                                Console.WriteLine($"ATAQUE SUPER EFETIVO {desafiado.GetNome} perdeu 10 de vida");
                                desafiado.SetLife(10);
                                Thread.Sleep(1000);
                                break;

                            case 1:
                                Console.Clear();
                                Console.WriteLine($"ATAQUE NORMAL {desafiado.GetNome} perdeu 5 de vida");
                                desafiado.SetLife(5);
                                Thread.Sleep(1000);
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine($"ATAQUE DO DESAFIADO PASSOU NO VAZIO");
                                Thread.Sleep(1000);
                                break;
                        }
                    }
                    else
                        break;
                    if (desafiante.GetLife > 0)
                    {
                        Console.WriteLine($"{desafiado.GetNome} ATACA!");
                        jogadaDesafiado = rand.Next(3);
                        switch (jogadaDesafiado)
                        {
                            case 0:
                                Console.Clear();
                                Console.WriteLine($"ATAQUE SUPER EFETIVO {desafiante.GetNome} perdeu 10 de vida");
                                desafiante.SetLife(10);
                                Thread.Sleep(1000);

                                break;

                            case 1:
                                Console.Clear();
                                Console.WriteLine($"ATAQUE NORMAL {desafiante.GetNome} perdeu 5 de vida");
                                desafiante.SetLife(5);
                                Thread.Sleep(1000);
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine($"ATAQUE DO DESAFIANTE PASSOU NO VAZIO");
                                Thread.Sleep(1000);
                                break;
                        }
                    }
                    else
                        break;
                    Console.Clear();
                    rounds++;
                }
                string res = Resultado();
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("A Luta não está apta para acontecer");
            }
        }
        public string Resultado()
        {
            string res;
            if (desafiante.GetLife > 0 && desafiado.GetLife >0)
            {
                res = "LUTA EMPATADA";
                desafiante.EmpatarLuta();
                desafiado.EmpatarLuta();
                return res;
            } else if (desafiante.GetLife > 0)
            {
                res = $"DESAFIANTE {desafiante.GetNome} VENCEU A LUTA ";
                desafiante.GanharLuta();
                desafiado.PerderLuta();
                return res;
            } else
            {
                res = $"DESAFIADO {desafiado.GetNome} VENCEU A LUTA ";
                desafiado.GanharLuta();
                desafiante.PerderLuta();
                return res;
            }
        }
    }
}
