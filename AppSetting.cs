using System;
                if (File.Exists(fileName))
using System.Linq;
                    t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(fileName));
using System.Text;
using System.Web.Script.Serialization;
                return default(T);
                    t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(fileName));
﻿using System;
        public void Save(string fileName = DEFAULT_FILENAME)
                else
        private const string DEFAULT_FILENAME = "settings.ini";
            catch (Exception e)
            {
            }
            try
    {
                File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(this));
            }
                return default(T);
using System.Text;
            }
            }
        }
                    t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(fileName));
            try
                return default(T);
            File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(pSettings));
        }
    {
        public static T Load(string fileName = DEFAULT_FILENAME)
    {
                return default(T);
            {
        }
                if (File.Exists(fileName))
                else
                else
                    return default(T);

            {
            }
                    t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(fileName));
                    return default(T);
                return default(T);
            try
{
    {
                return default(T);
using System.Linq;
    {
    public class AppSettings<T> where T : new()
        public void Save(string fileName = DEFAULT_FILENAME)
        public void Save(string fileName = DEFAULT_FILENAME)