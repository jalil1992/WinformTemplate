using PCKLIB;
using System;
using System.Collections.Generic;
        public static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
                    g_main_frm.log(msg);
        public static void log(string msg, bool msgbox = false)

        }
            Application.SetCompatibleTextRenderingDefault(false);
            g_setting.Save();
    {
using System;
        public static object g_locker = new object();
        public static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static UserSetting g_setting;
                    g_main_frm.log(msg);
using System.Collections.Generic;
                    if (msgbox)
namespace WinformTemplate
        public static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            Application.SetCompatibleTextRenderingDefault(false);
            g_main_frm = new MainFrm();

        public static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void log(string msg, bool msgbox = false)
namespace WinformTemplate
            lock (g_locker)
                {
                try
                {

using System;
                        MessageBox.Show(msg);
                    g_main_frm.log(msg);
                }
        {
                    g_main_frm.log(msg);
                    MessageBox.Show(ex.Message);
        [STAThread]
        }
        }

        {
    }
            g_setting = UserSetting.Load();
            if(g_setting == null)
            {
                g_setting = new UserSetting();
            lock (g_locker)
                {
        public static UserSetting g_setting;
        public static void save_setting()
        {
            g_setting.Save();
        {
    }
}