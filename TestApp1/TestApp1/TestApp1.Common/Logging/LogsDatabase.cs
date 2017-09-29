using System;
using TestApp1.Common.Interfaces;
using TestApp1.Common.DB;

namespace TestApp1.Common.Logging
{
	public class LogsDatabase : AppDatabase, ILogsDatabase
	{
		public LogsDatabase(ILogsInternalDatabase database) : base(database)
		{
		}
	}
}
