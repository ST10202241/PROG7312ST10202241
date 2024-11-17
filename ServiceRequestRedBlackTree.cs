using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312ST10202241
{
    public class ServiceRequestRedBlackTree
    {
        private enum Color { Red, Black }

        private class Node
        {
            public ServiceRequest Request { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node Parent { get; set; }
            public Color NodeColor { get; set; }

            public Node(ServiceRequest request)
            {
                Request = request;
                NodeColor = Color.Red; // New nodes are initially red
            }
        }

        private Node root;

        // Insert a service request into the tree
        public void Insert(ServiceRequest request)
        {
            Node newNode = new Node(request);
            if (root == null)
            {
                root = newNode;
                root.NodeColor = Color.Black;
            }
            else
            {
                Node parent = FindParent(root, request.RequestId);
                if (request.RequestId < parent.Request.RequestId)
                    parent.Left = newNode;
                else if (request.RequestId > parent.Request.RequestId)
                    parent.Right = newNode;
                else
                    throw new ArgumentException("Duplicate Request ID not allowed.");

                newNode.Parent = parent;
                FixInsert(newNode);
            }
        }

        private void FixInsert(Node node)
        {
            // Fix Red-Black Tree violations
            while (node != root && node.Parent.NodeColor == Color.Red)
            {
                Node grandparent = node.Parent.Parent;
                if (node.Parent == grandparent.Left)
                {
                    Node uncle = grandparent.Right;
                    if (uncle?.NodeColor == Color.Red) // Case 1: Uncle is red
                    {
                        uncle.NodeColor = Color.Black;
                        node.Parent.NodeColor = Color.Black;
                        grandparent.NodeColor = Color.Red;
                        node = grandparent;
                    }
                    else // Case 2 & 3: Uncle is black
                    {
                        if (node == node.Parent.Right)
                        {
                            node = node.Parent;
                            RotateLeft(node);
                        }
                        node.Parent.NodeColor = Color.Black;
                        grandparent.NodeColor = Color.Red;
                        RotateRight(grandparent);
                    }
                }
                else
                {
                    Node uncle = grandparent.Left;
                    if (uncle?.NodeColor == Color.Red)
                    {
                        uncle.NodeColor = Color.Black;
                        node.Parent.NodeColor = Color.Black;
                        grandparent.NodeColor = Color.Red;
                        node = grandparent;
                    }
                    else
                    {
                        if (node == node.Parent.Left)
                        {
                            node = node.Parent;
                            RotateRight(node);
                        }
                        node.Parent.NodeColor = Color.Black;
                        grandparent.NodeColor = Color.Red;
                        RotateLeft(grandparent);
                    }
                }
            }
            root.NodeColor = Color.Black;
        }

        private void RotateLeft(Node node)
        {
            Node newParent = node.Right;
            node.Right = newParent.Left;
            if (newParent.Left != null) newParent.Left.Parent = node;
            newParent.Parent = node.Parent;
            if (node.Parent == null) root = newParent;
            else if (node == node.Parent.Left) node.Parent.Left = newParent;
            else node.Parent.Right = newParent;
            newParent.Left = node;
            node.Parent = newParent;
        }

        private void RotateRight(Node node)
        {
            Node newParent = node.Left;
            node.Left = newParent.Right;
            if (newParent.Right != null) newParent.Right.Parent = node;
            newParent.Parent = node.Parent;
            if (node.Parent == null) root = newParent;
            else if (node == node.Parent.Right) node.Parent.Right = newParent;
            else node.Parent.Left = newParent;
            newParent.Right = node;
            node.Parent = newParent;
        }

        private Node FindParent(Node node, int requestId)
        {
            if (requestId < node.Request.RequestId)
                return node.Left == null ? node : FindParent(node.Left, requestId);
            else
                return node.Right == null ? node : FindParent(node.Right, requestId);
        }

        // Search for a service request by ID
        public ServiceRequest Search(int requestId)
        {
            Node node = root;
            while (node != null)
            {
                if (requestId == node.Request.RequestId) return node.Request;
                node = requestId < node.Request.RequestId ? node.Left : node.Right;
            }
            return null;
        }
    }
}