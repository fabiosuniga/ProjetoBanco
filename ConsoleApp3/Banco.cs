using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Banco
    {

        private string _nomecliente;
        private int _numeroconta;
        public double Saldo { get; private set; }


        public Banco(string nomecliente, int numeroconta)
        {
            SetNomeCliente(nomecliente);
            SetNumeroConta(numeroconta);

        }

        public Banco(string nomecliente, int numeroconta, double saldo) : this(nomecliente, numeroconta)
        {
            Saldo = saldo;
        }

        public string GetNomeCliente()

        {
            return _nomecliente;
        }

        public void SetNomeCliente(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nomecliente = nome;
            }
        }

        public int GetNumeroConta()

        {
            return _numeroconta;
        }
        public void SetNumeroConta(int numero)
        {
            if (numero != null || numero.ToString().Length == 4)
            {
                _numeroconta = numero;
            }
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.00;
        }

        public override string ToString()
        {
            return "O seu nome é: "
                + _nomecliente
                + ", o número da sua conta é: "
                + _numeroconta
                + ", o seu saldo atual é: R$"
                + Saldo.ToString("F2");

            ;
        }











    }
}
