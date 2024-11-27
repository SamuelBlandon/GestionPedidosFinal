using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class PedidosRepositorio : IPedidosRepositorio
    {
        private Conexion? conexion = null;

        public PedidosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Pedidos> Listar()
        {
            return conexion!.Listar<Pedidos>();
        }

        public List<Pedidos> Buscar(Expression<Func<Pedidos, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Pedidos Guardar(Pedidos entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Pedidos Modificar(Pedidos entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Pedidos Borrar(Pedidos entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}