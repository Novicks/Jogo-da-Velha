using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    internal class JogoDaVelhaTabuleiro
    {
        public static void Main(string[] args) {

            // Inicializando variáveis ----------------------------------------------
            string[,] tabuleiro = new string[3, 3];
            string turnos = "X";
            int jogadas = 0;
            int index = 1;
            //I = contador, GetLenght obtem o comrpimento especifico de uma dimensao do arrey, nesse caso 3x3.
            //I++, adicionar 1 ao contador, nesse caso ele adicionara até 9.
            //I = linhas, J = Colunos.

            // Inicio ---------------------------------------------------------------
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("      SEJA BEM VINDO AO JOGO DA VELHA       ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            // Funcionamento da matriz ----------------------------------------------
            for (int i = 0; i < tabuleiro.GetLength(0); i++) {
                for (int j = 0; j < tabuleiro.GetLength(1); j++) {
                    tabuleiro[i, j] = index.ToString();
                    index++;
                }
            }

            //Leitura da matriz -----------------------------------------------------
            //$ permite por valores dentro das varieaveis.
            for (int i = 0; i < tabuleiro.GetLength(0); i++) {
                for (int j = 0; j < tabuleiro.GetLength(1); j++) {
                    Console.Write($" |{tabuleiro[i, j]}| ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write($"Você quer jogar [{turnos}] em qual posição? ");
            string jogar = Console.ReadLine();

            Console.Clear();

            //Loop -------------------------------------------------------------------

            //Verifica se o valor tem na matriz:
            while(jogadas < 9) {

                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("      SEJA BEM VINDO AO JOGO DA VELHA       ");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();

                // Faz a jogada subistituindo o valor
                for (int i = 0; i < tabuleiro.GetLength(0); i++) {
                    for (int j = 0; j < tabuleiro.GetLength(1); j++) {
                        if (tabuleiro[i, j] == jogar) {
                            tabuleiro[i, j] = turnos;
                        }
                    }
                }
                
                // Refaz o tabuleiro
                for (int i = 0; i < tabuleiro.GetLength(0);i++) {
                    for (int j = 0; j <tabuleiro.GetLength(1); j++) {
                        Console.Write($" |{tabuleiro[i, j]}| ");
                    }
                    Console.WriteLine();

                }


                // Alterna entre X e O;
                if (turnos == "X") {
                    turnos = "O";
                } else {
                    turnos = "X";
                }
                Console.WriteLine();
                Console.Write($"Você quer jogar [{turnos}] em qual posição? ");
                jogar = Console.ReadLine();
                jogadas ++;

                Console.Clear();
            }

            Console.ReadLine();
        }
    }
}
