using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session01_AdvancedC_
{
    internal class Factory<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T(); // allowed because of new() constraint
        }
    }
}
