﻿using Observer.ObserverNotaFiscal;
using System.Collections.Generic;

namespace Observer
{
    public static class ExemplosObserver
    {
        public static void Observer()
        {
            var itemBuilder = new ItemDaNotaBuilder();
            itemBuilder
                .ComNome("item1")
                .ComValor(100);
            var item1 = itemBuilder.Constroi();
            itemBuilder
                .ComNome("item2")
                .ComValor(200);
            var item2 = itemBuilder.Constroi();
            itemBuilder
                .ComNome("item3")
                .ComValor(200);
            var item3 = itemBuilder.Constroi();

            var acoes = new List<IAcoesDaNotaFiscal> { new EnviadorDeEmail(), new NotaFiscalDao(), new Multiplicador(2) };

            var builder = new NotaFiscalBuilder(acoes);
            builder
                .ComRazaoSocial("Filomeno Advogados")
                .ComCnpj("24.093.094/0001.59")
                .Com(item1)
                .Com(item2)
                .Com(item3)
                .ComObservacoes("uma observacao qualquer");
            //.ComAcao(new EnviadorDeEmail())
            //.ComAcao(new NotaFiscalDao())
            //.ComAcao(new Multiplicador(2));

            var nota = builder.Constroi();

            nota.Imprime();
        }
    }
}