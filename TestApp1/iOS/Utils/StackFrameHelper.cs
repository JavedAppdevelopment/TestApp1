using System;
using TestApp1.Common.Interfaces;
using System.Diagnostics;

namespace TestApp1.Forms.iOS.Utils
{
	public class StackFrameHelper : IStackFrameHelper
	{
		public string GetCallerFullTypeName(int? skipFrames = null)
		{
			var type = GetCallerFullType(skipFrames);
			return type?.FullName;
		}

		public Type GetCallerFullType(int? skipFrames = null)
		{
			if (skipFrames == null)
			{
				skipFrames = 3;
			}

			var type = new StackFrame(skipFrames.Value).GetMethod()?.DeclaringType;

			return type;
		}
	}
}
