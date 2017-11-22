
﻿using System;

namespace Data_Structures
{
    interface DataFunctions
    {
        void Add(Object data);

        void Remove(int index);

        void Clear();

        object Get(object index);

        int GetSize();
    }
}