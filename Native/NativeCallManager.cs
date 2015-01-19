using System;
using System.Runtime.InteropServices;

namespace Native
{
	public class NativeCallManager
	{
		[DllImport("__Internal", EntryPoint="TestMethod")]
		public extern static int TestMethod(int number);
	}
}

