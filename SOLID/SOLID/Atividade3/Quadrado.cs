using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Atividade3
{
    public class Quadrado : Shape
    { 
        public override void inserirAltura(double altura)
        {
            this.altura = altura;
            this.largura = altura;
        }

        public override void inserirLargura(double largura)
        {
            this.largura = largura;
            this.altura = largura;
        }
    }

}
