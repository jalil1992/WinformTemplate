using Microsoft.WindowsAPICodePack.Dialogs;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;

using PCKLIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WinformTemplate
{
    public partial class MainFrm : MaterialForm
    {
        MaterialSkinManager skinman;
        public MainFrm()
        {
            InitializeComponent();

            skinman = MaterialSkinManager.Instance;
            skinman.AddFormToManage(this);
            skinman.Theme = MaterialSkinManager.Themes.DARK;
            skinman.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.Blue200, Accent.Teal200, TextShade.WHITE);
        }

        #region ResizeGrip
        private const int cGrip = 1;      // Grip size
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion

        private void MainFrm_Load(object sender, EventArgs e)
        {
            MainApp.log("Program started");
        }

        public void log(string msg)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                string log_content = $"{DateTime.Now.ToString("HH:mm:ss")} {msg}";
                lab_status.Text = log_content;
            });
        }
    }
}
