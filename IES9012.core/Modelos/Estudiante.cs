using System.ComponentModel.DataAnnotations;
namespace IES9012.core.Modelos
{
    public class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }//columna de la clave principal de la base de datos

        [Required]
        [StringLength(50)]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(35)]
        public string? Apellido { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy", ApplyFormatInEditMode = true)]
        public DateTime FechaInscripcion { get; set; } = DateTime.Now;

        public ICollection<Inscripcion>? Inscripcion { get; set; } //Icollection es una interfaz que me arma una coleccion de objetos
        //La propiedad Incripcion se una propiedad de navegacion
        //La propiedad de navegacion contienen otras entidades relacionadas con esta entidad
        //La propiedad Inscripciones se define como ICollection<Inscripcion>
        //porque puede haber varias entidades de estudiantes


    }
}
