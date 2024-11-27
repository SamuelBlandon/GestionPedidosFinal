using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lib_entidades.Modelos
{
    public class Transportistas
    {
        [Key] public int Id { get; set; }
        public string? tipo_transportista { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(tipo_transportista))
                return false;
            return true;
        }

    }
}
