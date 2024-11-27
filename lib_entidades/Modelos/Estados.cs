using System.ComponentModel.DataAnnotations;

namespace lib_entidades.Modelos
{
    public class Estados
    {
        [Key] public int Id { get; set; }
        public string? etapa { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(etapa))
                return false;
            return true;
        }

    }
}
