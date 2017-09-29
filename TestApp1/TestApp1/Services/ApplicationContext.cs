using TestApp1.Common.Interfaces;
using TestApp1.Common.Logging;

namespace TestApp1.Forms.Services
{
	public class ApplicationContext : IApplicationContext
	{		
		public string CurrentLoggedInUserName { get; set; }

		public LogLevel LogLevel { get; set; }
	}
}
