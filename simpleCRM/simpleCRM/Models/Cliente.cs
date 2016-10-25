using System.Collections.Generic;

namespace simpleCRM.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string Nombre { get; set; }

        public int TipoClienteId { get; set; }

        public TipoCliente Tipo { get; set; }

        public string RFC { get; set; }

        public Contacto ContactoCliente { get; set; }

        public string TipoPersonaSat { get; set; }

        public ICollection<Telefono> Telefonos { get; set; }

        public ICollection<Email> Correos { get; set; }

        public ICollection<Direccion> Direcciones { get; set; }
    }
}