using System.ComponentModel.DataAnnotations;

namespace WololoPrueba.ObjetosTransferir
{
    public class PremioDto
    {
        public int PremioId { get; set; }
        [Required(ErrorMessage = "Se necesita el especificar el Premio")]
        public string NombPremio { get; set; }
    }
}
