namespace BinarySearchTree
{
    public class BinaryTreeSearchUC3
    {
        NodeUC3 root = new NodeUC3();
        NodeUC3 temp;
        public void Insertion(int num)
        {
            if (root.data == 0)
            {
                root.data = num;
                temp = root;
                Console.WriteLine("Root Node is : " + root.data);
            }
            else
            {
                temp = root;
                while (num != 0)
                {
                    if (num >= temp.data)            //if greater than node insert in right child
                    {
                        if (temp.rightChild == null)
                        {
                            temp.rightChild = new NodeUC3();
                            temp = temp.rightChild;
                            temp.data = num;
                            num = 0;
                        }
                        else
                        {
                            temp = temp.rightChild;
                        }
                    }
                    else if (num < temp.data)       //if lesser than node insert in left child
                    {
                        if (temp.leftChild == null)
                        {
                            temp.leftChild = new NodeUC3();
                            temp = temp.leftChild;
                            temp.data = num;
                            num = 0;
                        }
                        else
                        {
                            temp = temp.leftChild;
                        }
                    }
                }
            }
        }
        public void Search(int num)
        {
            temp = root;
            while (num != 0)
            {
                if (num > temp.data)            //if greater than node insert in right child
                {
                    if (temp.rightChild == null)
                    {
                        Console.WriteLine("Value Not Found.");
                        return;
                    }
                    else
                    {
                        temp = temp.rightChild;
                    }
                }
                else if (num < temp.data)       //if lesser than node insert in left child
                {
                    if (temp.leftChild == null)
                    {
                        Console.WriteLine("Value Not Found.");
                        return;
                    }
                    else
                    {
                        temp = temp.leftChild;
                    }
                }
                else
                {
                    Console.WriteLine("Value is Present in the Tree. ");
                }
            }
        }
    }
}
