using System;
using System.Globalization;
using System.Linq;

namespace ThunderMain.Text
{
	static class EchoA
	{
		static void Main(string[] args)
		{
			if (args.Length > 0 && args[0].Length == 5 && args[0].StartsWith("/A:"))
			{
				string hexDigits = "abcdef0123456789";

				if (hexDigits.Contains(char.ToLower(args[0][3])) && hexDigits.Contains(char.ToLower(args[0][4])))
				{
					Console.BackgroundColor = (ConsoleColor)int.Parse(args[0].Substring(3, 1), NumberStyles.HexNumber);
					Console.ForegroundColor = (ConsoleColor)int.Parse(args[0].Substring(4, 1), NumberStyles.HexNumber);
					args = args.Skip(1).ToArray();
				}
			}

			Console.Write(string.Join(" ", args));
			Console.ResetColor();
		}
	}
}