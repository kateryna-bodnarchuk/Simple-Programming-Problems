using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Node <T>
    {
        public Node(T value, List<Node<T>> children)
        {
            Value = value;
            Children = children;
        }

        public Node(T value) : this(value, new List<Node<T>>())
        {

        }

        public T Value { get; }
        public List<Node<T>> Children { get; }
    }
}
