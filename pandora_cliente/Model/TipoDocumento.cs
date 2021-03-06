﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pandora_cliente.Model
{
    public class TipoDocumento : EntidadeDominioCliente
    {

        [Required]
        [MaxLength(200)]
        public string Descricao { get; set; }

        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }

        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
