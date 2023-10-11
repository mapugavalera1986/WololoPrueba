using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WololoPrueba.Models;

public class Participante
{
    public int ParticipanteId { get; set; }

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
    public int ColegioId { get; set; }
    public Colegio Colegio { get; set; }
}


