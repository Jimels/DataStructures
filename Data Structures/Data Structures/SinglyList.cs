using System;

namespace Data_Structures
{
    class SinglyList : DataStructure
    {
        private int size = 0;
        private Node head;

        /// <summary>
        /// Node which containts the next Node and this Node's data.
        /// </summary>
        private class Node
        {
            private Object data;
            protected Node next;

            /// <summary>
            /// Constructs Node and sets its data.
            /// </summary>
            /// <param name="data">Data provided.</param>
            public Node(Object data)
            {
                this.data = data;
            }

            /// <summary>
            /// Sets this Node's next Node reference.
            /// </summary>
            /// <param name="nextNode">Next Node object.</param>
            public void SetNext(Node nextNode)
            {
                next = nextNode;
            }

            /// <summary>
            /// Returns this Node's next Node reference.
            /// </summary>
            /// <returns>This Node's next Node reference.</returns>
            public Node GetNext()
            {
                return next;
            }

            /// <summary>
            /// Sets this Node's data.
            /// </summary>
            /// <param name="data">Data provided.</param>
            public void SetData(Object data)
            {
                this.data = data;
            }

            /// <summary>
            /// Returns this Node's data.
            /// </summary>
            /// <returns>This Node's data.</returns>
            public Object GetData()
            {
                return data;
            }
        }

        /// <summary>
        /// Adds new Node with data provided.
        /// </summary>
        /// <param name="data">Data provided.</param>
        public override void Add(Object data)
        {
            if (head == null)
                head = new Node(data);
            else
            {
                Node current = head;
                head = new Node(data);

                head.SetNext(current);
            }
            size++;
        }

        /// <summary>
        /// Returns Node at specified index.
        /// </summary>
        /// <param name="index">Location of Node instance.</param>
        /// <returns>Node instance.</returns>
        public override Object Get(object index)
        {
            Node current = head;
            for (var i = 0; i < Convert.ToInt32(index); i++)
                current = current.GetNext();

            return current.GetData();
        }

        /// <summary>
        /// Erases entire Linked List.
        /// </summary>
        public override void Clear()
        {
            head = null;
            size = 0;
        }

        /// <summary>
        /// Returns size of Linked List.
        /// </summary>
        /// <returns>Size of Linked List.</returns>
        public override int GetSize()
        {
            return size;
        }

        /// <summary>
        /// Removes Node at specified index.
        /// </summary>
        /// <param name="index">Location of Node instance.</param>
        public override void Remove(int index)
        {
            Node current = head;

            if (index > -1 || index < size)
            {
                if (index == 0)
                    head = current.GetNext();
                else
                {
                    for (var i = 0; i < index - 1; i++)
                        current = current.GetNext();
                    current.SetNext(current.GetNext().GetNext());
                }
                size--;
            }
        }

        /// <summary>
        /// Places Linked List Nodes in ascending order.
        /// </summary>
        public void sort()
        {
            Node current = head;
            var notSorted = true;
            while (notSorted)
            {
                current = head;
                notSorted = false;
                while (current.GetNext() != null)
                {
                    if (Convert.ToInt32(current.GetData()) > Convert.ToInt32(current.GetNext().GetData()))
                    {
                        notSorted = true;

                        Object currentData = current.GetData();
                        current.SetData(current.GetNext().GetData());
                        current.GetNext().SetData(currentData);
                    }
                    current = current.GetNext();
                }
            }
        }

        /// <summary>
        /// Returns String of Linked List's contents.
        /// </summary>
        /// <returns>Linked List's contents.</returns>
        public override String ToString()
        {
            var str = new System.Text.StringBuilder();
            Node current = head;
            while (current != null)
            {
                str.Append(current.GetData() + ", ");
                current = current.GetNext();
            }
            return str.ToString();
        }
    }
}