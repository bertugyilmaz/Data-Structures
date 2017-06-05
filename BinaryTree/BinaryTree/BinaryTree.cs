using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree
    {
        private BinaryTreeNode root;
        private string nodes;

        public BinaryTree(BinaryTreeNode root)
        {
            this.root = root;
        }
        public int DugumSayisi(BinaryTreeNode Node)
        {
            int count = 0;
            if (Node != null)
            {
                count = 1;
                count += DugumSayisi(Node.left);
                count += DugumSayisi(Node.right);
            }
            return count;
        }
        public int DugumSayisi()
        {
            return DugumSayisi(root);
        }
        public int YaprakSayisi(BinaryTreeNode Node)
        {           
            int count = 0;                                          
            if (Node != null)
            {
                if ((Node.left == null) && (Node.right == null))
                    count = 1;
                else
                    count += YaprakSayisi(Node.left) + YaprakSayisi(Node.right);
            }
            return count;
        }
        public int YaprakSayisi()
        {
            return YaprakSayisi(root);
        }
        public string nodesiYazdir()
        {
            return nodes;
        }
        //Gezinme İşlemleri
        public void PreOrder()                          // PreOrder: Önce kök, sonra sol alt ağaç ve ardından sağ alt ağaç
        {
            nodes = "";
            PreOrderInt(root);
        }
        private void PreOrderInt(BinaryTreeNode dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.left);
            PreOrderInt(dugum.right);
        }
        public void InOrder()                           // InOrder: Önce sol alt ağaç, kök ve sağ alt ağaç
        {
            nodes = "";
            InOrderInt(root);
        }
        private void InOrderInt(BinaryTreeNode dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.left);
            Ziyaret(dugum);
            InOrderInt(dugum.right);
        }
        private void Ziyaret(BinaryTreeNode dugum)
        {
            nodes += dugum.Data + " ";
        }
        public void PostOrder()                         // PostOrder: Önce sol alt ağaç, sağ alt ağaç ve kök.
        {
            nodes = "";
            PostOrderInt(root);
        }
        private void PostOrderInt(BinaryTreeNode dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.left);
            PostOrderInt(dugum.right);
            Ziyaret(dugum);
        }

    }
}
