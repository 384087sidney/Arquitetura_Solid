using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Atividade3
{
    public class Retangulo : Shape
    {
        public override void inserirAltura(double altura)
        {
            this.altura = altura;
        }

        public override void inserirLargura(double largura)
        {
            this.largura = largura;
        }
    }
}
