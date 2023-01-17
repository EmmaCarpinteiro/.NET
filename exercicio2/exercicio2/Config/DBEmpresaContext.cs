using exercicio2.Models;
using Microsoft.EntityFrameworkCore;

namespace exercicio2.Config
{
    public class DBEmpresaContext: DbContext
    {
        public DBEmpresaContext(DbContextOptions<DBEmpresaContext> options) : base(options)
        {

        }

        public DbSet<Empleado> empleados { get; set; }
    }
}
