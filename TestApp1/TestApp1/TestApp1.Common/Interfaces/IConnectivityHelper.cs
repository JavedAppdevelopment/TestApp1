using System;
using System.Threading.Tasks;
using TestApp1.Common.Enums;

namespace TestApp1.Common.Interfaces
{
	public interface IConnectivityHelper
	{
		bool IsConnected { get; }

		NetworkStatus NetworkStatus { get; }

		Task InitiateCheckingAsync();

		void ContinueChecking();

		void PauseChecking();

		Task SetConnectionAsync();
	}
}
