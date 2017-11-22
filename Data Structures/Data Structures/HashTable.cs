
﻿using System;

namespace Data_Structures
{
    class HashTable : DataStructure
    {
        private const int TABLE_SIZE = 500000;
        private int size = 0;
        private SinglyList[] array;

        /// <summary>
        /// Once constructed, calls initialiseArray method.
        /// </summary>
        public HashTable()
        {
            InitialiseArray();
        }

        /// <summary>
        /// Initialises array with TABLE_SIZE property, and sets every reference to null.
        /// </summary>
        private void InitialiseArray()
        {
            array = new SinglyList[TABLE_SIZE];
            for (var i = 0; i < TABLE_SIZE; i++)
                array[i] = null;
        }

        /// <summary>
        /// Creates hash out of data provided, then adds it to array.
        /// </summary>
        /// <param name="data">Data provided.</param>
        public override void Add(Object data)
        {
            int hash = (Convert.ToInt32(data) % TABLE_SIZE);

            if (array[hash] == null)
                array[hash] = new SinglyList();

            array[hash].Add(data);
            size++;
        }

        /// <summary>
        /// Returns data by using the hash of data provided as index.
        /// </summary>
        /// <param name="key">Data provided.</param>
        /// <returns>Returns data of Hash Tables index.</returns>
        public override Object Get(object key)
        {
            int hash = (Convert.ToInt32(key) % TABLE_SIZE);
            return array[hash] != null ? array[hash] : null;
        }

        /// <summary>
        /// Erases entire Hash Table.
        /// </summary>
        public override void Clear()
        {
            InitialiseArray();
            size = 0;
        }

        /// <summary>
        /// Returns Hash Table's size.
        /// </summary>
        /// <returns>Hash Table's size.</returns>
        public override int GetSize()
        {
            return size;
        }

        /// <summary>
        /// Removes data by using the hash of data provided as index.
        /// </summary>
        /// <param name="key">Data provided.</param>
        public override void Remove(int key)
        {
            int hash = (Convert.ToInt32(key) % TABLE_SIZE);
            array[hash] = null;
            size--;
        }

        /// <summary>
        /// String of Hash Tables contents.
        /// </summary>
        /// <returns>Hash Tables contents.</returns>
        public override String ToString()
        {
            var str = new System.Text.StringBuilder();

            for (var i = 0; i < TABLE_SIZE; i++)
                if (array[i] != null)
                    str.Append(array[i].ToString());

            return str.ToString();
        }
    }
}