using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderForm
{
	public class MultiMap<K, V> : Dictionary<K, List<V>>
	{
		public void Add(K key, V value)
		{
			List<V> lstValues;
			if (!TryGetValue(key, out lstValues))
			{
				lstValues = new List<V>();
				lstValues.Add(value);
				Add(key, lstValues);
			}
			else
			{
				if (!lstValues.Contains(value))
					lstValues.Add(value);
			}
		}

		public bool Find(K key, out List<V> lstValues)
		{
			bool bRetVal = true;

			if (!TryGetValue(key, out lstValues))
				lstValues = new List<V>();

			return bRetVal;
		}
	}
}
