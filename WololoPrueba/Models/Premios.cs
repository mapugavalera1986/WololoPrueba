using System.ComponentModel.DataAnnotations;

namespace WololoPrueba.Models
{
    public partial class Premios
    {
        [Key]
        public int PremioId { get; set; }
        public string nombPremio { get; set; }
    }
}
