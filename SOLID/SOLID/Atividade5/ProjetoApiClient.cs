using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Atividade5
{
    public class ProjetoApiClient
    {
        private BackEndDeveloper backEndDeveloper { get; set; }
        private FrontEndDeveloper frontEndDeveloper { get; set; }

        public ProjetoApiClient(BackEndDeveloper backEndDeveloper, FrontEndDeveloper frontEndDeveloper)
        {
            this.backEndDeveloper = backEndDeveloper;
            this.frontEndDeveloper = frontEndDeveloper;
        }

        public void implementar()
        {
            this.backEndDeveloper.writeAPI();
            this.frontEndDeveloper.writeClientConsumer();
        }

    }
}
