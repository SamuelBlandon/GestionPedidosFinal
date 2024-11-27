using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface ITransportistasAplicacion
    {
        void Configurar(string string_conexion);
        List<Transportistas> Buscar(Transportistas entidad, string tipo);
        List<Transportistas> Listar();
        Transportistas Guardar(Transportistas entidad);
        Transportistas Modificar(Transportistas entidad);
        Transportistas Borrar(Transportistas entidad);
    }
}