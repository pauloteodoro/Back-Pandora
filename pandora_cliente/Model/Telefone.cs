using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pandora_cliente.Model
{
    public class Telefone : EntidadeDominioCliente
    {
        [Required]
        [MaxLength(200)]
        public string TipoTelefone { get; set; }

        [Required]
        [MaxLength(200)]
        public string TelefoneComDD { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
