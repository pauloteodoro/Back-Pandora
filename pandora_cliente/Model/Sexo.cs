using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pandora_cliente.Model
{
    public class Sexo : EntidadeDominioCliente
    {
        [Required]
        [MaxLength(200)]
        public string SexoPessoa { get; set; }
    }
}
