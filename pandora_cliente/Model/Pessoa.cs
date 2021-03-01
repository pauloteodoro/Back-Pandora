using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pandora_cliente.Model
{
    public class Pessoa : EntidadeDominioCliente
    {
        [Required]
        [MaxLength(200)]
        public string CPF { get; set; }
        public int DocumentoID { get; set; }

        public virtual ICollection<Documento> Documentos {get;set;}
    }
}
