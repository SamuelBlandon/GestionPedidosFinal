using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IPaquetesRepositorio
    {
        void Configurar(string string_conexion);
        List<Paquetes> Listar();
        List<Paquetes> Buscar(Expression<Func<Paquetes, bool>> condiciones);
        Paquetes Guardar(Paquetes entidad);
        Paquetes Modificar(Paquetes entidad);
        Paquetes Borrar(Paquetes entidad);
    }
}
