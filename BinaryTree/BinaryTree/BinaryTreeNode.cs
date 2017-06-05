using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTreeNode
    {
        public object Data;
        public BinaryTreeNode left;
        public BinaryTreeNode right;
        public BinaryTreeNode(object data)
        {
            this.Data = data;
            left = null;
            right = null;
        }
    }
}
