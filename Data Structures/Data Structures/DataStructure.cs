﻿
namespace Data_Structures
{
    abstract public class DataStructure : DataFunctions
    {
        abstract public void Add(object data);

        abstract public object Get(object index);

        abstract public void Remove(int index);

        abstract public void Clear();

        abstract public int GetSize();
    }
}