using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace iSkedyul.Models.DB
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() { }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
        public virtual DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MidtermsDB;Initial Catalog=iSkedyulDB;Integrated Security=True;Multiple Active Result Sets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointment");

                entity.Property(e => e.AppointmentID).HasColumnName("AppointmentID").HasColumnType("int");

                entity.Property(e => e.FirstName).HasColumnName("FirstName").HasMaxLength(50).IsUnicode(false);

                entity.Property(e => e.LastName).HasColumnName("LastName").HasMaxLength(50).IsUnicode(false);

                entity.Property(e => e.DateTimeOfAppointment).HasColumnName("DateTimeOfAppointment").HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Purpose).HasColumnName("Purpose").HasMaxLength(50).IsUnicode(false);
            });
        }
    }
}
