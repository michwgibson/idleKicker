using System;
using System.Windows.Forms;
using Utilities;
using System.Timers;

namespace idleKicker {
	public partial class Form1 : Form {
        const int TimeOutDurration = 20 * 60 * 1000; //Currently 20 minutes in miliseconds


        globalInputHook gkh = new globalInputHook();
        System.Timers.Timer timer = new System.Timers.Timer();
             
		public Form1() {
			InitializeComponent();
            timer.Elapsed += new ElapsedEventHandler(TimeOut);
            timer.Interval = TimeOutDurration;
        }

        /// <summary>
        /// On load: Register input handler, start timer, hide window
        /// </summary>

        private void Form1_Load(object sender, EventArgs e) {
			gkh.inputHandler += new EventHandler(input);
            timer.Enabled = true;
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.
        }

        /// <summary>
        /// Call back from GIH indicating an user input event has occured, Resets timer interval
        /// </summary>
        void input(object sender, EventArgs e) {
            timer.Interval = TimeOutDurration;
        }

        /// <summary>
        /// Call back from GIH indicating an user input event has occured, Resets timer interval
        /// </summary>

        private static void TimeOut(object source, ElapsedEventArgs e)
        {
            string filename = "C://Program Files (x86)//BYU CAEDM//Install CAEDM Signout//Sign out.exe";
            var proc = System.Diagnostics.Process.Start(filename, "/s");
        }
    }
}