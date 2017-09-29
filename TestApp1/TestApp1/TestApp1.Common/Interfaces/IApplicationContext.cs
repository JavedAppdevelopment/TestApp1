using TestApp1.Common.Logging;

namespace TestApp1.Common.Interfaces
{
	public interface IApplicationContext
	{
		string CurrentLoggedInUserName { get; set; }

		LogLevel LogLevel { get; set; }
	}
}
