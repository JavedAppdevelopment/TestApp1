using System;
using System.Threading.Tasks;
using TestApp1.Common.Enums;

namespace TestApp1.Common.Interfaces
{
	public interface INavigationService
	{
		PageKey CurrentPageKey { get; }

		Task NavigateToFirstScreenAsync();

		Task NavigateToAsync(PageKey pageKey, bool isAnimated = false);

		Task PopToRootAsync();

		Task GoBackAsync(int numberOfPagesToSkip = 0);

		Task GoBackToPageAsync(PageKey pageKey);

		void PresentMenuView();
	}
}
