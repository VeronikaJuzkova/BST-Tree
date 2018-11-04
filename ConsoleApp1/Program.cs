using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Insert(5) ;
            tree.Insert(9) ;
            tree.Insert(3) ;
            tree.Search(9) ;
        }
    }
}
