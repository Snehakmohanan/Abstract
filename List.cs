using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracttest1
{
    abstract class List
    {
        public abstract void search(string name);
        public abstract void printList(string[] list);
        public List()
        {

        }
    }
}
