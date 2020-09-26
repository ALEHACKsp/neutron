using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Funerals.ProjectUtilities
{
	// Token: 0x02000002 RID: 2
	internal class MinMemory
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00002050
		private static void MinMem(string[] args)
		{
			MinMemory.minimizeMemory();
			Console.ReadLine();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000205F File Offset: 0x0000205F
		public static void minimizeMemory()
		{
			GC.Collect(GC.MaxGeneration);
			GC.WaitForPendingFinalizers();
			MinMemory.SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, (UIntPtr)uint.MaxValue, (UIntPtr)uint.MaxValue);
		}

		// Token: 0x06000003 RID: 3
		[DllImport("kernel32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool SetProcessWorkingSetSize(IntPtr process, UIntPtr minimumWorkingSetSize, UIntPtr maximumWorkingSetSize);

		// Token: 0x06000004 RID: 4 RVA: 0x0000208F File Offset: 0x0000208F
		public static void memory()
		{
			MessageBox.Show("Imagine Using Internal Memory");
		}
	}
}
