using System.ComponentModel.DataAnnotations;

namespace IES9012.core.Modelos
{
    public class Materia
    {
        public int MateriaId { get; set; }

        [Required]
        [StringLength(30)]
        public String? NombreMateria { get; set; }
        public int Creditos { get; set; }
        public ICollection<Inscripcion>? Inscripciones { get; set; }
        public string Nombre { get; set; }
    }
}