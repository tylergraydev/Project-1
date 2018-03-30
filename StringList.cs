using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayDemo
{
    interface StringList
    {
        int Count { get; }
        void Insert(int index, String element);
        String RemoveAt(int index);			// delete
        String ElementAt(int index);			// get

        void Set(int index, String element);		// set
	    void Add(String element);			// insert
        bool Remove(String element);
        bool Contains(String element);
        int IndexOf(String element);
        bool IsEmpty();
        void Clear();
    }

}
