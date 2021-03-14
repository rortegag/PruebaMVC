using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTecnica.Models
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public char Sexo { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        public string Pais { get; set; }
        [Display(Name = "Código Postal")]
        public int CodigoPostal { get; set; }
    }
}
