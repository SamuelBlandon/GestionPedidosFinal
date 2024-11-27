using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IPedidosRepositorio
    {
        void Configurar(string string_conexion);
        List<Pedidos> Listar();
        List<Pedidos> Buscar(Expression<Func<Pedidos, bool>> condiciones);
        Pedidos Guardar(Pedidos entidad);
        Pedidos Modificar(Pedidos entidad);
        Pedidos Borrar(Pedidos entidad);
    }
}