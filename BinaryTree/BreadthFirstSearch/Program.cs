using System;
using System.Collections.Generic;
using TreeNode;

namespace BreadthFirstSearch
{
    public static class Solution
    {
        public static IList<IList<int>> BreadthFirstSearch(TreeNode.TreeNode root)
        {
            var response = new List<IList<int>>();
            var processingQueue = new Queue<(int level, TreeNode.TreeNode node)>();
            processingQueue.Enqueue((0,root));

            Searcher(response, processingQueue);

            return response;
        }

        public static void Searcher(List<IList<int>> response, Queue<(int level,TreeNode.TreeNode node)> queue){
            if(queue.Count == 0) return;
            var queueItem = queue.Dequeue();
            var nextLevel = queueItem.level + 1;
            var node = queueItem.node;
            response[queueItem.level].Add(node.val);
            if(node.left != null){
                queue.Enqueue((nextLevel,node.left));
            }
            if (node.right != null)
            {
                queue.Enqueue((nextLevel,node.right));
            }
            Searcher(response,queue);
        }
    }
}
