using System;
using System.Collections.Generic;
using TreeNode;

namespace postOrderTraversal
{

    public static class Solution
    {
        public static IList<int> PostOrderTraversal(TreeNode.TreeNode root)
        {
            var response = new List<int>();
            var processingStack = new Stack<TreeNode.TreeNode>();
            processingStack.Push(root);

            traverser(response,processingStack);

            return response;
        }

        public static void traverser(List<int> response, Stack<TreeNode.TreeNode> stack)
        {
            var node = stack.Pop();

            if(node.left != null){
                stack.Push(node.left);
                traverser(response,stack);
            }
            if(node.right != null){
                stack.Push(node.right);
                traverser(response,stack);
            }
            response.Add(node.val);
            return;
        }
    }
}
