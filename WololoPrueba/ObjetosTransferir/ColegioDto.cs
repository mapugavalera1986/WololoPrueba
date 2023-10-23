using System.ComponentModel.DataAnnotations;

namespace WololoPrueba.ObjetosTransferir
{
    public class ColegioDto
    {
        public int ColegioId { get; set; }
        [Required(ErrorMessage = "Se necesita el nombre del colegio")]
        public string Nmbr { get; set; }

        [Required(ErrorMessage = "Se requiere determinar el nivel (primario, secundario o ambos)")]
        public string Nivel { get; set; }

        [Required(ErrorMessage = "Se requiere ingresar la dirección del local")]
        public string Direccn { get; set; }
    }
}
