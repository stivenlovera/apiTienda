using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Entities
{
    public class SubCategoria
    {
        [Key]
        public int Id { get; set; }
        public int Nombre { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public List<Producto> Productos { get; set; }
    }
}