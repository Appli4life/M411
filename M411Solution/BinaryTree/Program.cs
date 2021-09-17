using System;
using My.Collections;

namespace BinaryTree
{
    class Program
    {

        static void Main(string[] args)
        {
            var tree = new BinaryTree<int>();

            tree.AddRange(new int[] { 5, 3, 8, 2, 4, 7, 9 });
            //tree.AddRange(new int[] { 4, 2, 1, 3, 6, 5, 7 });
            //tree.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7 });

            //Console.WriteLine(tree.Contains(10));
            //Console.WriteLine(tree.Contains(11));
            //Console.WriteLine(tree.Contains(2));
            //Console.WriteLine(tree.Contains(0));
            
            //Console.WriteLine(tree);

            tree.TraverseMode = TraverseModeEnum.PreOrder;
            Console.WriteLine(tree);

            tree.TraverseMode = TraverseModeEnum.PostOrder;
            Console.WriteLine(tree);

            tree.TraverseMode = TraverseModeEnum.InOrder;
            Console.WriteLine(tree);

            tree.TraverseMode = TraverseModeEnum.ReverseInOrder;
            Console.WriteLine(tree);
        }
    }
}
