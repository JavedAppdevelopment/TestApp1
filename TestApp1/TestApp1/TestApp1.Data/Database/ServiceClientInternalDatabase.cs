using TestApp1.Common.DB;
using TestApp1.Common.Interfaces;
using TestApp1.Data.Entities;
using TestApp1.Data.Interfaces;

namespace TestApp1.Data.Database
{
    public class ServiceClientInternalDatabase : AppInternalDatabase, IServiceClientInternalDatabase
	{
		public ServiceClientInternalDatabase(ISqLiteConnectionFactory connectionFactory) : base(connectionFactory.GetAppDBConnection())
		{
			// Create tables here, using following Way,
			Connection.CreateTable<TestEntity>();
		}
	}
}
