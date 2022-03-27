using ApiRest.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiRest.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly DataAccessPostgresql _provider;

        public DataAccessProvider(DataAccessPostgresql provider)
        {
            _provider = provider;
        }

        public List<catalumnos> GetCatAlumnoRecords()
        {
            return _provider.catalumnos.ToList();
        }

        public catalumnos GetCatAlumnoSingleRecord(int id)
        {
            return _provider.catalumnos.FirstOrDefault(t => t.id == id);
        }

        public void AddAlumnoRecord(catalumnos alumnos)
        {
            _provider.catalumnos.Add(alumnos);
            _provider.SaveChanges();
        }
    }
}
