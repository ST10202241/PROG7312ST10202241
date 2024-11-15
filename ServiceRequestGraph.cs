using System.Collections.Generic;

namespace PROG7312ST10202241
{
    public class ServiceRequestGraph
    {
        private Dictionary<int, List<int>> adjacencyList;

        public ServiceRequestGraph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }

        // Add a service request node
        public void AddRequest(ServiceRequest request)
        {
            if (!adjacencyList.ContainsKey(request.RequestId))
            {
                adjacencyList[request.RequestId] = new List<int>();
            }
        }

        // Add a dependency (edge) between requests
        public void AddDependency(int fromRequestId, int toRequestId)
        {
            if (!adjacencyList.ContainsKey(fromRequestId) || !adjacencyList.ContainsKey(toRequestId))
                throw new KeyNotFoundException("Both service requests must exist before adding a dependency.");

            adjacencyList[fromRequestId].Add(toRequestId);
        }

        // Get all dependencies of a request
        public List<int> GetDependencies(int requestId)
        {
            if (adjacencyList.ContainsKey(requestId))
                return adjacencyList[requestId];

            return null;
        }

        // Get all request IDs
        public List<int> GetRequestIds()
        {
            return new List<int>(adjacencyList.Keys); // Return all request IDs
        }

        // Perform a Breadth-First Search (BFS) to display relationships
        public List<int> BFS(int startRequestId)
        {
            if (!adjacencyList.ContainsKey(startRequestId))
                return null;

            var visited = new HashSet<int>();
            var queue = new Queue<int>();
            var result = new List<int>();

            queue.Enqueue(startRequestId);
            visited.Add(startRequestId);

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                result.Add(current);

                foreach (var neighbor in adjacencyList[current])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return result;
        }

        // Check for cycles in the graph (optional)
        public bool HasCycle()
        {
            var visited = new HashSet<int>();
            var stack = new HashSet<int>();

            foreach (var node in adjacencyList.Keys)
            {
                if (HasCycleHelper(node, visited, stack))
                    return true;
            }

            return false;
        }

        private bool HasCycleHelper(int node, HashSet<int> visited, HashSet<int> stack)
        {
            if (stack.Contains(node))
                return true;

            if (visited.Contains(node))
                return false;

            visited.Add(node);
            stack.Add(node);

            foreach (var neighbor in adjacencyList[node])
            {
                if (HasCycleHelper(neighbor, visited, stack))
                    return true;
            }

            stack.Remove(node);
            return false;
        }
    }
}
