using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface ITransportistasPresentacion
    {
        Task<List<Transportistas>> Listar();
        Task<List<Transportistas>> Buscar(Transportistas entidad, string tipo);
        Task<Transportistas> Guardar(Transportistas entidad);
        Task<Transportistas> Modificar(Transportistas entidad);
        Task<Transportistas> Borrar(Transportistas entidad);
    }
}