using System.ComponentModel.DataAnnotations;
namespace apiTienda.Entities
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Estado { get; set; }
        public Usuario Usuario { get; set; }
        public Vendedor Vendedor { get; set; }
    }
}