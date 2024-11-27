using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IPaquetesPresentacion
    {
        Task<List<Paquetes>> Listar();
        Task<List<Paquetes>> Buscar(Paquetes entidad, string tipo);
        Task<Paquetes> Guardar(Paquetes entidad);
        Task<Paquetes> Modificar(Paquetes entidad);
        Task<Paquetes> Borrar(Paquetes entidad);
    }
}