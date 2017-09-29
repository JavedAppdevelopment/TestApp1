using System;
using System.Threading.Tasks;
using TestApp1.Common.Entities;
using TestApp1.Common.Enums;
using TestApp1.Common.Interfaces;

namespace TestApp1.Common.Logging
{
	public class LogglyLocalDatabaseLoggingProvider : BaseLogginProvider, ILoggingProvider
	{
		private readonly ILogsDatabase _database;

		public LogglyLocalDatabaseLoggingProvider(ILogsDatabase logsDatabase, IApplicationContext applicationContext, IPlatformService platformServices) : base(applicationContext, platformServices)
		{
			_database = logsDatabase;
		}

		public async Task ClearLogsAsync()
		{
			await _database.DeleteAllAsync<LogEntry>();
		}

		public void Log(string message, LogLevel level, object data, string[] tags, string callerFullTypeName, string callerMemberName, long? timeInMilliseconds = default(long?))
		{			
			LogEntry report = CreateLogEntry(message, level, data, tags, callerFullTypeName, callerMemberName,
				timeInMilliseconds);

			_database.Insert(report);
		}
	}
}
