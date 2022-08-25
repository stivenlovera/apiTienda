using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Entities
{
    public class VendedorArchivo
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Caption { get; set; }
        public int Tamaño { get; set; }
        public string Extencion { get; set; }
        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }
    }
}