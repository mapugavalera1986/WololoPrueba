using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WololoPrueba.ObjetosTransferir
{
    public class ParticipanteCrearDto
    {
        [Required(ErrorMessage = "Es obligatorio un nombre")]
        public string Nmbrs { get; set; }

        [Required(ErrorMessage = "Es obligatorio un apellido")]
        public string Aplld { get; set; }

        [DefaultValue("")]
        public string Dni { get; set; }

        [Required(ErrorMessage = "Se necesita ingresar una fecha de nacimiento")]
        public DateTime FechaNac { get; set; }

        [Required(ErrorMessage = "Se requiere de un correo electrónico")]
        public string CorreoE { get; set; }

        [Required(ErrorMessage = "Se requiere especificar un colegio")]
        public int ColegioId { get; set; }
    }
}
