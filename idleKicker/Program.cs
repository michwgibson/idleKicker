using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace idleKicker {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new Form1());
		}
	}
}