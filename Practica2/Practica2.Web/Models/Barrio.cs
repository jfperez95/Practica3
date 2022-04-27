using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Practica2.Web.Models
{
    public class Barrio
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        public string Nombre { get; set; }

        public ICollection<Alumno> Alumnos { get; set; }
        [DisplayName("Alumnos Number")]
        public int AlumnosNumber => Alumnos == null ? 0 : Alumnos.Count;

        [JsonIgnore] //lo ignora en la respuesta json
        [NotMapped] //no se crea en la base de datos
        public int MunicipioId { get; set; }

    }
}
