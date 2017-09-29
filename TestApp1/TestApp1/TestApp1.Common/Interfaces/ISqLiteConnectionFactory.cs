using System;
using SQLite.Net;

namespace TestApp1.Common.Interfaces
{
	public interface ISqLiteConnectionFactory
	{
		SQLiteConnectionWithLock GetLogsConnection();

		SQLiteConnectionWithLock GetAppDBConnection();
	}
}
