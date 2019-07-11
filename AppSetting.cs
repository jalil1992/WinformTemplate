using System;
                if (File.Exists(fileName))
using System.Linq;
                    t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(fileName));
using System.Text;
using System.Web.Script.Serialization;


            try
        public void Save(string fileName = DEFAULT_FILENAME)
                else
        private const string DEFAULT_FILENAME = "settings.ini";
            catch (Exception e)
            {
            }
            try
    {
                File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(this));

                return default(T);
using System.Text;
            }
            }
                    t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(fileName));
                    t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(fileName));
                else
                else
            File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(pSettings));
        }

            {
    {
                return default(T);
            {
        }
                if (File.Exists(fileName))
                else
                else
                    return default(T);
﻿using System;
            {
            }
                    t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(fileName));
                    return default(T);
                return default(T);
            try

    {
                return default(T);
                return default(T);
                return default(T);
    public class AppSettings<T> where T : new()
        public void Save(string fileName = DEFAULT_FILENAME)
        public void Save(string fileName = DEFAULT_FILENAME)