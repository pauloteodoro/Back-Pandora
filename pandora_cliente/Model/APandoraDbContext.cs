using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pandora_cliente.Model;

namespace pandora_cliente.Model
{
    public class APandoraDbContext : DbContext
    {
        public APandoraDbContext(DbContextOptions<APandoraDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Estado> Estados{ get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<TipoCliente> TipoClientes{ get; set; }
        public DbSet<TipoDocumento> tipoDocumentos { get; set; }
        public DbSet<TipoEndereco> TipoEnderecos { get; set; }
        public DbSet<pandora_cliente.Model.EntidadeDominioCliente> EntidadeDominioCliente { get; set; }
    }
}
