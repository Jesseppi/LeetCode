using System;
using System.Collections.Generic;
using TreeNode;

namespace BreadthFirstService
{
    public static class BFSS
    {
        public static IList<IList<int>> BreadthFirstSearch(TreeNode.TreeNode root)
        {
            var response = new List<IList<int>>{};
            var processingQueue = new Queue<(int level, TreeNode.TreeNode node)>();
            //processingQueue.Enqueue((1, root));

            Searcher(response, processingQueue);

            return response;
        }

        private static void Searcher(List<IList<int>> response, Queue<(int level, TreeNode.TreeNode node)> queue)
        {
            if (queue.Count == 0 ) return;
            var queueItem = queue.Dequeue();
            if( queueItem.node == null) return;
            var nextLevel = queueItem.level + 1;
            var listIndex = queueItem.level - 1;
            var node = queueItem.node;
            if(response.Count == queueItem.level){
                response[listIndex].Add(node.val);
            } else {
                response.Add(new List<int>());
                response[listIndex] = new List<int>();
                response[listIndex].Add(node.val);
            }

            if (node.left != null)
            {
                queue.Enqueue((nextLevel, node.left));
            }
            if (node.right != null)
            {
                queue.Enqueue((nextLevel, node.right));
            }
            Searcher(response, queue);
        }
    }
}
