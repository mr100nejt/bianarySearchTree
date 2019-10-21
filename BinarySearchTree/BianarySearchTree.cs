using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BianarySearchTree
    {
        public Node insert(Node newNode,int data)
        {
            if(newNode == null)
            {
                 newNode = new Node();
                 newNode.data = data;
            }
            else if (data < newNode.data)
            {
                newNode.leftBranch = insert(newNode.leftBranch, data);
            }
            else 
            {
                newNode.rightBranch = insert(newNode.rightBranch, data);
            }
            return newNode;
        }
       public Node search(Node newNode, int data)
        {
            if( newNode== null)
            {
                return null;
            }


            if (newNode.data == data)
            {
                newNode.display(newNode);

                return newNode; 
            }
             if( data < newNode.data)
            {
                return search(newNode.leftBranch, data);
            }

            else
            {
                return search(newNode.rightBranch, data);
            }
               
        }

}
}
