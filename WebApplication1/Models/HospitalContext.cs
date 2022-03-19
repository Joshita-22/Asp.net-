using System.Data.Entity;

namespace WebApplication1.Models
{
    public class HospitalContext : DbContext
    {
        public DbSet<Doctor> doctor { get; set; }
        public DbSet<Patient> patient { get; set; }
        public DbSet<Appointment> apt { get; set; }
    }
}
 