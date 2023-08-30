using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DataStructure
{
    internal class CustomLinkedList<T>
    {
        class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node Prev { get; set; }

            public Node(T data)
            {
                this.Data = data;
                this.Next = null;
                this.Prev = null;
            }
             ~Node()
            {
                Console.WriteLine("Test Print Destroy");
            }

            public static Node CreateNode(T data)
            {
                return new Node(data);
            }
        }

        private Node _rootNode;
        private Node _backNode;
        public int Count { get; set; }
        

        public CustomLinkedList()
        {
            this.Count = 0;
            this._rootNode = null;
        }

        public void PushBack(T data)
        {
            Node node = Node.CreateNode(data);
            if (this.Count == 0)
            {
                this._rootNode = node;
                this._backNode = node;
            }
            else
            {
                this._backNode.Next = node;
                node.Prev = this._backNode;
                this._backNode = node;
            }
            this.Count++;
        }

        public void PushFront(T data)
        {
            Node node = Node.CreateNode(data);
            if (this.Count == 0)
            {
                this._rootNode = node;
            }
            else
            {
                this._rootNode.Prev = node;
                node.Next = this._rootNode;
                this._rootNode = node;
            }
            this.Count++;
        }

        public void Clear()
        {
            this._rootNode = null;
            this._backNode = null;
            this.Count = 0;
        }

        public void PrintAll()
        {
            Console.WriteLine($"COUNT: {this.Count}");
            for (Node node = this._rootNode; node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }
        }
    }
}
