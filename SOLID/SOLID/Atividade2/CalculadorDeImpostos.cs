using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Atividade2
{
    public class CalculadorDeImpostos
    {
        public double RetornarImposto (IImposto[] listaImpostos)
        {
            double taxaImpostos = 0;
            foreach (var imposto in listaImpostos)
            {
                taxaImpostos += imposto.Get();
            }

            return taxaImpostos;
        }
    }
}
