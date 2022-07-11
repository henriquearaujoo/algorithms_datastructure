using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MyLinkedList<T>
    {
        private Node head;
        private Node tail;
        //private Func<T, T> GetSingle = Single;
        public int Count { get; private set; }

        public MyLinkedList<T> AddFirst(T item)
        {
            if (IsEmpty())
            {
                var trav = new Node(item, null, null);
                head = tail = trav;
            }
            else
            {
                head.Prev = new Node(item, null, head);
                head = head.Prev;
            }

            Count++;
            return this;
        }

        public MyLinkedList<T> AddLast(T item)
        {
            if (IsEmpty())
            {
                var trav = new Node(item, null, null);
                head = tail = trav;
            }
            else
            {
                tail.Next = new Node(item, tail, null);
                tail = tail.Next;
            }

            Count++;
            return this;
        }

        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new InvalidOperationException("List is empty");

            var trav = head.Next;
            head = trav;
            head.Prev = null;
            Count--;
        }
        public void RemoveLast()
        {
            if (IsEmpty())
                throw new InvalidOperationException("List is empty");

            var trav = tail.Prev;
            tail = trav;
            tail.Next = null;
            Count--;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }


        public MyLinkedList<T> Add(T item)
        {
            return AddLast(item);
        }

        public override string ToString()
        {
            var stringResult = new StringBuilder();
            GetStringData(head, stringResult);
            return stringResult.ToString();
        }

        public T Single(Func<T, T> predicate)
        {
            //predicate()
            if (head.Next != null)
            {
                str.Append(node.Data?.ToString() + ", ");
                GetData(node.Next, str);
            }
            else
                str.Append(node.Data?.ToString());
        }

        private void GetStringData(Node node, StringBuilder str)
        {
            if (node.Next != null)
            {
                str.Append(node.Data?.ToString() + ", ");
                GetStringData(node.Next, str);
            }
            else
                str.Append(node.Data?.ToString());
        }

        private class Node
        {
            public Node(T data, Node prev, Node next)
            {
                Data = data;
                Prev = prev;
                Next = next;
            }

            public T Data { get; }
            public Node Next { get; set; }
            public Node Prev { get; set; }
        }
    }

    
}
