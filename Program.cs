using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringArrayDemo
{
    class Program
    {
	public static void Main(String[] args)
	{
            StreamReader input = new StreamReader("c:/tmp/all-names.txt");
	    SortedStringList sl = new SortedStringList(1000);

	    while (!input.EndOfStream)
	    {
		sl.Add(input.ReadLine());
	    }

            Console.WriteLine("Compares: {0}, Moves: {1}", sl.numCompares, sl.numMoves);
	    Console.Read();
        }
    }
}
