using PCKLIB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformTemplate
{
    static class MainApp
    {
        public static MainFrm g_main_frm;
        public static object g_locker = new object();
        public static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static UserSetting g_setting;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            g_main_frm = new MainFrm();
            Application.Run(g_main_frm);
        }

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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void load_setting()
        {
            g_setting = UserSetting.Load();
            if(g_setting == null)
            {
                g_setting = new UserSetting();
            }
        }

        public static void save_setting()
        {
            g_setting.Save();
        }
    }
}
