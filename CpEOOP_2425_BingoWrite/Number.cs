using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpEOOP_2425_BingoWrite
{
    internal class Number
    {
        private int _num = -1;

        public void genNumber(int col)
        {
            _num = Globals._rnd.Next(1, 16) + (col * 15);
        }

        public int getNumber() { return _num; }
    }
}
