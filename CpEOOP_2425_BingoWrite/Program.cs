using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpEOOP_2425_BingoWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BINGOCard bc = new BINGOCard();
            FileManager fm = new FileManager();
            bc.Initialize();
            bc.GenerateCard();
            bc.Display();

            fm.FileWrite("Bingo.txt",bc.Stringify());

        }
    }
}
