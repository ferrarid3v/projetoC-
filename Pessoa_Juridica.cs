using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade
{
    class Pessoa_Juridica : Clientes
    {
        public string cnpj { get; set; }
        public string re { get; set; }

        public override void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100;
            this.valor = this.valor + this.valor_imposto;
        }
    }
}