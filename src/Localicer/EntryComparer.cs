using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace Localicer
{
    class EntryComparer : IComparer
    {
        SortOrder _Order;

        public EntryComparer(SortOrder order)
        {
            _Order = order;
            Console.WriteLine(_Order.ToString());
        }

        public int Compare(object x, object y)
        {
            Console.WriteLine("bruh");
            Console.WriteLine(x.ToString() + " | " + (uint)y);
            return -1;
            // perform you desired comparison depending on the _Order
        }
    }
}
