using PatientDB.DataAccess.Contexts;
using PatientDB.DataAccess.Interfaces;
using PatientDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDB.DataAccess.Repositories
{
	public class Repository<T> : IRepository<T> where T : BaseEntity
	{
		private readonly PatientDBContext _context;
		public Repository (PatientDBContext context)
		{
			_context = context;
		}
	}
}
