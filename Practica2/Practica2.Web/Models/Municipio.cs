using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Practica2.Web.Models
{
    public class Municipio
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        public string Nombre { get; set; }

        public ICollection<Barrio > Barrios { get; set; }
        [DisplayName("Barrios Number")]
        public int BarriosNumber => Barrios == null ? 0 : Barrios.Count;

    }
}
