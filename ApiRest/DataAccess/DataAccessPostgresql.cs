using ApiRest.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiRest.DataAccess
{
    /// <summary>
    /// Natalia González 20/03/2022
    /// </summary>
    public class DataAccessPostgresql : DbContext
    {
        /// <summary>
        /// Propiedades de modelo con set de datos
        /// </summary>
        public DbSet<catalumnos> catalumnos { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options"></param>
        public DataAccessPostgresql(DbContextOptions<DataAccessPostgresql> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        /// <summary>
        /// CREATE: sobreescribe el acceso a persistencia y almacenado de datos
        /// </summary>
        /// <returns>INT</returns>
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
