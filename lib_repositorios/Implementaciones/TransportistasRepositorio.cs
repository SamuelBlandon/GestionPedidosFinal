using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class TransportistasRepositorio : ITransportistasRepositorio
    {
        private Conexion? conexion = null;

        public TransportistasRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Transportistas> Listar()
        {
            return conexion!.Listar<Transportistas>();
        }

        public List<Transportistas> Buscar(Expression<Func<Transportistas, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Transportistas Guardar(Transportistas entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Transportistas Modificar(Transportistas entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Transportistas Borrar(Transportistas entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}