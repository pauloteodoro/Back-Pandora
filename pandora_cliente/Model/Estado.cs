using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pandora_cliente.Model
{
    public class Estado : EntidadeDominioCliente
    {
        [Required]
        public int CodigoUf { get; set; }

        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(25)]
        public string Uf { get; set; }
        [Required]
        public int Regiao { get; set; }

    }
}
