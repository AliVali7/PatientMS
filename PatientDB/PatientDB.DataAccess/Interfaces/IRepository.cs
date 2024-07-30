using PatientDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDB.DataAccess.Interfaces
{
	public interface IRepository<T> where T : BaseEntity
	{
	}
}
