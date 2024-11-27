using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class PaquetesRepositorio : IPaquetesRepositorio
    {
        private Conexion? conexion = null;

        public PaquetesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Paquetes> Listar()
        {
            return conexion!.Listar<Paquetes>();
        }

        public List<Paquetes> Buscar(Expression<Func<Paquetes, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Paquetes Guardar(Paquetes entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Paquetes Modificar(Paquetes entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Paquetes Borrar(Paquetes entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}