using Microsoft.WindowsAPICodePack.Dialogs;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
        {
        protected override void WndProc(ref Message m)
using PCKLIB;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
    {
using System.Threading;
    public partial class MainFrm : MaterialForm
        {
            base.WndProc(ref m);
using System.Threading;

        public MainFrm()
namespace WinformTemplate
            {
        protected override void WndProc(ref Message m)
    {
using System.ComponentModel;
using System.Collections.Generic;
﻿using Microsoft.WindowsAPICodePack.Dialogs;
        public MainFrm()
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
            skinman = MaterialSkinManager.Instance;
    {
            skinman.Theme = MaterialSkinManager.Themes.DARK;
        {
using System.Linq;

        #region ResizeGrip
            this.InvokeOnUiThreadIfRequired(() =>
        protected override void WndProc(ref Message m)
        {
        protected override void WndProc(ref Message m)
            {  // Trap WM_NCHITTEST
using System.Windows.Forms;
using System.Windows.Forms;
        protected override void WndProc(ref Message m)
                {
            this.InvokeOnUiThreadIfRequired(() =>
                    return;
using System.ComponentModel;
            }
            base.WndProc(ref m);
        }
﻿using Microsoft.WindowsAPICodePack.Dialogs;
            skinman = MaterialSkinManager.Instance;
            if (m.Msg == 0x84)
    {
            MainApp.log("Program started");
using System.ComponentModel;

        public void log(string msg)
        private void MainFrm_Load(object sender, EventArgs e)
            this.InvokeOnUiThreadIfRequired(() =>
            {
                string log_content = $"{DateTime.Now.ToString("HH:mm:ss")} {msg}";
using MaterialSkin.Controls;
            });
        {
        private void MainFrm_Load(object sender, EventArgs e)
using System.ComponentModel;