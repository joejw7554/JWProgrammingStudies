//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Xml.Linq;

//namespace TestC_Proj.DataStructures
//{

//    class Node
//    {
//        public int data;
//        public int height;
//        public Node left;
//        public Node right;

//        public Node(int data)
//        {
//            this.data = data;
//            height = 0;
//            left = null;
//            right = null;
//        }

//    }

//    internal class AVLTree
//    {

//        Node root;

//        public AVLTree(int initialData)
//        {
//            Node newRoot = new Node(initialData);
//            root = newRoot;
//        }

//        public void Insert(int data)
//        {

//            //루트가없는 경우
//            if (root == null)
//            {
//                root = new Node(data);
//            }

//            //루트가 있는 경우
//            else
//            {
//                //비교해가면서 왼쪽에 둘지 오른쪽에 둘지
//                Node parent = null;
//                Node current = root;

//                while (current != null)
//                {
//                    if (data == current.data)
//                    {
//                        Console.WriteLine($"Unacceptable! No duplicated data: {data}");
//                        break;
//                    }

//                    parent = current;

//                    if (data < current.data)
//                    {
//                        current = current.left;
//                    }
//                    else
//                    {
//                        current = current.right;
//                    }
//                }

//                if (data < parent.data)
//                {
//                    parent.left = new Node(data);
//                }
//                else
//                {
//                    parent.right = new Node(data);
//                }
//            }


//        }

//        public void Search(int data)  //TODO
//        {

//        }


//        public void Delete(int data)
//        {

//            //찾는 과정
//            Node parent = null;
//            Node current = root;

//            while (current != null)
//            {

//                if (data > current.data)
//                {
//                    parent = current;
//                    current = current.right;
//                }
//                else if (data < current.data)
//                {
//                    parent = current;
//                    current = current.left;
//                }
//                else
//                {
//                    break;
//                }

//            }

//            if (current == null)
//                Console.WriteLine($"{data} does not exist");
//            else
//            {
//                if (current.left == null && current.right == null) //자식이 아예 없다면
//                {
//                    if (parent == null)
//                    {
//                        root = null;
//                    }
//                    else
//                    {
//                        if (parent.left == current) parent.left = null;
//                        else parent.right = null;
//                    }


//                }
//                else if (current.left == null || current.right == null) //자식이 하나라면
//                {
//                    Node child = current.left != null ? current.left : current.right;

//                    if (parent == null) root = child;
//                    else
//                    {
//                        if (parent.left == current) parent.left = child;
//                        else parent.right = child;
//                    }
//                }
//                else//자식 모두 존재하는 경우 
//                {
//                    Node successorParent = current;
//                    Node successor = current.left;

//                    while (successor.right != null)
//                    {
//                        successorParent = successor;
//                        successor = successor.right;
//                    }

//                    if (successorParent == current)
//                    {
//                        successorParent.left = successor.left;
//                    }
//                    else
//                    {
//                        successorParent.right = successor.left;
//                    }

//                    current.data = successor.data;
//                }
//            }

//            InOrder();
//        }

//        public void PreOrder() => Recursive_PreOrder(root);


//        void Recursive_PreOrder(Node node) //root -> left -> right
//        {
//            var stack = new Stack<Node>();
//            stack.Push(node);

//            while (stack.Count != 0)
//            {
//                Node selected = stack.Pop();
//                Console.Write(selected.data + " ,");

//                if (selected.right != null)
//                    stack.Push(selected.right);

//                if (selected.left != null)
//                    stack.Push(selected.left);
//            }
//        }

//        public void InOrder() => Recursive_InOrder(root);

//        void Recursive_InOrder(Node node) // Left Root Right
//        {

//            Node current = node;
//            var stack = new Stack<Node>();

//            while (stack.Any() || current != null)
//            {
//                while (current != null)
//                {
//                    stack.Push(current);
//                    current = current.left;
//                }

//                current = stack.Pop();
//                Console.Write(current.data + " ,");

//                current = current.right;
//            }
//        }

//        public void PostOrder() => Recursive_PostOrder(root);//Left -> Right-> Root

//        void Recursive_PostOrder(Node node) //Left Right  Root
//        {
//            Node current = node;

//            var temp = new Stack<Node>();
//            temp.Push(current);

//            var stack = new Stack<Node>();

//            while (temp.Any())
//            {
//                current = temp.Pop(); //Temp 에서 꺼낸대로 stack에다 다시 넣게되면 순서가 어떻게될까? 나 오 왼 -> 왼 오 나 로 스택에 정렬됨

//                stack.Push(current);

//                if (current.left != null)
//                    temp.Push(current.left);

//                if (current.right != null)
//                    temp.Push(current.right);
//            }


//            while (stack.Any()) //이제 스택이 왼 오 나 로 정렬 되어있을꺼임 이걸 그대로 꺼내서 출력하기만 하면됨!
//            {
//                Node selected = stack.Pop();
//                Console.Write(selected.data + " ,");
//            }

//        }

//        Node RotateRight(Node Y)
//        {
//            Node X = Y.left;

//            Y.left = X.right;
//            X.right = Y;
//            UpdateHeight(Y);
//            UpdateHeight(X);

//            return X;
//        }

//        Node RotateLeft(Node Y)
//        {
//            Node X = Y.right;

//            Y.right = X.left;
//            X.left = Y;
//            UpdateHeight(Y);
//            UpdateHeight(X);

//            return X;
//        }

//        Node RotateLR(Node Y)
//        {
//            Y.left = RotateLeft(Y.left);

//            return RotateRight(Y);
//        }
//        Node RotateRL(Node Y)
//        {
//            Y.right = RotateRight(Y.right);

//            return RotateLeft(Y);
//        }

//        int GetHeight(Node node)
//        {
//            if (node == null) return 0;

//            return node.height;
//        }

//        int GetBalance(Node node)
//        {
//            if (node == null) return 0;

//            return GetHeight(node.left) - GetHeight(node.right);
//        }


//        void UpdateHeight(Node node)
//        {
//            int max = Math.Max(GetHeight(node.left), GetHeight(node.right));
//            node.height = max + 1;
//        }

//    }
//}

