using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lib_entidades.Modelos
{
    public class Pedidos
    {
        [Key] public int Id { get; set; }
        public string? codigo { get; set; }
        [ForeignKey("Detalles")] public int id_detalle { get; set; }
        [ForeignKey("Personas")] public int id_persona { get; set; }

        [NotMapped] public virtual Detalles? _Detalle { get; set; }
        [NotMapped] public virtual Personas? _Persona { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(codigo))
                return false;
            return true;
        }

    }
}
