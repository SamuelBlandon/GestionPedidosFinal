using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Reflection.Metadata.BlobBuilder;

namespace lib_entidades.Modelos
{
    public class Pedidos
    {
        [Key] public int id { get; set; }
        public string? codigo { get; set; }
        [ForeignKey("Detalles")] public int id_detalle { get; set; }
        [ForeignKey("Personas")] public int id_persona { get; set; }

        [NotMapped] public virtual Detalles? _Detalle { get; set; }
        [NotMapped] public virtual Personas? _Persona { get; set; }

    }
}
