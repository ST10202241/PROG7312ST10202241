using System;

namespace PROG7312ST10202241
{
    public class ServiceRequestBST
    {
        private class Node
        {
            public ServiceRequest Request { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(ServiceRequest request)
            {
                Request = request;
                Left = null;
                Right = null;
            }
        }

        private Node root;

        public void Insert(ServiceRequest request)
        {
            root = InsertRecursive(root, request);
        }

        private Node InsertRecursive(Node node, ServiceRequest request)
        {
            if (node == null)
                return new Node(request);

            if (request.RequestId < node.Request.RequestId)
                node.Left = InsertRecursive(node.Left, request);
            else if (request.RequestId > node.Request.RequestId)
                node.Right = InsertRecursive(node.Right, request);

            return node;
        }

        public ServiceRequest Search(int requestId)
        {
            return SearchRecursive(root, requestId);
        }

        private ServiceRequest SearchRecursive(Node node, int requestId)
        {
            if (node == null) return null;

            if (requestId == node.Request.RequestId)
                return node.Request;

            if (requestId < node.Request.RequestId)
                return SearchRecursive(node.Left, requestId);
            else
                return SearchRecursive(node.Right, requestId);
        }
    }
}
