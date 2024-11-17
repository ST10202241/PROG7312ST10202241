using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312ST10202241
{
    public class MinHeap
    {
        private readonly List<ServiceRequest> heap = new List<ServiceRequest>();

        public void Insert(ServiceRequest request)
        {
            heap.Add(request);
            HeapifyUp(heap.Count - 1);
        }

        public ServiceRequest ExtractMin()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Heap is empty.");

            var min = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);
            return min;
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (heap[index].SubmittedDate >= heap[parent].SubmittedDate)
                    break;

                Swap(index, parent);
                index = parent;
            }
        }

        private void HeapifyDown(int index)
        {
            while (index < heap.Count)
            {
                int left = 2 * index + 1;
                int right = 2 * index + 2;
                int smallest = index;

                if (left < heap.Count && heap[left].SubmittedDate < heap[smallest].SubmittedDate)
                    smallest = left;
                if (right < heap.Count && heap[right].SubmittedDate < heap[smallest].SubmittedDate)
                    smallest = right;

                if (smallest == index)
                    break;

                Swap(index, smallest);
                index = smallest;
            }
        }

        private void Swap(int index1, int index2)
        {
            var temp = heap[index1];
            heap[index1] = heap[index2];
            heap[index2] = temp;
        }
    }
}
