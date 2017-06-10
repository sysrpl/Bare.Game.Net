using System.Collections;
using System.Collections.Generic;

namespace Bare.Devices
{
    /// <summary>
    /// Device list is an abstract read only list of computer hardware or software devices.
    /// </summary>
    public abstract class DeviceList<T> : IReadOnlyList<T>
    {
        protected abstract T GetItem(int index);
		protected abstract int GetCount();

		private List<T> list = null;

        private void Realize()
        {
            if (list == null)
                list = new List<T>();
            int i = list.Count;
			int j = GetCount();
			for (int n = i; n < j; n++)
				list.Add(GetItem(n));
		}

        /// <summary>
        /// Gets the item at the specified index.
        /// </summary>
		public T this[int index]
		{
			get
			{
				Realize();
				return list[index];
			}
		}

        /// <summary>
        /// Gets the number of items in the list.
        /// </summary>
		public int Count
		{
			get
			{
				return GetCount();
			}
		}

        /// <summary>
        /// Gets the typed enumerator.
        /// </summary>
		public IEnumerator<T> GetEnumerator()
		{
			Realize();
			int i = GetCount();
			for (int n = 0; n < i; n++)
                yield return list[n];
		}

        /// <summary>
        /// Gets the untyped enumerator.
        /// </summary>
		IEnumerator IEnumerable.GetEnumerator()
		{
			Realize();
			int i = GetCount();
			for (int n = 0; n < i; n++)
				yield return list[n];
		}

	}
}
