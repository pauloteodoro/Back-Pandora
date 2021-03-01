using pandora_cliente.Business.Comands;
using pandora_cliente.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pandora_cliente.Controller
{
    public class Fachada : IFachada
    {
        private readonly APandoraDbContext _context;

        public Fachada(APandoraDbContext context)
        {
            _context = context;
        }

        public string alterar()
        {
            throw new NotImplementedException();
        }

        public string excluir()
        {
            throw new NotImplementedException();
        }

        

        public string salvarCadastroInicial(CadastrarCliente.Message message)
        {
            CadastrarCliente.cadastro(_context , message);

            return "Cadastrado com sucesso";
        }
    }
}
