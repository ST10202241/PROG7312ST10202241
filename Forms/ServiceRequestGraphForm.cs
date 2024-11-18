using PROG7312ST10202241.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PROG7312ST10202241
{
    public partial class ServiceRequestGraphForm : Form
    {
        private ServiceRequestRedBlackTree redBlackTree;
        private MinHeap minHeap;
        private ServiceRequestGraph serviceRequestGraph;

        public ServiceRequestGraphForm()
        {
            InitializeComponent();

            // Initialize data structures
            redBlackTree = new ServiceRequestRedBlackTree();
            minHeap = new MinHeap();
            serviceRequestGraph = new ServiceRequestGraph();

            // Load data from ReportDataStorage
            LoadServiceRequests();
        }

        private void LoadServiceRequests()
        {
            // Load reported issues from ReportDataStorage
            foreach (var issue in ReportDataStorage.ReportedIssues)
            {
                var serviceRequest = new ServiceRequest(issue.RequestID, issue.Location, issue.Category, issue.Description, "Pending", issue.ReportDate);
                redBlackTree.Insert(serviceRequest);
                minHeap.Insert(serviceRequest);
                serviceRequestGraph.AddEdge(issue.RequestID, issue.RequestID + 1); // Example dependency
            }

            // Display data in DataGridView
            var requests = GetInOrderRequests();
            dataGridViewRequests.DataSource = requests.Select(r => new
            {
                r.RequestId,
                r.Location,
                r.Category,
                r.Description,
                r.Status,
                r.SubmittedDate
            }).ToList();
        }

        private List<ServiceRequest> GetInOrderRequests()
        {
            var results = new List<ServiceRequest>();
            redBlackTree.InOrderTraversal(results);
            return results;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int requestId = int.Parse(txtSearchId.Text);
                var rbRequest = redBlackTree.Search(requestId);

                if (rbRequest != null)
                {
                    string message = $"Service Request Found in Red-Black Tree:\nRequestId: {rbRequest.RequestId}\nLocation: {rbRequest.Location}\nCategory: {rbRequest.Category}\nDescription: {rbRequest.Description}\nStatus: {rbRequest.Status}\nSubmittedDate: {rbRequest.SubmittedDate}";
                    MessageBox.Show(message);
                }
                else
                {
                    MessageBox.Show("Service Request Not Found in Red-Black Tree");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                int requestId = int.Parse(txtSearchId.Text);
                var rbRequest = redBlackTree.Search(requestId);

                if (rbRequest != null)
                {
                    rbRequest.Status = txtNewStatus.Text; // Update the status
                    MessageBox.Show($"Status for Request ID {requestId} updated to '{txtNewStatus.Text}'.");

                    // Refresh the DataGridView to reflect the change
                    LoadServiceRequests();
                }
                else
                {
                    MessageBox.Show("Service Request Not Found in Red-Black Tree");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnShowHeap_Click(object sender, EventArgs e)
        { 
            try 
            { 
                var heapRequests = minHeap.GetAll(); 
                var message = "Heap Elements:\n"; foreach (var request in heapRequests)
                {
                    message += $"RequestId: {request.RequestId}, SubmittedDate: {request.SubmittedDate}\n"; 
                }
                MessageBox.Show(message);
            } 
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}");
            } 
        }

        private void btnShowGraph_Click(object sender, EventArgs e)
        {
            var graphEdges = serviceRequestGraph.GetEdges();
            var message = "Graph Edges:\n";
            foreach (var edge in graphEdges)
            {
                message += $"{edge.From} -> {edge.To}\n";
            }
            MessageBox.Show(message);
        }

        private void btnShowMST_Click(object sender, EventArgs e)
        {
            MST mstCalculator = new MST();

            // Example edges
            mstCalculator.AddEdge(1, 2, 3);
            mstCalculator.AddEdge(1, 3, 1);
            mstCalculator.AddEdge(2, 4, 5);
            mstCalculator.AddEdge(3, 4, 4);

            var mstEdges = mstCalculator.GetMinimumSpanningTree();
            // lstMSTDisplay.Items.Clear();
            foreach (var edge in mstEdges)
            {
                // lstMSTDisplay.Items.Add($"From {edge.From} to {edge.To}, Weight: {edge.Weight}");
            }
        }

        private void btnGraphTraversal_Click(object sender, EventArgs e)
        {
            try
            {
                int rootNode = int.Parse(txtRootNode.Text);
                var traversalResult = PerformDFS(rootNode, serviceRequestGraph.GetGraph());
                // lstTraversalDisplay.Items.Clear();
                foreach (var node in traversalResult)
                {
                    // lstTraversalDisplay.Items.Add($"Visited Node: {node}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private List<int> PerformDFS(int startNode, Dictionary<int, List<int>> graph)
        {
            var visited = new HashSet<int>();
            var result = new List<int>();
            var stack = new Stack<int>();

            stack.Push(startNode);

            while (stack.Count > 0)
            {
                int node = stack.Pop();

                if (!visited.Contains(node))
                {
                    visited.Add(node);
                    result.Add(node);

                    if (graph.ContainsKey(node))
                    {
                        foreach (var neighbor in graph[node])
                        {
                            stack.Push(neighbor);
                        }
                    }
                }
            }

            return result;
        }

        private void btnSetRoot_Click(object sender, EventArgs e)
        {
            try
            {
                int rootNode = int.Parse(txtRootNode.Text);
                MessageBox.Show($"Root node set to {rootNode}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ServiceRequestGraphForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

       
    }
}
