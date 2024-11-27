﻿using lib_entidades;
using lib_aplicaciones.Interfaces;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;
using lib_entidades.Modelos;

namespace lib_aplicaciones.Implementaciones
{
    public class EstadosAplicacion : IEstadosAplicacion
    {
        private IEstadosRepositorio? iRepositorio = null;

        public EstadosAplicacion(IEstadosRepositorio iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }

        public void Configurar(string string_conexion)
        {
            this.iRepositorio!.Configurar(string_conexion);
        }

        public Estados Borrar(Estados entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }

        public Estados Guardar(Estados entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");

            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }

        public List<Estados> Listar()
        {
            return iRepositorio!.Listar();
        }

        public List<Estados> Buscar(Estados entidad, string tipo)
        {
            Expression<Func<Estados, bool>>? condiciones = null;
            switch (tipo.ToUpper())
            {
                case "ETAPA": condiciones = x => x.etapa!.Contains(entidad.etapa!); break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }

        public Estados Modificar(Estados entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
    }
}