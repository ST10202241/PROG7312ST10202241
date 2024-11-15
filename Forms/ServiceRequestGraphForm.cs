using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PROG7312ST10202241
{
    public partial class ServiceRequestGraphForm : Form
    {
        private ServiceRequestGraph requestGraph;

        public ServiceRequestGraphForm(ServiceRequestGraph graph)
        {
            InitializeComponent();
            requestGraph = graph;
        }

        private void btnDisplayGraph_Click(object sender, EventArgs e)
        {
            try
            {
                treeViewGraph.Nodes.Clear();

                // Visualize the graph as a TreeView
                foreach (var requestId in requestGraph.GetRequestIds())
                {
                    TreeNode node = new TreeNode($"Request ID: {requestId}");
                    AddDependenciesToNode(node, requestId);
                    treeViewGraph.Nodes.Add(node);
                }

                MessageBox.Show("Graph displayed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying graph: {ex.Message}");
            }
        }

        private void AddDependenciesToNode(TreeNode node, int requestId)
        {
            var dependencies = requestGraph.GetDependencies(requestId);
            if (dependencies != null)
            {
                foreach (var dependency in dependencies)
                {
                    TreeNode childNode = new TreeNode($"Dependency: {dependency}");
                    AddDependenciesToNode(childNode, dependency);
                    node.Nodes.Add(childNode);
                }
            }
        }

        private void btnAddDependency_Click(object sender, EventArgs e)
        {
            try
            {
                int fromRequestId = int.Parse(txtFromRequestId.Text.Trim());
                int toRequestId = int.Parse(txtToRequestId.Text.Trim());

                requestGraph.AddDependency(fromRequestId, toRequestId);
                MessageBox.Show("Dependency added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding dependency: {ex.Message}");
            }
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            try
            {
                int startRequestId = int.Parse(txtStartRequestId.Text.Trim());
                var bfsResult = requestGraph.BFS(startRequestId);

                if (bfsResult != null)
                {
                    MessageBox.Show($"BFS Traversal: {string.Join(", ", bfsResult)}");
                }
                else
                {
                    MessageBox.Show("No traversal found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error performing BFS: {ex.Message}");
            }
        }
    }
}
