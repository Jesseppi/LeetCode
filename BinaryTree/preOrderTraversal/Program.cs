using System;
using System.Collections.Generic;

namespace preOrderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var node4 = new TreeNode(4);
            var node2 = new TreeNode(2);
            var node3 = new TreeNode(3);
            var node1 = new TreeNode(1);
            var node6 = new TreeNode(6);
            var node5 = new TreeNode(5);
            var node7 = new TreeNode(7);

            node2.left = node1;
            node2.right = node3;
            node4.left = node2;
            node6.left = node5;
            node6.right = node7;
            node4.right = node6;

            var response = Solution.PreOrderTraversal(node4);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int x) { val = x; }
        }

        public static class Solution
        {
            public static IList<int> PreOrderTraversal(TreeNode root)
            {

                var response = new List<int>();
                var stack = new Stack<TreeNode>();

                if (root == null) return response;

                stack.Push(root);
                while (stack.Count != 0)
                {

                    var node = stack.Pop();
                    response.Add(node.val);

                    if (node.right != null)
                    {
                        stack.Push(node.right);
                    }
                    if (node.left != null)
                    {
                        stack.Push(node.left);
                    }
                }

                return response;
            }
        }
    }
}
