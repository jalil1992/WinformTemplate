using System;
                if (File.Exists(fileName))
using System.IO;
                File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(this));
using System.Text;
using System.Web.Script.Serialization;
                return default(T);
                    t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(fileName));
{
    public class AppSettings<T> where T : new()
    {
        private const string DEFAULT_FILENAME = "settings.ini";
    {
            {
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
            try
                return default(T);
            File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(pSettings));
        }
using System.Linq;
        public static T Load(string fileName = DEFAULT_FILENAME)
    {
                return default(T);
            {
        }
                if (File.Exists(fileName))
        public static void Save(T pSettings, string fileName = DEFAULT_FILENAME)
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

using System.Linq;
    {
    public class AppSettings<T> where T : new()
    }
        public void Save(string fileName = DEFAULT_FILENAME)