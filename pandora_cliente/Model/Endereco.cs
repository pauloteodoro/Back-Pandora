using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pandora_cliente.Model
{
    public class Endereco : EntidadeDominioCliente
    {
        [Required]
        [MaxLength(200)]
        public string Logradouro { get; set; }

        [Required]
        [MaxLength(200)]
        public string Numero { get; set; }

        [Required]
        [MaxLength(200)]
        public string CEP { get; set; }

        [Required]
        [MaxLength(200)]
        public string Complemento { get; set; }

        public int TipoEnderecoID { get; set; }
        public int MunicipioID { get; set; }

        public virtual TipoEndereco TipoEndereco { get; set; }
        public virtual Municipio Municipio { get; set; }
    }
}
