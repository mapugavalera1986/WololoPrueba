using System.ComponentModel.DataAnnotations;

namespace WololoPrueba.ObjetosTransferir
{
    public class PremiosCrearDto
    {
        [Required(ErrorMessage = "Se necesita el especificar el Premio")]
        public string nombPremio { get; set; }


    }
}
