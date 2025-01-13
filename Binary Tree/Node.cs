using System;

namespace BinaryTree
{
    public class Node
    {
        public int Data { get; set; }
        public Node left;
        public Node right;

        public Node(int data)
        {
            Data = data;
            left = right = null;
        }

        public void Insert(int value)
        {
            if (value < Data)
            {
                if (left == null)
                {
                    left = new Node(value);
                }
                else
                {
                    left.Insert(value);
                }
            }
            else if (value > Data)
            {
                if (right == null)
                {
                    right = new Node(value);
                }
                else
                {
                    right.Insert(value);
                }
            }
        }
    }

}

