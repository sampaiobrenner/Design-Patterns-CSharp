﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imposto();

            //Investimento();

        }

        private static void Investimento()
        {
            Investimento conservador = new Conservador();
            Investimento moderado = new Moderado();
            Investimento arrojado = new Arrojado();

            RealizadorDeInvestimentos investe = new RealizadorDeInvestimentos();

            Conta conta = new Conta(100);

            investe.Calcula(conta, arrojado);

            Console.ReadKey();
        }

        private static void Imposto()
        {
            Imposto Iss = new ISS();
            Imposto Icms = new ICMS();
            Imposto Iccc = new ICCC();

            Orcamento orcamento = new Orcamento(4000);
            CalculadorDeImposto Calculador = new CalculadorDeImposto();

            Calculador.RealizaCalculo(orcamento, Iss);
            Calculador.RealizaCalculo(orcamento, Icms);
            Calculador.RealizaCalculo(orcamento, Iccc);

            Console.ReadKey();
        }
    }
}
