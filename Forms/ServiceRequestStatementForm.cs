using PROG7312ST10202241.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PROG7312ST10202241
{
    // Form to manage and display service requests
    public partial class ServiceRequestStatementForm : Form
    {
        private ServiceRequestBST serviceRequestTree;
        private Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        private void InitializeGraph()
        {
            graph[1] = new List<int> { 2, 3 };
            graph[2] = new List<int> { 4, 5 };
            graph[3] = new List<int> { 6 };
            graph[4] = new List<int>();
            graph[5] = new List<int>();
            graph[6] = new List<int>();
        }
        private void AddNode(int node)
        {
            if (!graph.ContainsKey(node))
            {
                graph[node] = new List<int>();
            }
        }
        private void AddEdge(int fromNode, int toNode)
        {
            AddNode(fromNode);
            AddNode(toNode);

            graph[fromNode].Add(toNode);
        }


        private void ServiceRequestStatementForm_Load(object sender, EventArgs e)
        {
            InitializeGraph();
        }

        private int graphRootNode = 1; // Example root node
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

                    // Push neighbors to stack
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

        public ServiceRequestStatementForm(ServiceRequestBST tree)
        {
            InitializeComponent();

            serviceRequestTree = tree;

            foreach (var issue in ReportDataStorage.ReportedIssues)
            {
                // No need for TryParse as RequestID is already an int
                var serviceRequest = new ServiceRequest(
                    issue.RequestID,
                    issue.Location,
                    issue.Category,
                    issue.Description,
                    "Pending", // Default status
                    issue.ReportDate
                );
                serviceRequestTree.Insert(serviceRequest);
            }

            LoadServiceRequests(); // Populate DataGridView
        }



        // Load and display service requests in a DataGridView
        private void LoadServiceRequests()
        {
            var requests = serviceRequestTree.InOrderTraversal();
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

        // Search for a service request by ID
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchId.Text, out int id))
            {
                var request = serviceRequestTree.Search(id);
                if (request != null)
                {
                    MessageBox.Show($"Request ID: {request.RequestId}\nLocation: {request.Location}\nCategory: {request.Category}\nStatus: {request.Status}",
                        "Service Request Found");
                }
                else
                {
                    MessageBox.Show($"Service Request with ID {id} not found.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Input Error");
            }
        }


        // Update the status of a service request
        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchId.Text, out int id))
            {
                var request = serviceRequestTree.Search(id);
                if (request != null)
                {
                    request.Status = txtNewStatus.Text; // Update the status
                    LoadServiceRequests(); // Refresh the DataGridView to reflect the change
                    MessageBox.Show($"Status for Request ID {id} updated to '{txtNewStatus.Text}'.", "Success");
                }
                else
                {
                    MessageBox.Show($"Service Request with ID {id} not found.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Input Error");
            }
        }


        private void ServiceRequestStatementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            ServiceRequestBST tree = new ServiceRequestBST();
            ServiceRequestGraphForm formy = new ServiceRequestGraphForm(tree);
            Form1 Form = new Form1();
            Form.Show();
            this.Hide();
            formy.Close();
        }
        private void btnShowMST_Click(object sender, EventArgs e)
        {
            MST mstCalculator = new MST();

            // Example edges - replace with real data as needed
            mstCalculator.AddEdge(1, 2, 3);
            mstCalculator.AddEdge(1, 3, 1);
            mstCalculator.AddEdge(2, 4, 5);
            mstCalculator.AddEdge(3, 4, 4);

            var mstEdges = mstCalculator.GetMinimumSpanningTree();
            lstMSTDisplay.Items.Clear();
            foreach (var edge in mstEdges)
            {
                lstMSTDisplay.Items.Add($"From {edge.From} to {edge.To}, Weight: {edge.Weight}");
            }
        }


        private void btnGraphTraversal_Click(object sender, EventArgs e)
        {
            if (graph.Count == 0)
            {
                MessageBox.Show("The graph is empty. Please add nodes and edges first.", "Error");
                return;
            }

            // Ensure graphRootNode exists
            if (!graph.ContainsKey(graphRootNode))
            {
                MessageBox.Show($"Root node {graphRootNode} does not exist in the graph.", "Error");
                return;
            }

            var traversalResult = PerformDFS(graphRootNode, graph);

            lstTraversalDisplay.Items.Clear();
            foreach (var node in traversalResult)
            {
                lstTraversalDisplay.Items.Add($"Visited Node: {node}");
            }

            MessageBox.Show("Depth-First Search traversal completed!", "Success");
        }

        private void btnSetRoot_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRootNode.Text, out int rootNode) && graph.ContainsKey(rootNode))
            {
                graphRootNode = rootNode;
                MessageBox.Show($"Root node set to {rootNode}");
            }
            else
            {
                MessageBox.Show("Invalid root node or node does not exist in the graph.", "Error");
            }
        }

    }
}
