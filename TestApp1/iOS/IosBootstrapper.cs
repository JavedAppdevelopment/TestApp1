using System;
using Microsoft.Practices.Unity;
using TestApp1.Common.Interfaces;
using TestApp1.Forms.iOS.PlatformServices;
using TestApp1.Forms.iOS.Utils;
using TestApp1.iOS.Helpers;
using TestApp1.iOS.Providers;

namespace TestApp1.Forms.iOS
{
	public class IosBootstrapper
	{
		public static void Initialize(IUnityContainer container)
		{
			// Interface and Class Registration goes here.
			container.RegisterType<IAppConfig, IosAppConfig>(new TransientLifetimeManager());
			container.RegisterType<INetworkStatusService, IOSNetworkStatusServices>(new HierarchicalLifetimeManager());
			container.RegisterType<IThreadExecutionProvider, ThreadExecutionProvider>(new TransientLifetimeManager());
			container.RegisterType<IStackFrameHelper, StackFrameHelper>(new ContainerControlledLifetimeManager());
			container.RegisterType<IPlatformService, PlatformServiceIos>(new ContainerControlledLifetimeManager());
			container.RegisterType<IGoogleAnalyticsServices, IosGoogleAnalyticsServices>(new ContainerControlledLifetimeManager());
			container.RegisterType<IDialogService, IosDialogService>(new TransientLifetimeManager());
			container.RegisterType<IAppAnalyticsProvider, RaygunAppAnalyticsProvider>(new TransientLifetimeManager());
			container.RegisterType<IFileSystemHelper, FileSystemHelper>(new TransientLifetimeManager());
			container.RegisterType<IEncryptionProvider, EncryptionProvider>(new TransientLifetimeManager());
		}
	}
}
