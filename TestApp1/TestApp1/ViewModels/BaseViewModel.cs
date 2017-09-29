using TestApp1.Common.Interfaces;
using TestApp1.Common.Logging;
using XLabs.Forms.Mvvm;

namespace TestApp1.Forms.ViewModels
{
	public class BaseViewModel : ViewModel
	{
		protected readonly INavigationService NavigationService;
		protected readonly ILogger Logger;

		public BaseViewModel(INavigationService navigationService, ILogger logger)
		{
			NavigationService = navigationService;
			Logger = logger;
		}
	}
}
