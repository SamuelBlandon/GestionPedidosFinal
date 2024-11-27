using System.ComponentModel.DataAnnotations;
using static System.Reflection.Metadata.BlobBuilder;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Paquetes
    {
        [Key] public int Id { get; set; }
        public string? tipo_paquete { get; set; }
        public string? medida { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(tipo_paquete) || string.IsNullOrEmpty(medida))
                return false;
            return true;
        }

    }
}
