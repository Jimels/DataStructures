
﻿using System;
using System.Windows.Forms;

namespace Data_Structures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Peforms data metrics against a data structure of type Linked List, specified by the user.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">Object reference of Event argument.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            new DataStatisticsForm(new SinglyList(), "LinkedList random insert perfomance test");
        }

        /// <summary>
        /// Peforms data metrics against a data structure of type Binary Tree, specified by the user.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">Object reference of Event argument.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            new DataStatisticsForm(new BinaryTrees(), "BinaryTree random insert perfomance test");
        }

        /// <summary>
        /// Peforms data metrics against a data structure of type Hash Table, specified by the user.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">Object reference of Event argument.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            new DataStatisticsForm(new HashTable(), "HashTable random insert perfomance test");
        }

        private void DataResultsTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}