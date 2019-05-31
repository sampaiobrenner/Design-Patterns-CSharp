﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            // StateDeOrcamento();

            StateDeConta();

        }

        private static void StateDeConta()
        {
            Conta conta = new Conta(500);

            Console.WriteLine(conta.Saldo);
            conta.Saca(600);
            Console.WriteLine(conta.Saldo);
            conta.Deposita(200);
            Console.WriteLine(conta.Saldo);
            conta.Deposita(100);
            Console.WriteLine(conta.Saldo);

            Console.ReadKey();
        }

        private static void StateDeOrcamento()
        {
            Orcamento reforma = new Orcamento(500);

            Console.WriteLine(reforma.Valor);
            reforma.AplicaDescontoExtra();

            Console.WriteLine(reforma.Valor);

            reforma.Aprova();
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Finaliza();


            Console.ReadKey();
        }
    }
}
