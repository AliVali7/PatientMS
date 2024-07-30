using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDB.Entities.Models
{
	public class User : BaseEntity
	{
		public string Username { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public List<UserRole> UserRoles { get; set; }


	}
}
