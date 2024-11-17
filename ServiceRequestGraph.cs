using System.Collections.Generic;
using System;

public class ServiceRequestGraph
{
    private readonly Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();

    public void AddEdge(int fromRequestId, int toRequestId)
    {
        if (!adjacencyList.ContainsKey(fromRequestId))
            adjacencyList[fromRequestId] = new List<int>();

        adjacencyList[fromRequestId].Add(toRequestId);
    }

    public List<int> GetDependencies(int requestId)
    {
        return adjacencyList.ContainsKey(requestId) ? adjacencyList[requestId] : new List<int>();
    }

    public void DisplayGraph()
    {
        foreach (var node in adjacencyList)
        {
            Console.WriteLine($"{node.Key}: {string.Join(", ", node.Value)}");
        }
    }
}
