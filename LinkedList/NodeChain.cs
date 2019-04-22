using System;

namespace LinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    public class NodeChain
    {
        public NodeChain()
        {
            var first = new Node { Value = 3 };
            var middle = new Node { Value = 5 };

            first.Next = middle;

            var last = new Node { Value = 7 };

            middle.Next = last;

            PrintList(first);
        }

        public void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
