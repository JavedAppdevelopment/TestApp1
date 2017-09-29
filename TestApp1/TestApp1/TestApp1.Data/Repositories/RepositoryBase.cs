using TestApp1.Common.Logging;
using TestApp1.Data.Interfaces;

namespace TestApp1.Data.Repositories
{
	public class RepositoryBase
	{
		public RepositoryBase(IServiceClientDatabase database, ILogger logger)
		{
			Database = database;
			Logger = logger;
		}

		protected IServiceClientDatabase Database { get; set; }

		protected ILogger Logger { get; set; }
	}
}
