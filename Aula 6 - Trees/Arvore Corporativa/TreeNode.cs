using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arvore_Corporativa
{
    public class TreeNode<T>
    {
        // O atributo Data do tipo genérico armazena o valor de fato
        public T? Data { get; set; } 
        // O atributo Parent será a referência  de um outro nó pai da árvore
        public TreeNode<T>? Parent { get; set; } = null;

        // O atributo Children é uma lista dos nós filhos também do tipo genérico
        public List<TreeNode<T>>? Children { get; set; } = null;

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