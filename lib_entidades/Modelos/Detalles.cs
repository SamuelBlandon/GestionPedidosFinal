using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lib_entidades.Modelos
{
    public class Detalles
    {
        [Key] public int Id { get; set; }
        [ForeignKey("Paquetes")] public int id_paquete { get; set; }
        public string? descripcion { get; set; }
        [ForeignKey("Transportistas")] public int id_transportista { get; set; }
        [ForeignKey("Estados")] public int id_estado { get; set; }
        public DateTime fecha_entrega { get; set; }
        [NotMapped] public virtual Paquetes? _Paquete { get; set; }
        [NotMapped] public virtual Transportistas? _Transportista { get; set; }
        [NotMapped] public virtual Estados? _Estado { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(descripcion))
                return false;
            return true;
        }

    }
}
