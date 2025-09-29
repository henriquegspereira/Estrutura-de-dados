using System;

namespace Simple_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<QuizItem> tree = GetTree();
            BinaryTreeNode<QuizItem> node = tree.Root;

            while (node != null)
            {
                if (node.Left != null || node.Right != null)
                {
                    Console.WriteLine(node.Data.Text);
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.Y:
                            BinaryTreeNode<QuizItem>.WriteAnswer(" Yes");
                            node = node.Left;
                            break;
                        case ConsoleKey.N:
                            BinaryTreeNode<QuizItem>.WriteAnswer(" No");
                            node = node.Right;
                            break;
                    }
                }
                else
                {
                    BinaryTreeNode<QuizItem>.WriteAnswer(node.Data.Text);
                    node = null;
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        private static BinaryTree<QuizItem> GetTree()
        {
            BinaryTree<QuizItem> tree = new BinaryTree<QuizItem>();

            tree.Root = new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("Do you have experience in developing applications?")
            };

            // YES branch
            tree.Root.Left = new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("Have you worked as a developer for more than 5 years?")
            };
            tree.Root.Left.Left = new BinaryTreeNode<QuizItem>() // YES
            {
                Data = new QuizItem("Apply as a senior developer!")
            };
            tree.Root.Left.Right = new BinaryTreeNode<QuizItem>() // NO
            {
                Data = new QuizItem("Apply as a middle developer!")
            };

            // NO branch
            tree.Root.Right = new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("Have you completed the university?")
            };
            tree.Root.Right.Left = new BinaryTreeNode<QuizItem>() // YES
            {
                Data = new QuizItem("Apply for a junior developer!")
            };
            tree.Root.Right.Right = new BinaryTreeNode<QuizItem>() // NO
            {
                Data = new QuizItem("Will you find some time during the semester?")
            };
            tree.Root.Right.Right.Left = new BinaryTreeNode<QuizItem>() // YES
            {
                Data = new QuizItem("Apply for our long-time internship program!")
            };
            tree.Root.Right.Right.Right = new BinaryTreeNode<QuizItem>() // NO
            {
                Data = new QuizItem("Apply for summer internship program!")
            };

            tree.Count = 9;
            return tree;
        }
    }
}
