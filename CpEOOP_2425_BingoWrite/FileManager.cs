using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpEOOP_2425_BingoWrite
{
    internal class FileManager
    {
        public void FileWrite(string path, MyList message, bool append=true)
        {
            using (StreamWriter sw = new StreamWriter(path, append))
            {
                foreach(string m in message.GetList())
                    sw.WriteLine(m);
            }
        }

        public int FileRead(string path, out MyList lines, out string message)
        {
            int error = 0;
            lines = new MyList();

            if (File.Exists(path))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string line = "";
                        while ((line = sr.ReadLine()) != null)
                        {
                            lines.AddToList(line);
                        }
                    }
                    message = "No error encountered";
                }
                catch (Exception e)
                {
                    error = 1;
                    message = e.Message;
                }
            }
            else
            {
                error = 2;
                message = "File does not exist!";
            }

            return error;
        }
    }
}
