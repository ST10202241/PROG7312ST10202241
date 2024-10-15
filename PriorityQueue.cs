using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312ST10202241
{
    public class PriorityQueue<TElement, TPriority> where TPriority : IComparable
    {
        private List<(TElement Element, TPriority Priority)> _elements = new List<(TElement, TPriority)>();

        public int Count => _elements.Count;

        public void Enqueue(TElement element, TPriority priority)
        {
            _elements.Add((element, priority));
            _elements.Sort((x, y) => x.Priority.CompareTo(y.Priority)); // Sort based on priority
        }

        public TElement Dequeue()
        {
            if (_elements.Count == 0)
                throw new InvalidOperationException("The queue is empty");

            var element = _elements[0];
            _elements.RemoveAt(0);
            return element.Element;
        }
    }
}
