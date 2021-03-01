using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pandora_cliente.Model
{
    public class Municipio :EntidadeDominioCliente
    {
        
        public int Codigo { get; set; }

        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(200)]
        public string Uf { get; set; }

        public int MunicipioID {get;set;}

        public virtual Estado Estado { get; set; }
        
    }
}
