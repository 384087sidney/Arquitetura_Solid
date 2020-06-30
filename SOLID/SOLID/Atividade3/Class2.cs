using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Atividade3
{
    class Class2
    {
        public void verifica(Shape r)
        {
            r.inserirLargura(5);
            r.inserirAltura(4);
            var retorno = r.altura * r.largura == 20;
        }

    }
}
