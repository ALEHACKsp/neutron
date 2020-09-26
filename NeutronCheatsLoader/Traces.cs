using System;
using System.Diagnostics;

namespace NeutronCheatsLoader
{
	// Token: 0x02000006 RID: 6
	internal class Traces
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00003800 File Offset: 0x00003800
		public static void trace()
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.StandardInput.WriteLine("taskkill /f /im UnrealCEFSubProcess.exe");
			process.StandardInput.WriteLine("taskkill /f /im CEFProcess.exe");
			process.StandardInput.WriteLine("taskkill /f /im EasyAntiCheat.exe");
			process.StandardInput.WriteLine("taskkill /f /im BEService.exe");
			process.StandardInput.WriteLine("taskkill /f /im BEServices.exe");
			process.StandardInput.WriteLine("taskkill /f /im BattleEye.exe");
			process.StandardInput.WriteLine("taskkill /f /im epicgameslauncher.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_BE.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteLauncher.exe");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware\\Profiles\\0001 \\v HwProfileGuid \\t REG_SZ \\d {%08x-%04x-%04x-%04x-%04x%08x} /f");
			process.StandardInput.WriteLine("exit");
		}
	}
}
