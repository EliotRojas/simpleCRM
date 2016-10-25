using System.Collections.Generic;

namespace simpleCRM.Models
{
    public class Contacto
    {
        public int ContactoId { get; set; }

        public string NombreCompleto { get; set; }

        public bool Principal { get; set; }

        public ICollection<Telefono> Telefonos { get; set; }

        public ICollection<Email> Correos { get; set; }

        public ICollection<Direccion> Direcciones { get; set; }
    }
}