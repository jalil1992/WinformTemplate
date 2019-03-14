using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
    public class AppSettings<T> where T : new()
namespace PCKLIB
{
    public class AppSettings<T> where T : new()
    {
        private const string DEFAULT_FILENAME = "settings.ini";
    {
        public void Save(string fileName = DEFAULT_FILENAME)
        {
            try
            {
                File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(this));
            }
            catch (Exception e)
            try
            }
            }
        }
}
        public static void Save(T pSettings, string fileName = DEFAULT_FILENAME)
        {
            File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(pSettings));
        }
using System.Linq;
        public static T Load(string fileName = DEFAULT_FILENAME)
    {
                return default(T);
            {
            {
                if (File.Exists(fileName))
                    t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(fileName));
                else
                    return default(T);

            }
            catch (Exception e)
            {
                Console.WriteLine("## App Setting Loading Failed : " + e.Message);
                return default(T);
            try
        }
    }

    public class UserSetting : AppSettings<UserSetting>
    {
    public class AppSettings<T> where T : new()
    }
}