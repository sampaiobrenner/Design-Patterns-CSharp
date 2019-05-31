﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class RespostaEmXml : IResposta
    {
        public IResposta Proximo { get; set; }
        public RespostaEmXml(IResposta proximo)
        {
            this.Proximo = proximo;
        }
        public RespostaEmXml()
        {
            this.Proximo = null;
        }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.XML)
            {
                Console.WriteLine("<conta>");
                Console.WriteLine("   <titular>");
                Console.WriteLine("      "+conta.Titular);
                Console.WriteLine("   </titular>");
                Console.WriteLine("   <saldo>");
                Console.WriteLine("      " + conta.Saldo);
                Console.WriteLine("   </saldo>");
                Console.WriteLine("</conta>");
            }
            else
            {
                Proximo.Responde(requisicao, conta);
            }
        }
    }
}
