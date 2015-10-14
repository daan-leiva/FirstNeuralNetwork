using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingNeuralNetworks
{
    class NeuralNetwork
    {
        List<Node> input_nodes;
        List<Node> hidden_nodes;
        List<Node> output_nodes;
        static Random rand = new Random();

        public NeuralNetwork(int countInputNodes, int countOutputNodes, int countHiddenNodes)
        {
            input_nodes = new List<Node>();
            hidden_nodes = new List<Node>();
            output_nodes = new List<Node>();

            // add input nodes
            for (int i = 0; i < countInputNodes; i++)
                input_nodes.Add(new Node());
            // add hidden nodes
            for (int i = 0; i < countHiddenNodes; i++)
                hidden_nodes.Add(new Node());
            // add output nodes
            for (int i = 0; i < countOutputNodes; i++)
                output_nodes.Add(new Node());

            // create edges from data to input
            for (int i = 0; i < input_nodes.Count; i++)
                input_nodes[i].AddEdge(true, new Edge(null, input_nodes[i], 0));


            // create edges from input to hidden
            Edge newEdge;
            for(int i  =0; i < input_nodes.Count; i++)
                for(int j = 0; j < hidden_nodes.Count; j++)
                {
                    newEdge = new Edge(input_nodes[i], hidden_nodes[j], 0);
                }

            // create edges from hidden to output

            // create edges from output to output data
            
        }

        // TODO
        public void SetInputValues(List<double> inputs)
        {
            // validate length
            if (inputs.Count != 0)
        }

        // TODO
        public void SetOuputNodes(List<Node> output)
        {
            output_nodes = output.ToList();
        }
    }
}
