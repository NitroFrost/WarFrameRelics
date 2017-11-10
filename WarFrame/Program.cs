/*
 * Created by NitroFrost
 * Version 1.01
 */
using System;
using System.Windows.Forms;

namespace WarFrame
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
