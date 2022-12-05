using System;
using System.Collections.Generic;

namespace Luxoft_task
{
    //isMirror is recursive function
    //it takes two trees, left and right as an argument
    //if trees are the mirror return true, otherwise false
    // the solution is based on simple if condition with the following 
    // - root node's key must be same so I check the values
    // - left subtree of left tree and right subtree of right tree should be mirrored
    // - right subtree of right tree and left subtree of left tree should be mirrored
    // 
    class Node
    {
        public Node leftN;
        public Node rightN;
        public int? theValue;
        public Node(int? value = null, Node left = null, Node right = null)
        {
            if (value == null) return;

            theValue = value;
            leftN = left;
            rightN = right;
        }
    }
    class NodeTree
    {
       public Node Root;
    }
    class Program
    {
        public static bool IsSymmetric(Node root = null)
        {
            return root == null ? false : IsMirror(root, root);
        }

        private static bool IsMirror(Node a, Node b)
        {
            if (a == null && b == null)            
                return true;            
            if (a == null || b == null)            
                return false;            

            return a.theValue == b.theValue &&
            IsMirror(a.leftN, b.rightN) &&
            IsMirror(a.rightN, b.leftN);
        }
     
        static void Main(string[] args)
        {
            // first
            NodeTree tree = new NodeTree();
            tree.Root = new Node(1);
            tree.Root.leftN = new Node(2);
            tree.Root.rightN = new Node(2);
            tree.Root.leftN.leftN = new Node(3);
            tree.Root.leftN.rightN = new Node(4);
            tree.Root.rightN.leftN = new Node(4);
            tree.Root.rightN.rightN = new Node(3);
            Console.WriteLine(IsSymmetric(tree.Root));

            // second
            tree.Root = new Node(1);
            tree.Root.leftN = new Node(2);
            tree.Root.rightN = new Node(2);
            tree.Root.leftN.leftN = new Node(null);
            tree.Root.leftN.rightN = new Node(3);
            tree.Root.rightN.leftN = new Node(null);
            tree.Root.rightN.rightN = new Node(3);
            Console.WriteLine(IsSymmetric(tree.Root));

            // third example check values
            tree.Root = new Node(1);
            tree.Root.leftN = new Node(2);
            tree.Root.rightN = new Node(2);
            tree.Root.leftN.leftN = new Node(10);
            tree.Root.leftN.rightN = new Node(11);
            tree.Root.rightN.leftN = new Node(11);
            tree.Root.rightN.rightN = new Node(9);
            Console.WriteLine(IsSymmetric(tree.Root));

            // 4th example check cells with null
            tree.Root = new Node(1);
            tree.Root.leftN = new Node(2);
            tree.Root.rightN = new Node(2);
            tree.Root.leftN.leftN = new Node(null);
            tree.Root.leftN.rightN = new Node(11);
            tree.Root.rightN.leftN = new Node(11);
            tree.Root.rightN.rightN = new Node(null);
            Console.WriteLine(IsSymmetric(tree.Root));

        }

    }
}
