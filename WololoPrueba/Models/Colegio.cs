using System.ComponentModel.DataAnnotations;

namespace WololoPrueba.Models;

public class Colegio
{
    public int ColegioId { get; set; }

    [Required(ErrorMessage = "Es obligatorio un nombre")]
    public string Nmbr { get; set; }

    [Required(ErrorMessage = "Se requiere determinar el nivel")]
    public string Nivel { get; set; }

    [Required(ErrorMessage = "Se requiere ingresar la dirección del local")]
    public string Direccn { get; set; }
}
