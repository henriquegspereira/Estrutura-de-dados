using System.Collections.Generic;

namespace Simple_Quiz
{
    public class TreeNode<T>
    {
        public T Data { get; set; } = default!;
        public List<TreeNode<T>> Children { get; set; } = new List<TreeNode<T>>();
    }
}
