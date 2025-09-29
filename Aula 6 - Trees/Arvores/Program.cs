using System.ComponentModel;
using Arvores;

// Declaração de variável tree do tipo Tree, onde Tree<int> agora é de inteiros
Tree<int> tree = new Tree<int>();
tree.Root = new TreeNode<int>() { Data = 100 };
tree.Root.Children = new List<TreeNode<int>>
{
 new TreeNode<int>() { Data = 50, Parent = tree.Root },
 new TreeNode<int>() { Data = 1, Parent = tree.Root },
 new TreeNode<int>() { Data = 150, Parent = tree.Root }
};
tree.Root.Children[2].Children = new List<TreeNode<int>>()
{
 new TreeNode<int>()
 { Data = 30, Parent = tree.Root.Children[2] }
};

//Adicionado com ChatGPT
void PrintTree<T>(TreeNode<T> node, string indent = "")
{
    if (node == null) return;

    Console.WriteLine(indent + node.Data);

    if (node.Children != null)
    {
        foreach (var child in node.Children)
        {
            PrintTree(child, indent + "   "); // aumenta a indentação a cada nível
        }
    }
}

PrintTree(tree.Root);