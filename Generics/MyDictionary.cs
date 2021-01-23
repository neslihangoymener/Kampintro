using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyDictionary<TKey, TValue>
    {
        List<TKey> _keys;
        List<TValue> _values;

        public MyDictionary()
        {
            _keys = new List<TKey>();
            _values = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            _keys.Add(key);
            _values.Add(value);
        }

        public TValue this[TKey key]
        {
            get
            {
                int index = _keys.IndexOf(key);
                TValue value = _values[index];

                return value;
            }
        }
    }
    
}
