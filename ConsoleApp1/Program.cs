using System;
using System.IO;
using System.Collections;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using ClassLibrary1;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> root = GetTree();
            Print(root,0);
            Console.ReadKey();
        }

        private static Node<int> GetTree()
        {
            var root = new Node<int>(1);
            root.Children.Add(new Node<int>(2));
            var node3 = new Node<int>(3);
            root.Children.Add(node3);
            node3.Children.Add(new Node<int>(4));
            node3.Children.Add(new Node<int>(5));
            root.Children.Add(new Node<int>(6));
            root.Children.Add(new Node<int>(7));
            return root;
        }

        private static void Print(Node<int> node, int level)
        {
            string space = string.Concat(Enumerable.Repeat(" ", level));
            Console.WriteLine(space + node.Value);
            foreach (var child in node.Children)
            {
                Print(child, level + 1);
            }
        }
    }
}