using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session01_AdvancedC_
{
    internal class ValueHolder<T> where T : struct
    {
        public T Value { get; set; }

        public ValueHolder(T value)
        {
            Value = value;
        }
    }
}
