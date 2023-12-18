using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Threading;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

// Niko Huber
// IGME 201
// Final Exam

namespace question3
{
    // question 3
    internal class Program
    {

        // enum of states
        enum EadjState
        {
            red,
            grey,
            navy,
            blue,
            orange,
            yellow,
            purple,
            green
        }

        // adjacency matrix
        static bool[,] adjMatrix = new bool[,]
        {         //   R      G      N     B      O      Y      P     Gr
        /* Red    */  {false, true, true, false, false, false, false, false },
        /* Grey   */  {true, false, false, true, true, false, false, false },
        /* Navy   */  {true, false, false, true, false, true, false, false },
        /* Blue   */  {false, true, true, false, false, false, false, false },
        /* Orange */  {false, true, false, false, false, false, true, false },
        /* Yellow */  {false, false, true, false, false, false, true, true },
        /* Purple */  {false, false, false, false, true, true, false, false },
        /* Green  */  {false, false, false, false, false, true, false, false }
        };


        // list of nodes
        static List<Node> adjList = new List<Node>();

        // list of edges and adjacency for each node
        static int[][] lGraph = new int[][]
       {
            new int[] { (int)EadjState.red, (int)EadjState.navy, (int)EadjState.grey},
            new int[] { (int)EadjState.grey, (int)EadjState.blue, (int)EadjState.orange},
            new int[] { (int)EadjState.navy, (int)EadjState.blue, (int)EadjState.yellow},
            new int[] { (int)EadjState.blue, (int)EadjState.navy, (int)EadjState.grey },
            new int[] { (int)EadjState.orange, (int)EadjState.purple },
            new int[] { (int)EadjState.yellow, (int)EadjState.green },
            new int[] { (int)EadjState.purple },
            new int[] { (int)EadjState.green }
       };

        // main
        static void Main(string[] args)
        {
            // node init
            Node node;

            node = new Node((int)EadjState.red);
            adjList.Add(node);

            node = new Node((int)EadjState.grey);
            adjList.Add(node);

            node = new Node((int)EadjState.navy);
            adjList.Add(node);

            node = new Node((int)EadjState.blue);
            adjList.Add(node);

            node = new Node((int)EadjState.orange);
            adjList.Add(node);

            node = new Node((int)EadjState.yellow);
            adjList.Add(node);

            node = new Node((int)EadjState.purple);
            adjList.Add(node);

            node = new Node((int)EadjState.green);
            adjList.Add(node);

            // add edges for each node
            adjList[(int)EadjState.red].AddEdge(5, adjList[(int)EadjState.grey]);
            adjList[(int)EadjState.red].AddEdge(1, adjList[(int)EadjState.navy]);
            adjList[(int)EadjState.red].edges.Sort();

            adjList[(int)EadjState.grey].AddEdge(5, adjList[(int)EadjState.red]);
            adjList[(int)EadjState.grey].AddEdge(1, adjList[(int)EadjState.orange]);
            adjList[(int)EadjState.grey].AddEdge(0, adjList[(int)EadjState.blue]);
            adjList[(int)EadjState.grey].edges.Sort();

            adjList[(int)EadjState.navy].AddEdge(1, adjList[(int)EadjState.red]);
            adjList[(int)EadjState.navy].AddEdge(1, adjList[(int)EadjState.blue]);
            adjList[(int)EadjState.navy].AddEdge(8, adjList[(int)EadjState.yellow]);
            adjList[(int)EadjState.navy].edges.Sort();

            adjList[(int)EadjState.blue].AddEdge(1, adjList[(int)EadjState.navy]);
            adjList[(int)EadjState.blue].AddEdge(0, adjList[(int)EadjState.grey]);
            adjList[(int)EadjState.blue].edges.Sort();

            adjList[(int)EadjState.yellow].AddEdge(1, adjList[(int)EadjState.purple]);
            adjList[(int)EadjState.yellow].AddEdge(6, adjList[(int)EadjState.green]);
            adjList[(int)EadjState.yellow].AddEdge(8, adjList[(int)EadjState.navy]);
            adjList[(int)EadjState.yellow].edges.Sort();

            adjList[(int)EadjState.orange].AddEdge(1, adjList[(int)EadjState.purple]);
            adjList[(int)EadjState.orange].AddEdge(1, adjList[(int)EadjState.grey]);
            adjList[(int)EadjState.orange].edges.Sort();

            adjList[(int)EadjState.purple].AddEdge(1, adjList[(int)EadjState.yellow]);
            adjList[(int)EadjState.purple].AddEdge(1, adjList[(int)EadjState.orange]);
            adjList[(int)EadjState.purple].edges.Sort();

            adjList[(int)EadjState.green].AddEdge(6, adjList[(int)EadjState.yellow]);
            adjList[(int)EadjState.green].edges.Sort();

            // call dfs
            DFS();

            // spacing
            Console.WriteLine();

            // dijkstra
            GetShortestPathDijkstra();

        }

        // dfs util
        static void DFSUtil(int v, bool[] visited)
        {

            // write output 

            Console.Write(v + " ");

            // return if at green node
            if (v == (int)EadjState.green)
            {

                return;
            }

            // dfs loop to check child nodes
            int[] thisAdjList = lGraph[v];
            if (thisAdjList != null)
            {
                foreach (int n in thisAdjList)
                {
                    if (!visited[n])
                    {
                        visited[n] = true;
                        DFSUtil(n, visited);
                    }
                }
            }
        }

        // dfs main
        static void DFS()
        {
            // visited init
            bool[] visited = new bool[lGraph.Length];
            visited[0] = true;
            DFSUtil(0, visited);
        }

        // node class
        public class Node : IComparable<Node>
        {
            // node init 
            public int currState;
            public List<Edge> edges = new List<Edge>();

            public int minCost;
            public Node prev = null;
            public bool visited;

            // constructor and setting default state and minCost
            public Node(int currState)
            {
                this.currState = currState;
                this.minCost = int.MaxValue;
            }

            // func to add an edge between nodes
            public void AddEdge(int c, Node conn)
            {
                Edge e = new Edge(c, conn);
                edges.Add(e);
            }

            // comparasin func
            public int CompareTo(Node n)
            {
                return this.minCost.CompareTo(n.minCost);
            }
        }

        // edge class
        public class Edge : IComparable<Edge>
        {
            // edge init
            public int c;
            public Node conNode;

            // edge constructor and cost and connecting node init
            public Edge(int c, Node conNode)
            {
                this.c = c;
                this.conNode = conNode;
            }

            // comparasin func
            public int CompareTo(Edge e)
            {
                return this.c.CompareTo(e.c);
            }
        }

        // Dijkstra base
        static public void GetShortestPathDijkstra()
        {
            // set min cost of first node and first node
            adjList[(int)EadjState.red].minCost = 0;
            
            // start at red node
            Node end = DijkstraSearch(adjList[(int)EadjState.red]);

            List<Node> sPath = new List<Node>();

            BSP(sPath, end);

            sPath.Reverse();

            // final list output
            foreach (Node n in sPath)
            {
                Console.WriteLine((EadjState)n.currState);
            }
        }

        // build list
        static private void BSP(List<Node> list, Node node)
        {
            list.Add(node);

            if (node.prev == null)
            {
                return;
            }

            BSP(list, node.prev);
        }

        // main dijkstra func
        static private Node DijkstraSearch(Node current)
        {
            // variable init 
            current.visited = true;
            int currPathLen = current.minCost;
            current.minCost = int.MaxValue;

            // break and return green once current node is green
            if (current == adjList[(int)EadjState.green])
            {
                return current;
            }

            // cycle through adjacent nodes
            foreach (Edge e in current.edges)
            {
                Node neighbor = e.conNode;

                // if node is not visited
                if (!neighbor.visited)
                {
                    // adjust minCost of that path
                    if (currPathLen + e.c < neighbor.minCost)
                    {
                        neighbor.prev = current;
                        neighbor.minCost = currPathLen + e.c;
                    }
                }
            }

            // mre var init
            int minPathLen = int.MaxValue;
            Node next = null;

            // cycle through nodes and test cheapest path
            foreach(Node n in adjList)
            {
                if (n.minCost < minPathLen)
                {
                    minPathLen = n.minCost;
                    next = n;
                }
            }

            // try again with the cheapest found node 
            return DijkstraSearch(next);
        }

    }

}

