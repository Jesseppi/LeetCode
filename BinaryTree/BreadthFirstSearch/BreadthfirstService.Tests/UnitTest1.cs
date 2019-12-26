using System;
using System.Collections.Generic;
using Xunit;

namespace BreadthfirstService.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var node4 = new TreeNode.TreeNode(4);
            var node2 = new TreeNode.TreeNode(2);
            var node3 = new TreeNode.TreeNode(3);
            var node1 = new TreeNode.TreeNode(1);
            var node6 = new TreeNode.TreeNode(6);
            var node5 = new TreeNode.TreeNode(5);
            var node7 = new TreeNode.TreeNode(7);

            node2.left = node1;
            node2.right = node3;
            node4.left = node2;
            node6.left = node5;
            node6.right = node7;
            node4.right = node6;

            var response = BreadthFirstService.BFSS.BreadthFirstSearch(node4);

            var expected = new List<List<int>> {
                new List<int> {4},
                new List<int> {2,6},
                new List<int> {1,3,5,7}};
            Assert.Equal(response, expected);
        }
    }
}
