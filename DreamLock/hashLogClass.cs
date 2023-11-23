using System;
using System.Collections.Generic;
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
                    sw.WriteLine("fileName,hashType,hash,dateTime");
                    checkdbFile();
                }
            }
        }
        public string writeToCSV(string fileName, string hashType, string hash, string dateTime)
        {

            return null;
        }
        public string readCSV(string fileName, string hashType, string hash, string dateTime)
        {
            if (System.IO.File.Exists("db/hashdb.csv"))
            {
                using (StreamReader sr = new StreamReader("db/hashdb.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        string satir = sr.ReadLine();
                        string[] veri = satir.Split(',');
                        foreach (string deger in veri)
                        {
                            Console.Write(deger + " ");
                        }
                    }
                }
            }
            return null;
        }
    }
}
