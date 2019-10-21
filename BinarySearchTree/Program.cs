using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BianarySearchTree BT = new BianarySearchTree();
            Node newNode = new Node();
            BT.insert(newNode, 2);
            BT.insert(newNode, 3);
            BT.insert(newNode, 1);
            Node searchResult = BT.search(newNode, 2);
        }
    }
}
