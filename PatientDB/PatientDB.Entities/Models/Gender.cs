using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDB.Entities.Models
{
	public class Gender : BaseEntity
	{
        public string Definition { get; set; }
		public List<User> Users { get; set; }
    }
}
