using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace school
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DbContext")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(e => e.ID);

            modelBuilder.Entity<Student>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.City)
                .IsFixedLength();

            modelBuilder.Entity<Subject>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Subject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Teacher)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.ID);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.City)
                .IsFixedLength();
        }
    }
}
