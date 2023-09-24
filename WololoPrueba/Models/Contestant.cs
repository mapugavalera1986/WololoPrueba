namespace WololoPrueba.Models
    //Esta clase Concursantes en inglés sería como el registro del concurso, se guargan alumno, centro educativo,civilizacion elegida.
public class Constestant
{
    public Constestant()
    {

        public int ContestantId { get; set; }
        public int AlumnId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CentroEduId { get; set; }
        public int CivId { get; set; }    
        public string Result { get; set; } //Nota, resultado, calificación del ensayo
        



}
}

