using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLock
{

    public class hashLogClass
    {
        public static void checkdbFile()
        {
            if (System.IO.File.Exists("db/hashdb.csv"))
            {
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("db/hashdb.csv"))
                {
                    sw.WriteLine("fileName,hashType,hash,dateTime"+"\n");
                    checkdbFile();
                }
            }
        }
        public string writeToCSV(string fileName, string hashType, string hash, string dateTime)
        {
            if (System.IO.File.Exists("db/hashdb.csv"))
            {
                using (StreamWriter sw = new StreamWriter("db/hashdb.csv"))
                {
                    sw.WriteLine(fileName+","+hashType + "," + hash + "," + dateTime+"\n");
                    checkdbFile();
                }
            }
            return "unsuccess";
        }
        public string readCSV(string fileName, string hashType, string hash, string dateTime)
        {
            if (System.IO.File.Exists("db/hashdb.csv"))
            {
                using (StreamReader sr = new StreamReader("db/hashdb.csv"))
                {
                }
            }
            return "unsuccess";
        }
    }
}
