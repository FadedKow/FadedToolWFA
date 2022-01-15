using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Memory;
using FadedToolWFA;

namespace FadedToolWFA.Utils
{
    public class utils
    {

		public void ReattachProcess()
        {
			Mem m = new Mem();
			try
			{
				Program.proc = Process.GetProcessesByName("Minecraft.Windows")[0];
			}
			catch
			{
				Console.WriteLine("Game wasn't found running");
			}
			if (!m.OpenProcess("Minecraft.Windows"))
			{
				Console.WriteLine("Failed to attach to process. \nPossible reasons:\nYou aren't running as administrator\nMinecraft is in out of focused mode\nCan't attach");
			}

		}

		public void ChangeIdRandom(String staticPtr)
		{
			Mem m = new Mem();
			ReattachProcess();
			Guid newGuid = Guid.NewGuid();
			string myNewUuid = newGuid.ToString();
			if (m.OpenProcess("Minecraft.Windows"))
			{
				if (staticPtr == "") return;
				m.WriteMemory("base+" + staticPtr, "string", myNewUuid, "", null, true);
			}
		}

		public void ChangeIdCustom(String staticPtr, String custId)
		{
			Mem m = new Mem();
			ReattachProcess();
			if (m.OpenProcess("Minecraft.Windows"))
			{
				if (staticPtr == "") return;
				m.WriteMemory("base+" + staticPtr, "string", custId, "", null, true);
			}
		}

		public void ChangeMCIDRandom(String staticPtr)
		{
			Mem m = new Mem();
			ReattachProcess();
			if (m.OpenProcess("Minecraft.Windows"))
			{
				if (staticPtr == "") return;
				m.WriteMemory("base+" + staticPtr, "string", RandomString(16), "", null, true);
			}
		}

		public string RandomString(int length)
		{
			//use 16 for MCID
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

			var random = new Random();
			var randomString = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
			return randomString;
		}

		public int Rand(int min, int max)
		{
			Random random = new Random();
			return random.Next(min, max);
		}

	}
}
