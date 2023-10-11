namespace WololoPrueba.Models
{
    public class Ensayo
    {
        public int EnsayoId { get; set; }
        public string Descripcion { get; set; }
        public int ParticipanteId { get; set; }
        public int CivId { get; set; }
        public DateTime FechaEntrega { get; set; } = DateTime.Now;
    }
}
