using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface ITransportistasRepositorio
    {
        void Configurar(string string_conexion);
        List<Transportistas> Listar();
        List<Transportistas> Buscar(Expression<Func<Transportistas, bool>> condiciones);
        Transportistas Guardar(Transportistas entidad);
        Transportistas Modificar(Transportistas entidad);
        Transportistas Borrar(Transportistas entidad);
    }
}