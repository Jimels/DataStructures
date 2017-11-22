﻿using System;

/* ===Sources===
 * http://www.newthinktank.com/2013/03/binary-trees-in-java-2/
 * 
 */

namespace Data_Structures
{
    class BinaryTrees : DataStructure
    {
        private int size = 0;
        private Node head;

        /// <summary>
        /// Adds objects data to Binary Tree.
        /// </summary>
        /// <param name="data">Object data provided.</param>
        public override void Add(Object data)
        {
            if (head == null)
                head = new Node(data);

            else
            {
                Node current = head;
                Node parent;

                while (current != null)
                {
                    parent = current;
                    if (Convert.ToInt32(data) <= Convert.ToInt32(current.GetData()))
                    {
                        current = current.GetLeftNode();

                        if (current == null)
                            parent.SetLeftNode(new Node(data));
                    }

                    else
                    {
                        current = current.GetRightNode();

                        if (current == null)
                            parent.SetRightNode(new Node(data));
                    }
                }
            }
            size++;
        }

        /// <summary>
        /// Returns object data at specified index.
        /// </summary>
        /// <param name="key">Index specified.</param>
        /// <returns>Object data at specified location.</returns>
        public override Object Get(object key)
        {
            Node current = head;

            while (current.GetLeftNode() != null && current.GetRightNode() != null && Int32.Parse(Convert.ToString(current.GetData())) != Convert.ToInt32(key))
            {
                if (Int32.Parse(Convert.ToString(current.GetData())) < Convert.ToInt32(key))
                    current = current.GetRightNode();

                else
                    current = current.GetLeftNode();
            }
            return current.GetData();
        }

        String str = "";
        /// <summary>
        /// Goes through each node of the Binary Tree.
        /// </summary>
        /// <param name="current">The current Node.</param>
        public void SearchTree(Node current)
        {
            if (current != null)
            {
                //do something
                SearchTree(current.GetLeftNode());
                SearchTree(current.GetRightNode());
            }
        }

        /// <summary>
        /// Returns each element of the Binary Tree as String.
        /// </summary>
        /// <returns>String of Binary Trees contents.</returns>
        public override String ToString()
        {
            return str;
        }

        /// <summary>
        /// Returns size of Binary Tree.
        /// </summary>
        /// <returns>Size of binary Tree.</returns>
        public override int GetSize()
        {
            return size;
        }

        /// <summary>
        /// Returns the Root Node.
        /// </summary>
        /// <returns>Root Node.</returns>
        public Node getHead()
        {
            return head;
        }

        /// <summary>
        /// Erases entire Binary Tree.
        /// </summary>
        public override void Clear()
        {
            head = null;
            size = 0;
        }

        /// <summary>
        /// Remove Node at specified location.
        /// </summary>
        /// <param name="index">Location of the Node.</param>
        public override void Remove(int index)
        {
            Node current = head;
            Node parent = null;

            while (Int32.Parse(Convert.ToString(current.GetData())) != index)
            {
                parent = current;

                if (Convert.ToInt32(current.GetData()) > index)
                    current = current.GetLeftNode();

                else
                    current = current.GetRightNode();
            }

            if (current.GetLeftNode() == null && current.GetRightNode() == null)
            {

                if (current == head)
                    head = null;

                else if (Convert.ToInt32(parent.GetData()) > index)
                    parent.SetLeftNode(null);

                else
                    parent.SetRightNode(null);
            }

            else if (current.GetRightNode() == null)
            {

                if (current == head)
                    head = current.GetLeftNode();

                else if (Convert.ToInt32(parent.GetData()) > index)
                    parent.SetLeftNode(current.GetLeftNode());

                else
                    parent.SetRightNode(current.GetLeftNode());

            }

            else if (current.GetLeftNode() == null)
            {

                if (current == head)
                    head = current.GetRightNode();

                else if (Convert.ToInt32(parent.GetData()) > index)
                    parent.SetLeftNode(current.GetRightNode());

                else
                    parent.SetRightNode(current.GetRightNode());

            }

            else
            {
                Node newNodeParent = current;
                Node newNode = current;
                Node focusNode = current.GetRightNode();

                while (focusNode != null)
                {
                    newNodeParent = newNode;

                    newNode = focusNode;

                    focusNode = focusNode.GetLeftNode();
                }

                if (newNode != current.GetRightNode())
                {
                    newNodeParent.SetLeftNode(newNode.GetRightNode());
                    newNode.SetRightNode(current.GetRightNode());
                }

                if (current == head)
                    head = newNode;

                else if (Convert.ToInt32(parent.GetData()) > index)
                    parent.SetLeftNode(newNode);

                else
                    parent.SetRightNode(newNode);

                newNode.SetLeftNode(current.GetLeftNode());
            }
            size--;
        }
    }

    /// <summary>
    /// Node class containing the left and right Node and the data of this Node.
    /// </summary>
    class Node
    {
        private Object data;
        private Node leftNode;
        private Node rightNode;

        /// <summary>
        /// Creates new Node and defines its data.
        /// </summary>
        /// <param name="data">Object data this Node holds.</param>
        public Node(Object data)
        {
            this.data = data;
        }

        /// <summary>
        /// Returns this Node's Data.
        /// </summary>
        /// <returns>This Node's Data.</returns>
        public Object GetData()
        {
            return data;
        }

        /// <summary>
        /// Sets this Node's left Node attribute.
        /// </summary>
        /// <param name="arg">Node provided.</param>
        public void SetLeftNode(Node arg)
        {
            leftNode = arg;
        }

        /// <summary>
        /// Returns this Node's left Node attribute.
        /// </summary>
        /// <returns>This Node's left Node attribute.</returns>
        public Node GetLeftNode()
        {
            return leftNode;
        }

        /// <summary>
        /// Sets this Node's right Node attribute.
        /// </summary>
        /// <param name="arg">Node provided.</param>
        public void SetRightNode(Node arg)
        {
            rightNode = arg;
        }

        /// <summary>
        /// Returns this Node's right Node attribute.
        /// </summary>
        /// <returns>This Node's right Node attribute.</returns>
        public Node GetRightNode()
        {
            return rightNode;
        }

        /// <summary>
        /// Returns String of this Node's data.
        /// </summary>
        /// <returns>This Node's data.</returns>
        public override String ToString()
        {
            return Convert.ToString(data);
        }
    }
}