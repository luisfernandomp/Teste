using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProjetoBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_conta = 0, senha_conta = 0, op = 0;
            bool verificar = false;
            Conta c1 = new Conta(204, 12345,"Luis Fernando");

            while (verificar == false)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("-    BEM - VINDO AO UNIBAN    -");
                Console.WriteLine("-------------------------------\n\n");
                Console.Write("Insira o número da sua conta: ");
                num_conta = Convert.ToInt32(Console.ReadLine());
                Console.Write("Insira a sua senha: ");
                senha_conta = Convert.ToInt16(Console.ReadLine());
                if ( senha_conta == c1.Senha && num_conta == c1.numeroConta)
                {
                    while(verificar == false) {
						Console.Clear(); 
                        Console.WriteLine("\n________________________________");
                        Console.WriteLine("- BANCO UNIBAN SEMPRE COM VOCÊ -");
                        Console.WriteLine("________________________________");
                        Console.WriteLine("-  1 - REALIZAR SAQUE          -");
                        Console.WriteLine("-  2 - REALIZAR DEPÓSITO       -");
                        Console.WriteLine("-  3 - REALIZAR INVESTIMENTOS  -");
                        Console.WriteLine("-  4 - CONSULTAR SALDO         -");
                        Console.WriteLine("-  0 - SAIR                    -");
                        Console.WriteLine("--------------------------------\n\n");
                        op = Convert.ToInt16(Console.ReadLine());
                        switch (op)
                        {
                            case 1:
                                double rp;
                                rp = c1.Saque();
                                Console.WriteLine("-- Saldo final: " + rp);
                                Thread.Sleep(1000);
                                Console.Clear();
                            break;
                            case 2:
                                double resp;
                                resp = c1.Deposito();
                                Console.WriteLine("-- Saldo final: " + resp);
                                Thread.Sleep(1000);
                                Console.Clear();
                            break;
							case 3:
                                c1.Investimento();
                                break;
                            case 4:
                                c1.VisualizarSaldo(); 
                            break;     
                            case 0:
                                string sair;
                                Console.Clear();
                                Console.Write("Deseja realmente sair? (y - sim/n - não)  ");
                                sair = Console.ReadLine();
                                if (sair == "y" || sair == "Y")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Até logo!");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Saindo!");
                                    verificar = true;
                                }
                            break;
                            default: Console.WriteLine("Número Inválido!"); break;
                        }
                    }
                }
            else
            {
                Console.WriteLine("Senha e/ou Número da conta Incorreto(s)!");
				Thread.Sleep(2000);
				Console.Clear();
            }
            }
			Thread.Sleep(1000);
			Console.Clear();
            System.Environment.Exit(0);
        }
    }
}
