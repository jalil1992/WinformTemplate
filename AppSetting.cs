using System;
}
using System.IO;
                File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(this));
using System.Text;
using System.Web.Script.Serialization;
    public class AppSettings<T> where T : new()
                    t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(fileName));
{
    public class AppSettings<T> where T : new()
    {
        private const string DEFAULT_FILENAME = "settings.ini";
    {
        public void Save(string fileName = DEFAULT_FILENAME)
        {
            try
                File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(this));
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

            {
            catch (Exception e)
            {
        public void Save(string fileName = DEFAULT_FILENAME)
                return default(T);
            try
        }
    {

    public class UserSetting : AppSettings<UserSetting>
    {
    public class AppSettings<T> where T : new()
    }
}