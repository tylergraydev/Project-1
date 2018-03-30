using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayDemo
{
    public class SortedStringList : StringList
    {
        private int capacity;
	    private String[] array;
	    private int count;
	    public int numCompares { get; private set; }
    	public int numMoves { get; private set; }

    	public int Count
	    {
	      get { return count; }
	    }
    
	    public SortedStringList(int initialCapacity)
        {
            capacity = initialCapacity;
            array = new String[capacity];
        }

	    public void Insert(int index, String element)
	    {
            //TODO
            int arrayLength = count;
            String temp = array[index];
            array[index] = element;
            numMoves++;
            for (int i = index + 1; i <= count + 1; i++)
            {
                String temp = array[i];
                array[i + 1] = temp;
                numMoves++;
            }

        }

    	public String RemoveAt(int index)
	    {
            //TODO
            int arrayLength = array.Length();
            for(int i = index + 1; 1< arrayLength; i++)
            {
                array[i] = array[i + 1];
            }
            array[arrayLength] = "";

	    return default(String);
	    }

    	public String ElementAt(int index)
	    {
	    if (index < count)
	    {
		return array[index];
	    }

	    return default(String);
	    }

    	public void Add(String element)
	    {
	    array[count] = element;
	    count++;
            BubbleSort();
	    }

    	public bool Remove(String element)
	    {
            for (int i = 0; i < array.Length(); i++)
            {
                if (array[i] = element)
                {
                    array[i] = "";
                    BubbleSort();
                    return true;
                }

            }
            return false;
	    }

    	public bool Contains(String element)
    	{
	        for(int i = 0; i < array.Length(); i++)
            {
                if (array[i] = element)
                {
                    return true;
                }
                
            }
            return false;
	    }

    	public int IndexOf(String target)
	{
            int loc = -1;
	    for (int i = 0; i < Count; i++)
	    {
		if (target.Equals(array[i]))
		{
		    loc = i;
		    i = Count;  // early exit from loop
		}
	    }
            return loc;
	}

    	public bool IsEmpty()
	{
            return (count == 0);
	}

    	public void Clear()
	    {
            count = 0;
            numCompares = 0;
            numMoves = 0;
            temp = new String[count];
            array = temp;
	    }

	public int BinarySearch(String target)
        {
            int min = 0;
            int max = Count - 1;
            bool found = false;
            int middle = 0;

            while (!found && min <= max)
            {
                middle = (min + max) / 2;

                int relationship = ((IComparable)target).CompareTo(array[middle]);
                if (relationship < 0)
                    max = middle - 1;
                else if (relationship > 0)
                    min = middle + 1;
                else
                    found = true;
            }

            if (!found)
            {
                middle = -1;
            }

            return middle;
        }

        public void BubbleSort()
        {
            int lastSwap = Count - 1;
            while (lastSwap != 0)
            {
                int comparisonsToMake = lastSwap;
                lastSwap = 0;
                for (int j = 0; j < comparisonsToMake; j++)
                {
                    numCompares++;
                    if (((IComparable)array[j]).CompareTo(array[j + 1]) > 0)
                    {
                        String tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                        lastSwap = j;
                        numMoves+=2;
                    }
                }
            }
        }

    }
}
