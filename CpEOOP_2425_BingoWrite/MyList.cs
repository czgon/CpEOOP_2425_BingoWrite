using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpEOOP_2425_BingoWrite
{
    internal class MyList
    {
        private string[] things = { };

        public void AddToList(string value)
        {
            string[] newArr = new string[things.Length + 1];

            for (int x = 0; x < things.Length; x++)
                newArr[x] = things[x];

            newArr[newArr.Length - 1] = value;

            things = newArr;
        }

        public string[] getArray()
        {
            return things;
        }

        public bool ValueContain(string value)
        {
            foreach (string a in things)
                if (a == value)
                    return true;

            return false;
        }

        public int FindValue(string value)
        {
            for (int x = 0; x < things.Length; x++)
                if (things[x] == value)
                    return x;

            return -1;
        }

        public void RemoveValue(string value)
        {
            int indexToRemove = FindValue(value);

            RemoveIndex(indexToRemove);
        }

        public void RemoveIndex(int index)
        {
            string[] newArr = new string[things.Length - 1];

            for (int x = 0; x < index; x++)
                newArr[x] = things[x];

            for (int x = index + 1; x < things.Length; x++)
                newArr[x - 1] = things[x];

            things = newArr;
        }

        public void RemoveAllValue(string value)
        {
            while (ValueContain(value))
                RemoveValue(value);
        }

        public string[] GetList()
        {
            return things;
        }
    }
}
