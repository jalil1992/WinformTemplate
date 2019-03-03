using PCKLIB;
using System;
using System.Collections.Generic;
        public static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
using System.Threading.Tasks;
        public static void log(string msg, bool msgbox = false)
            lock (g_locker)
namespace WinformTemplate
{
    static class MainApp
    {
        public static MainFrm g_main_frm;
        public static object g_locker = new object();
        public static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static UserSetting g_setting;
                    g_main_frm.log(msg);
using System.Collections.Generic;
        static void Main()
namespace WinformTemplate
        public static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            Application.SetCompatibleTextRenderingDefault(false);
            g_main_frm = new MainFrm();
            Application.Run(g_main_frm);
        }
        {
        public static void log(string msg, bool msgbox = false)
        {
            lock (g_locker)
            {
                try
                {
                    logger.Error(msg);
                    if (msgbox)
                        MessageBox.Show(msg);
                    g_main_frm.log(msg);
                }
                    if (msgbox)
                    g_main_frm.log(msg);
                    MessageBox.Show(ex.Message);
        [STAThread]
        public static void log(string msg, bool msgbox = false)
        }

        public static void load_setting()
        {
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