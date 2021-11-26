using System;
using System.Collections.Generic;

#nullable disable

namespace Modelo.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            Distritos = new HashSet<Distrito>();
        }

        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Distrito> Distritos { get; set; }
    }
}
