using System;
using TestApp1.Common.DB;
using TestApp1.Data.Interfaces;

namespace TestApp1.Data.Database
{
	public class ServiceClientDatabase : AppDatabase, IServiceClientDatabase
	{
		public ServiceClientDatabase(IServiceClientInternalDatabase database) : base(database)
		{
		}
	}
}
