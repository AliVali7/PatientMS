using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDB.Entities.Models
{
	public class Role : BaseEntity
	{
        public string Definition { get; set; }
		public List<UserRole> UserRoles { get; set; }
	}
}
