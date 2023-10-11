using System.ComponentModel.DataAnnotations;

namespace WololoPrueba.Models
{
    public class Colegio
    {
        public int ColegioId { get; set; }
        public string Nmbr { get; set; }
        public string Nivel { get; set; }
        public string Direccn { get; set; }
    }
}
