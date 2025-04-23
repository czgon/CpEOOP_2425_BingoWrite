using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpEOOP_2425_BingoWrite
{
    internal class BINGOCard
    {
        private Number[,] _Card = new Number[5, 5];
        private IntList _nums = new IntList();

        public void Initialize()
        {
            _Card = new Number[5, 5];
            _nums = new IntList();

            for(int x = 1; x < 76; x++)
                _nums.AddToList(x);

            for (int x = 0; x < _Card.GetLength(0); x++)
            {
                for (int y = 0; y < _Card.GetLength(1); y++)
                {
                    _Card[x, y] = new Number();
                }
            }
        }

        public void GenerateCard()
        {
            _nums = new IntList();

            for (int x = 1; x < 76; x++)
                _nums.AddToList(x);

            for (int x = 0; x < _Card.GetLength(0); x++)
            {
                for (int y = 0; y < _Card.GetLength(1); y++)
                {
                    _Card[x, y].genNumber(y);
                    if (_nums.ValueContain(_Card[x, y].getNumber()))
                        _nums.RemoveValue(_Card[x, y].getNumber());
                    else
                        y--;
                }
            }
        }

        public void Display()
        {
            for(int x = 0; x < _Card.GetLength(0); x++)
            {
                for(int y = 0;  y < _Card.GetLength(1); y++)
                {
                    Console.Write($"{_Card[x,y].getNumber()}\t");
                }
                Console.WriteLine();
            }
        }

        public MyList Stringify()
        {
            MyList list = new MyList();
            string temp = "";
            list.AddToList("B\tI\tN\tG\tO");
            for (int x = 0; x < _Card.GetLength(0); x++)
            {
                for (int y = 0; y < _Card.GetLength(1); y++)
                {
                    temp += $"{_Card[x, y].getNumber()}\t";
                    //Console.Write($"{_Card[x, y].getNumber()}\t");
                }
                //Console.WriteLine();
                list.AddToList(temp);
                temp = "";
            }
            return list;
        }
    }
}
