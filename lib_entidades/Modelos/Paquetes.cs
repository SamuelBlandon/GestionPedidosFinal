using System.ComponentModel.DataAnnotations;
using static System.Reflection.Metadata.BlobBuilder;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Paquetes
    {
        [Key] public int id { get; set; }
        public string? tipo_paquete { get; set; }
        public string? medida { get; set; }

    }
}
