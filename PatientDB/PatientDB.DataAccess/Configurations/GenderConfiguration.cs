using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PatientDB.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDB.DataAccess.Configurations
{
	public class GenderConfiguration : IEntityTypeConfiguration<Gender>
	{
		public void Configure(EntityTypeBuilder<Gender> builder)
		{
			throw new NotImplementedException();
		}
	}
}
