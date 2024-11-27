using lib_repositorio;
using lib_repositorio.Implementaciones;
using lib_repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mts_pruebas_unitarias.Repositorios
{

    [TestClass]
    public class pedidosPruebaUnitaria
    {
        private ipedidos_repositorio? iRepositorio = null;

        public pedidosPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = ConfiguracionHelper.ObtenerValor("connectionString");
            iRepositorio = new pedidos_repositorio(conexion);
        }

        [TestMethod]
        public void Ejecutar()
        {
            Listar();
        }

        private void Listar()
        {
            var lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }
    }

}

