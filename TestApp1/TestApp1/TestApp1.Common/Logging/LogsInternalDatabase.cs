using System;
using TestApp1.Common.DB;
using TestApp1.Common.Entities;
using TestApp1.Common.Interfaces;

namespace TestApp1.Common.Logging
{
	public class LogsInternalDatabase : AppInternalDatabase, ILogsInternalDatabase
	{
		public LogsInternalDatabase(ISqLiteConnectionFactory connectionFactory) : base(connectionFactory.GetLogsConnection())
		{
			// Create tables if they don't exist.
			Connection.CreateTable<LogEntry>();

			Connection.CreateIndex<LogEntry>(x => x.SentToServerAtUtc);
		}
	}
}
