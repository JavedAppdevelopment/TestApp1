using System;
namespace TestApp1.Common.Interfaces
{
	/// <summary>
	/// Provide AES based encryption and descryption using 32 bit.
	/// </summary>
	public interface IEncryptionProvider
	{
		string Decrypt(string dataString, string password, string saltString);

		string Encrypt(string dataString, string password, string saltString);
	}
}
