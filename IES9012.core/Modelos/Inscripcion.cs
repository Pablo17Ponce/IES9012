using IES9012.core.Enumeraciones;
using System.ComponentModel.DataAnnotations;

namespace IES9012.core.Modelos;

public class Inscripcion
{
    public int InscripcionId { get; set; }
    //La entidad materiaId es una clave externa y la propiedad  de navegacion correspondiente
    //Una entidad Inscripcion esta asociada a una entidad Materia
    public int MateriaId { get; set; }

    //La propiedad Estudiante es una clave externa y la propiedad de navegacion
    //correspondiente es Estudiante. Una entidad Inscripcion esta asociada con 
    //una entidad Estudiante, por lo tanto la propiedad contiene una unica identidad Estudiante
    public int EstudianteId { get; set; }

    [DisplayFormat(NullDisplayText = "Sin Calificar")]
    public Calificacion? Calificacion { get; set; }

    public Materia? Materia { get; set; }
    public Estudiante? Estudiante { get; set; }
}