using System;
using System.IO;

namespace SaveManager
{
    public class SaveManager
    {
        public string SaveData;

        public void AddKey(string keyname, int keyvalue)
        {
            SaveData = SaveData + keyname + "=" + keyvalue + Environment.NewLine;
        }

        public void AddKey(string keyname, float keyvalue)
        {
            SaveData = SaveData + keyname + "=" + keyvalue + Environment.NewLine;
        }

        public void AddKey(string keyname, double keyvalue)
        {
            SaveData = SaveData + keyname + "=" + keyvalue + Environment.NewLine;
        }

        public void AddKey(string keyname, bool keyvalue)
        {
            SaveData = SaveData + keyname + "=" + keyvalue + Environment.NewLine;
        }

        public void AddKey(string keyname, string keyvalue)
        {
            SaveData = SaveData + keyname + "=" + keyvalue + Environment.NewLine;
        }

        public string GetKey(string keyname)
        {
            StringReader sr = new StringReader(SaveData);
            string line;
            while (sr.Peek() != -1)
            {
                line = sr.ReadLine();
                if (line.StartsWith(keyname + "="))
                {
                    string keyvalue = line.Replace(keyname + "=", "");
                    return keyvalue;
                }
            }
            sr.Close();
            return null;
        }

        public bool GetKey_bool(string keyname)
        {
            StringReader sr = new StringReader(SaveData);
            string line;
            while (sr.Peek() != -1)
            {
                line = sr.ReadLine();
                if (line.StartsWith(keyname + "="))
                {
                    bool keyvalue = Convert.ToBoolean(line.Replace(keyname + "=", ""));
                    return keyvalue;
                }
            }
            sr.Close();
            return false;
        }

        public int GetKey_int(string keyname)
        {
            StringReader sr = new StringReader(SaveData);
            string line;
            while (sr.Peek() != -1)
            {
                line = sr.ReadLine();
                if (line.StartsWith(keyname + "="))
                {
                    int keyvalue = Convert.ToInt32(line.Replace(keyname + "=", ""));
                    return keyvalue;
                }
            }
            sr.Close();
            return -1;
        }

        public double GetKey_double(string keyname)
        {
            StringReader sr = new StringReader(SaveData);
            string line;
            while (sr.Peek() != -1)
            {
                line = sr.ReadLine();
                if (line.StartsWith(keyname + "="))
                {
                    double keyvalue = Convert.ToDouble(line.Replace(keyname + "=", ""));
                    return keyvalue;
                }
            }
            sr.Close();
            return -1;
        }

        public float GetKey_float(string keyname)
        {
            StringReader sr = new StringReader(SaveData);
            string line;
            while (sr.Peek() != -1)
            {
                line = sr.ReadLine();
                if (line.StartsWith(keyname + "="))
                {
                    float keyvalue = Convert.ToSingle(line.Replace(keyname + "=", ""));
                    return keyvalue;
                }
            }
            sr.Close();
            return -1;
        }

        public void Clear_Data() // This will clear the temporary data.
        {
            SaveData = "";
        }

        public void Read_Data(string path)
        {
            SaveData = "";
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line;

            while (sr.Peek() != -1)
            {
                line = sr.ReadLine();
                SaveData = SaveData + line + Environment.NewLine;
            }
            sr.Close();
        }

        public void Save_Data(string path)
        {
            File.WriteAllText(path, SaveData);
        }

        public void Delete_Data(string path)
        {
            File.Delete(path);
        }
    }
}
