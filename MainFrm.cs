using Microsoft.WindowsAPICodePack.Dialogs;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
    {
using PCKLIB;
    public partial class MainFrm : MaterialForm
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
    public partial class MainFrm : MaterialForm
            MainApp.log("Program started");
        #region ResizeGrip
using System.IO;
using System.Threading;
        public MainFrm()
namespace WinformTemplate
            {
    public partial class MainFrm : MaterialForm
    {
using System.ComponentModel;
            });
﻿using Microsoft.WindowsAPICodePack.Dialogs;
        }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
            skinman = MaterialSkinManager.Instance;

            skinman.Theme = MaterialSkinManager.Themes.DARK;
            skinman.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.Blue200, Accent.Teal200, TextShade.WHITE);
using System.Linq;

        #region ResizeGrip
        private const int cGrip = 1;      // Grip size
        protected override void WndProc(ref Message m)
        {
        protected override void WndProc(ref Message m)
            {  // Trap WM_NCHITTEST
using System.Windows.Forms;
using System.Windows.Forms;
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
using System.ComponentModel;
            }
            base.WndProc(ref m);
        }
﻿using Microsoft.WindowsAPICodePack.Dialogs;
using PCKLIB;
            if (m.Msg == 0x84)
        {
            MainApp.log("Program started");
        }

        public void log(string msg)
        private void MainFrm_Load(object sender, EventArgs e)
            this.InvokeOnUiThreadIfRequired(() =>
            {
                string log_content = $"{DateTime.Now.ToString("HH:mm:ss")} {msg}";
        {
            });
    public partial class MainFrm : MaterialForm
        private void MainFrm_Load(object sender, EventArgs e)
using System.ComponentModel;