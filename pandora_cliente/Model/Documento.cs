using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pandora_cliente.Model
{
    public class Documento : EntidadeDominioCliente
    {
        [Required]
        [MaxLength(50)]
        public string Codigo { get; set; }

        [Required]
        [MaxLength(200)]
        public DateTime Validade { get; set; }

        public int TipoDocumentoID { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}
