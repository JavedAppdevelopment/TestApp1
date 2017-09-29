using System;
namespace TestApp1.Common.Interfaces
{
	public interface IStackFrameHelper
	{
		string GetCallerFullTypeName(int? skipFrames = null);

		Type GetCallerFullType(int? skipFrames = null);
	}
}
