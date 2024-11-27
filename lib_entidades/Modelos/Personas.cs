using System.ComponentModel.DataAnnotations;

namespace lib_entidades.Modelos
{
    public class Personas
    {
        [Key] public int Id { get; set; }
        public string? nombre { get; set; }
        public int cedula { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(nombre))
                return false;
            return true;
        }
    }

}
