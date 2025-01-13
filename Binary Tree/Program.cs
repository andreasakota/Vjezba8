using BinaryTree;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            int[] array = { 4, 2, 6, 7, 1, 3, 5, 8 };

            foreach (int i in array)
            {
                tree.Insert(i);
            }

            Console.WriteLine("InOrder Traversal:");
            tree.Traverse(Tree.TraversalType.InOreder);

            int value = 4;
            if (tree.Search(value))
                Console.WriteLine("Value {0} is found in the tree.", value);
            else
                Console.WriteLine("Value {0} is not found in the tree.", value);

            Console.WriteLine("Deleting value {0}:", value);
            tree.Delete(value);

            Console.WriteLine("InOrder Traversal after deletion:");
            tree.Traverse(Tree.TraversalType.InOreder);
        }
    }
}
