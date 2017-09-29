using Microsoft.Practices.Unity;
using TestApp1.Common.Logging;

namespace TestApp1.Common
{
	public class CommonBootstrapper
	{
		public static void Initialize(IUnityContainer container)
		{
			// Interface and Class Registration goes here.
			container.RegisterType<ILoggingProvider, ConsoleLoggingProvider>("ConsoleLogger", new ContainerControlledLifetimeManager());
		}
	}
}
