using Microsoft.EntityFrameworkCore;
using PatientDB.DataAccess.Configurations;
using PatientDB.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDB.DataAccess.Contexts
{
	public class PatientDBContext : DbContext
	{
        public PatientDBContext(DbContextOptions<PatientDBContext> options) : base(options)
        {
            
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UserConfiguration());
			modelBuilder.ApplyConfiguration(new RoleConfiguration());
			modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
			modelBuilder.ApplyConfiguration(new GenderConfiguration());
			modelBuilder.ApplyConfiguration(new PatientConfiguration());
		}
		public DbSet<User> Users { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<UserRole> UserRoles { get; set; }
		public DbSet<Patient> Patients { get; set; }
		public DbSet<Gender> Genders { get; set; }
	}
}
