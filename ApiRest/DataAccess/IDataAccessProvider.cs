using ApiRest.Models;
using System.Collections.Generic;

namespace ApiRest.DataAccess
{
    public interface IDataAccessProvider
    {
        /// <summary>
        /// obtiene la lista de los alumnos de la tabla catalumnos
        /// </summary>
        /// <returns></returns>
        List<catalumnos> GetCatAlumnoRecords();

        /// <summary>
        /// Obtiene solo un registro por id de alumno
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        catalumnos GetCatAlumnoSingleRecord(int id);

        void AddAlumnoRecord(catalumnos alumno);
    }
}
