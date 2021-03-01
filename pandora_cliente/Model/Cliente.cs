using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pandora_cliente.Model
{
    public class Cliente : Pessoa
    {
        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(200)]
        public string Senha { get; set; }

        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        public int TipoClienteID { get; set; }
        public virtual TipoCliente TipoCliente { get; set; }

        public int SexoClienteID { get; set; }
        public virtual Sexo Sexo { get; set; }

        public int TelefoneCLienteID { get; set; }
        public virtual ICollection<Telefone> Telefone {get;set;}
    }
}
