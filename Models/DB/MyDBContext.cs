using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace iSkedyul.Models.DB
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() { }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Vaccination> Vaccinations { get; set; }
        public virtual DbSet<BarangayForm> BarangayForms { get; set; }

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

            modelBuilder.Entity<Vaccination>(entity =>
            {
                entity.ToTable("Vaccination");

                entity.Property(e => e.VaccineID).HasColumnName("VaccineID").HasColumnType("int");

                entity.Property(e => e.FirstName).HasColumnName("FirstName").HasMaxLength(50).IsUnicode(false);

                entity.Property(e => e.MiddleName).HasColumnName("MiddleName").HasMaxLength(50).IsUnicode(false);

                entity.Property(e => e.LastName).HasColumnName("LastName").HasMaxLength(50).IsUnicode(false);

                entity.Property(e => e.Gender).HasColumnName("Gender").HasMaxLength(10).IsUnicode(false);

                entity.Property(e => e.CivilStatus).HasColumnName("CivilStatus").HasMaxLength(10).IsUnicode(false);

                entity.Property(e => e.PWD).HasColumnName("PWD").HasColumnType("bit");

                entity.Property(e => e.Voter).HasColumnName("Voter").HasColumnType("bit");

                entity.Property(e => e.ContactNo).HasColumnName("ContactNo").HasMaxLength(15).IsUnicode(false);

                entity.Property(e => e.VaccineType).HasColumnName("VaccineType").HasMaxLength(50).IsUnicode(false);

                entity.Property(e => e.Email).HasColumnName("Email").HasMaxLength(100).IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnName("Birthday").HasColumnType("date");

                entity.Property(e => e.Nationality).HasColumnName("Nationality").HasMaxLength(50).IsUnicode(false);

                entity.Property(e => e.Occupation).HasColumnName("Occupation").HasMaxLength(50).IsUnicode(false);

                entity.Property(e => e.PlaceOfBirth).HasColumnName("PlaceOfBirth").HasMaxLength(50).IsUnicode(false);

                entity.Property(e => e.StreetAddress).HasColumnName("StreetAddress").HasMaxLength(100).IsUnicode(false);

                entity.Property(e => e.DateOfAppointment).HasColumnName("DateOfAppointment").HasMaxLength(15).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<BarangayForm>(entity =>
            {
                entity.ToTable("BarangayForm");

                entity.Property(e => e.BarangayFormID).HasColumnName("BarangayFormID").HasColumnType("int");

                entity.Property(e => e.FirstName).HasColumnName("FirstName").HasMaxLength(50).IsUnicode(false);

                entity.Property(e => e.MiddleName).HasColumnName("MiddleName").HasMaxLength(50).IsUnicode(false);

                entity.Property(e => e.LastName).HasColumnName("LastName").HasMaxLength(50).IsUnicode(false);

                entity.Property(e => e.Gender).HasColumnName("Gender").HasMaxLength(10).IsUnicode(false);

                entity.Property(e => e.CivilStatus).HasColumnName("CivilStatus").HasMaxLength(10).IsUnicode(false);

                entity.Property(e => e.PWD).HasColumnName("PWD").HasColumnType("bit");

                entity.Property(e => e.Voter).HasColumnName("Voter").HasColumnType("bit");

                entity.Property(e => e.ContactNo).HasColumnName("ContactNo").HasMaxLength(15).IsUnicode(false);

                entity.Property(e => e.Purpose).HasColumnName("Purpose").HasMaxLength(50).IsUnicode(false);

                entity.Property(e => e.Email).HasColumnName("Email").HasMaxLength(100).IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnName("Birthday").HasColumnType("date");

                entity.Property(e => e.Nationality).HasColumnName("Nationality").HasMaxLength(50).IsUnicode(false);

                entity.Property(e => e.Occupation).HasColumnName("Occupation").HasMaxLength(50).IsUnicode(false);

                entity.Property(e => e.PlaceOfBirth).HasColumnName("PlaceOfBirth").HasMaxLength(50).IsUnicode(false);

                entity.Property(e => e.StreetAddress).HasColumnName("StreetAddress").HasMaxLength(100).IsUnicode(false);

                entity.Property(e => e.DateOfAppointment).HasColumnName("DateOfAppointment").HasMaxLength(15).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });
        }
    }
}
