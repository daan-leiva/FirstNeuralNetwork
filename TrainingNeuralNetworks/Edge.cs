using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingNeuralNetworks
{
    class Edge
    {
        public double edge_weight;
        public Node SourceNode;
        public Node ReceivingNode;

        public Edge(Node _source, Node _receiver, double edge_weight)
        {
            SourceNode = _source;
            ReceivingNode = _receiver;
        }
    }
}
