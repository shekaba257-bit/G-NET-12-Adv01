using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session01_AdvancedC_
{
    internal class Cache<TKey, TValue>
    {
        private class CacheItem
        {
            public TValue Value { get; set; }
            public DateTime Expiration { get; set; }
        }

        private Dictionary<TKey, CacheItem> items = new Dictionary<TKey, CacheItem>();

      
        public void Add(TKey key, TValue value, int expirationSeconds = 0)
        {
            DateTime expiration = expirationSeconds > 0
                ? DateTime.Now.AddSeconds(expirationSeconds)
                : DateTime.MaxValue;

            items[key] = new CacheItem { Value = value, Expiration = expiration };
        }

    
        public TValue Get(TKey key)
        {
            if (items.ContainsKey(key))
            {
                CacheItem item = items[key];
                if (DateTime.Now <= item.Expiration)
                {
                    return item.Value;
                }
                else
                {
                    items.Remove(key); 
                }
            }
            return default(TValue);
        }

  
        public void Remove(TKey key)
        {
            items.Remove(key);
        }

   
        public bool Contains(TKey key)
        {
            if (items.ContainsKey(key))
            {
                if (DateTime.Now <= items[key].Expiration)
                {
                    return true;
                }
                else
                {
                    items.Remove(key);
                }
            }
            return false;
        }
    }
}
