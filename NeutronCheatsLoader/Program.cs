﻿using System;
using System.Windows.Forms;

namespace NeutronCheatsLoader
{
	// Token: 0x02000005 RID: 5
	internal static class Program
	{
		// Token: 0x06000026 RID: 38 RVA: 0x000037E3 File Offset: 0x000037E3
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
