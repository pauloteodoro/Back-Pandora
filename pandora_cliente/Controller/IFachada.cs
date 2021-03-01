using pandora_cliente.Business.Comands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pandora_cliente.Controller
{
    interface IFachada
    {
        public String salvarCadastroInicial(CadastrarCliente.Message message);
        public String alterar();
        public String excluir();
    }
}
