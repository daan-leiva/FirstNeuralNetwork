using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingNeuralNetworks
{
    class Node
    {
        List<Edge> incoming_edges;
        List<Edge> outgoing_edges;
        bool isInput;
        bool IsOutput;
        bool IsEdge;

        public Node()
        {
            incoming_edges = new List<Edge>();
            outgoing_edges = new List<Edge>();
        }

        public void AddEdge(bool incoming, Edge newEdge)
        {
            if (incoming)
                incoming_edges.Add(newEdge);
            else
                outgoing_edges.Add(newEdge);
        }

        public List<Node> GetAllIncomingNodes()
        {
            List<Node> incoming_nodes = new List<Node>();
            foreach (Edge edge in incoming_edges)
                incoming_nodes.Add(edge.SourceNode);
            return incoming_nodes;
        }

        public List<Node> GetAllOutgoingNodes()
        {
            List<Node> outgoing_nodes = new List<Node>();
            foreach (Edge edge in outgoing_edges)
                outgoing_nodes.Add(edge.ReceivingNode);
            return outgoing_nodes;
        }

        public double TresholdFunctin()
        {
            double treshhold_value = 0;

            double incoming_value = incoming_edges.Sum(x => x.edge_weight);
            // apply treshold function based on inputs
            treshhold_value = 1 / (1 + Math.Pow(Math.E, -incoming_value));

            return treshhold_value;
        }
    }
}
