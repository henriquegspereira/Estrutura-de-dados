using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company_Tree
{
    public class TreeNode<T>
    {
        // O atributo data do tipo generic T armazenara o valor de fato 
        public T Data { get; set; }

        //O atributo Parent sera a referencia ao nó Pai da arvore 
        public TreeNode<T> Parent { get; set; }

        //O atributo children é uma lista dos nós filhos, tambem do tipo T generic
        public List<TreeNode<T>> Children { get; set; }

        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }

    }
}