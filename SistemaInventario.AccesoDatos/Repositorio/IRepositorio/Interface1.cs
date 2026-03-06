using SistemaInventario.AccesoDatos.Migrations;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IRepositorio<T> where T : class
    {


        T Obtener(int id);

        IEnumerable<T>  ObtenerTodos(
            Expression<Func<T,  bool>>  filtro =null,
            string incluirPropiedades  = null,
            bool isTracking  = true
            );

        T ObtenerPrimero(
            Expression<Func<T, bool>> filtro =null,
            string incluirPropiedades  = null,
            bool isTracking = true
            );

        void Agregar(T entidad);

        void Remover(T entidad);

        void RemoverRango(IEnumerable<T> entidad);



    }

}
