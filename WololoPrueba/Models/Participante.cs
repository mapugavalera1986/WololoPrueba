using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WololoPrueba.Models
{
    public class Participante
    {
        public int ParticipanteId { get; set; }
        public string Nmbrs { get; set; }
        public string Aplld { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNac { get; set; }
        public string CorreoE { get; set; }
        public int ColegioId { get; set; }
        public Colegio Colegio { get; set; }
    }
}


