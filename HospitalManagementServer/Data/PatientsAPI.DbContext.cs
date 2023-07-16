using HospitalManagementServer.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementServer.API
{
    public class PatientsAPIDbcontext : DbContext

    {
        public PatientsAPIDbcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Patient> Patients{ get; set; }
    }
}
