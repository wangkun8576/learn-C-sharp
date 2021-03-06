using System;
using Xunit;
using Trees;
using System.Collections.Generic;

namespace TreeTests
{
    public class BinarySearchTreeTest
    {
        [Fact]
        public void BinarySearchTreeTestInsert()
        {
            int[] dataItems = {
                8, 6, 7, 5, 1, 3, 9, 4, 0, 2
            };

            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Insert(dataItems);

            int[] inorderItemsArray = tree.ToArray();

            int[] inorderItemsArrayCorrect = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Assert.Equal(inorderItemsArray, inorderItemsArrayCorrect);
        }

        [Fact]
        public void BinarySearchTreeTestRemove()
        {
            int[] dataItems = {
                8, 6, 7, 5, 1, 3, 9, 4, 0, 2
            };

            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Insert(dataItems);

            tree.Remove(3);
            tree.Remove(7);
            tree.Remove(0);

            int[] inorderItemsArray = tree.ToArray();

            int[] inorderItemsArrayCorrect = {1, 2, 4, 5, 6, 8, 9};
            Assert.Equal(inorderItemsArray, inorderItemsArrayCorrect);
        }

        //       5
        //      /  \   
        //    3      7
        //   / \    / \
        //  1   4  6   8
        //  /\          \
        // 0  2          9
        //    
        [Fact]
        public void AVLTreeTestInsert()
        {
            int[] dataItems = {
                8, 6, 7, 5, 1, 3, 9, 4, 0, 2
            };

            AVLTree<int> tree = new AVLTree<int>();

            tree.Insert(dataItems);

            int[] inorderItemsArray = tree.ToArray();

            int[] inorderItemsArrayCorrect = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Assert.Equal(inorderItemsArray, inorderItemsArrayCorrect);
            Assert.Equal(tree.Height, 4);

            AVLTreeNode<int> node = tree.FindNode(5);
            Assert.Equal(node.Height, 3);
        }

        //       5
        //      /  \   
        //    1      8
        //   / \    / \
        //  0   4  6   9
        [Fact]
        public void AVLTreeTestRemove()
        {
            int[] dataItems = {
                8, 6, 7, 5, 1, 3, 9, 4, 0, 2
            };

            AVLTree<int> tree = new AVLTree<int>();

            tree.Insert(dataItems);
            tree.Remove(3);
            tree.Remove(7);
            tree.Remove(2);

            int[] inorderItemsArray = tree.ToArray();

            int[] inorderItemsArrayCorrect = {0, 1, 4, 5, 6, 8, 9};
            Assert.Equal(inorderItemsArray, inorderItemsArrayCorrect);
            Assert.Equal(3, tree.Height);

            AVLTreeNode<int> node = tree.FindNode(5); 
            Assert.Equal(2, node.Height);
        }
    }
}
