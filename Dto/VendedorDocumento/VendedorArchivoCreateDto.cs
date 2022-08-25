using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Dto.VendedorDocumento
{
    public class VendedorArchivoCreateDto
    {
        public string Nombre { get; set; }
        public string Caption { get; set; }
        public int Tamaño { get; set; }
        public string Extencion { get; set; }
        public int VendedorId { get; set; }
    }
}