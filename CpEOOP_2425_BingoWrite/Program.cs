using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpEOOP_2425_BingoWrite
{
    internal class Program
    {

        //NumAsker
        static void NumAsker(out int num)
        {

            while (true) // ask until valid
            {
                Console.Write("Enter number: ");
                int.TryParse(Console.ReadLine(), out num);
                if (num > 0)
                {
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of cards:");
            NumAsker(out int num);
            BINGOCard[] cards = new BINGOCard[num];

            FileManager fm = new FileManager();

            for (int x = 0; x < cards.Length; x++)
            {
                cards[x] = new BINGOCard();
                cards[x].Initialize();
                cards[x].GenerateCard();

                //FileWrite - file write the bingo cards
                fm.FileWrite($"C:\\Users\\24-0315c\\Downloads\\BingoCard{x + 1}.csv", cards[x].Stringify(), false);

                Console.WriteLine($"Generated Bingo Card #{x + 1}");
                cards[x].Display();

            }
        }
    }
}

