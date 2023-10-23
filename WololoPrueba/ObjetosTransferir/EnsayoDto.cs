using System.ComponentModel.DataAnnotations;

namespace WololoPrueba.ObjetosTransferir
{
    public class EnsayoDto
    {
        public int EnsayoId { get; set; }

        [Required(ErrorMessage = "Se necesita un título para el ensayo")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Se necesita especificar al participante")]
        public int ParticipanteId { get; set; }

        [Required(ErrorMessage = "Se necesita la civilización de Age of Empires")]
        public int CivId { get; set; }

        [Required(ErrorMessage = "Recuerda que la fecha de la entrega es el mismo día")]
        public DateTime FechaEntrega { get; set; }
    }
}
