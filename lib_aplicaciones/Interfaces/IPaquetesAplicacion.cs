using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IPaquetesAplicacion
    {
        void Configurar(string string_conexion);
        List<Paquetes> Buscar(Paquetes entidad, string tipo);
        List<Paquetes> Listar();
        Paquetes Guardar(Paquetes entidad);
        Paquetes Modificar(Paquetes entidad);
        Paquetes Borrar(Paquetes entidad);
    }
}