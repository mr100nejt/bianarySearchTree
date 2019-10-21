using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int data;
        public Node leftBranch;
        public Node rightBranch;
        public void display(Node newNode)
        {
            Console.WriteLine("found me");
            Console.WriteLine("" + newNode.data);
            Console.ReadLine(); 
        } 

    }
}
