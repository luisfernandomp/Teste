using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProjetoBanco
{
    public class Conta
    {
        private int numero_conta;
        private int senha;
        private double saldo_bancario;
        private string titular;

        public Conta(int num_conta, double saldo, string titular_conta)
        {
            this.numero_conta = num_conta;
            this.senha = 12345;
            this.saldo_bancario = saldo;
            this.titular = titular_conta;
        }
        public int numeroConta
        {
            get { return this.numero_conta; }
        }
        public int Senha
        {
            get { return this.senha; }
            set { this.senha = value; }
        }
        public double SaldoBancario
        {
            get { return this.saldo_bancario; }
            set { this.saldo_bancario = value; }
        }
        public string Titular
        {
            get { return this.titular; }
            set { this.titular = value; }
        }

        /// <summary>
        /// Método que realiza o saque na conta 
        /// </summary>
        /// <returns>Retorna o valor do saque informado</returns>
        public double Saque()
        {
            double saque_final, saque_informado; 
            Console.Clear();
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("- OPERAÇÃO DE SAQUE SELECIONADA -");
            Console.WriteLine("---------------------------------\n\n");
            Console.WriteLine("Informe o valor a ser saquado da sua conta: ");
            saque_informado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Saque Realizado com Sucesso!");
            saque_final = SaldoBancario - saque_informado;
            SaldoBancario = saque_final; 
            Thread.Sleep(2000);
            return saque_final;
        }
	
        /// <summary>
        /// Método para depositar um valor na conta 
        /// </summary>
        /// <returns>O saldo atual da conta depois da operação</returns>
        public double Deposito()
        {
            double saldo_final, deposito_informado;
            Console.Clear();
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("- OPERAÇÃO DE DEPÓSITO SELECIONADA -");
            Console.WriteLine("------------------------------------\n\n");
            Console.Write("Informe o valor a ser depositado na sua conta: ");
            deposito_informado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDepósito Realizado com Sucesso!");
            saldo_final = SaldoBancario + deposito_informado;
            SaldoBancario = saldo_final;
            Thread.Sleep(2000);
            return saldo_final;
        }

        /// <summary>
        /// Método sem retorno que serve para visualizar o saldo da conta
        /// </summary>
        public void VisualizarSaldo()
        {
            Console.Clear();
            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("- OPERAÇÃO DE VISUALIZAR SALDO SELECIONADA -");
            Console.WriteLine("--------------------------------------------\n\n");
            Console.WriteLine("Saldo da conta: " + SaldoBancario);
			Thread.Sleep(2000);
        }

        /// <summary>
        /// Método sem retorno que realiza um investimento na conta
        /// </summary>
        public void Investimento()
        {
            float investimento = 0, rendimento = 0;
            int tempo_mes = 0, op = 0;
            bool teste = false;
            const float poupanca = 0.015f;
            const float tesouro = 0.05f; 
            // Poupança rende 1,5% ao ano, tesouro direto rende 5% ao ano 
            while(teste == false){
                Console.Clear();
                Console.WriteLine("\n-------------------------------------------");
                Console.WriteLine("- OPERAÇÃO DE INVESTIR SELECIONADA          -");
                Console.WriteLine("-------------------------------------------\n\n");
                Console.Write("Quanto você dejesa investir: ");
                investimento = float.Parse(Console.ReadLine());
                Console.Write("Quanto tempo, em meses, terá seu investimento: ");
                tempo_mes = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Selecione o tipo de investimento:");
                Console.WriteLine("1 - Poupança");
                Console.WriteLine("2 - Tesouro direto");
                op = Convert.ToInt16(Console.ReadLine());
                if (op == 1)
                {
                    SaldoBancario = SaldoBancario - investimento;
                    Console.WriteLine("-- Saldo final: " + SaldoBancario);
                    rendimento = investimento*((tempo_mes * poupanca)/12);
                    Console.WriteLine("-- Rendimentos: " + rendimento);
                    SaldoBancario = SaldoBancario + rendimento;
                    Console.WriteLine("-- Saldo depois do rendimento: " + SaldoBancario);
                    Thread.Sleep(4000);
                    teste = true;
                }
                else
                {
                    if(op == 2)
                    {
                        SaldoBancario = SaldoBancario - investimento;
                        Console.WriteLine("-- Saldo final: " + SaldoBancario);
                        rendimento = investimento * ((tempo_mes * tesouro) / 12);
                        Console.WriteLine("-- Rendimentos: " + rendimento);
                        SaldoBancario = SaldoBancario + rendimento;
                        Console.WriteLine("-- Saldo depois do rendimento: " + SaldoBancario);
                        Thread.Sleep(4000);
                        teste = true;
                    }
                    else
                    {
                        Console.WriteLine("O número digitado é inválido!");
                    }
                }
            }
        }
    }
}