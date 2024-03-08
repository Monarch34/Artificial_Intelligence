using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public class Graph
    {
        int[,] adjMatrix;
        int size;
        public Graph(int nVertices)
        {
            size = nVertices;
            adjMatrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    adjMatrix[i, j] = 0;
                }
            }
        }

        public void AddEdge(int x, int y)
        {
            adjMatrix[x, y] = 1;
            adjMatrix[y, x] = adjMatrix[x, y];
        }
        public void BFS(int x)
        {
            Queue<int> queue = new Queue<int>();
            bool[] visited = new bool[size];
            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
            }

            queue.Enqueue(x);
            visited[x] = true;
            while (queue.Any())
            {
                for (int i = 0; i < size; i++)
                {
                    if (adjMatrix[queue.Peek(), i] == 1 && !visited[i])
                    {
                        queue.Enqueue(i);
                        visited[i] = true;
                    }
                }
                Console.WriteLine((queue.Dequeue()));
            }
        }
        //Recursive Algorithm
        public void DFS_1(int x)
        {
            bool[] visited = new bool[size];
            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
            }
            DFSUtil(visited, x);
        }
        private void DFSUtil(bool[] visited, int currentNode)
        {
            visited[currentNode] = true;
            Console.WriteLine(currentNode);
            for (int i = 0; i < size; i++)
            {
                if (!visited[i] && adjMatrix[currentNode, i] == 1)
                {
                    DFSUtil(visited, i);
                }
            }


        }
        //Iterative Algorithm
        public void DFS_2(int x)
        {
            bool[] visited = new bool[size];
            Stack<int> stack = new Stack<int>();
            stack.Push(x);
            while (stack.Count > 0)
            {
                int currentNode = stack.Pop();
                if (!visited[currentNode])
                {
                    Console.WriteLine(currentNode);
                    for (int i = 0; i < size; i++)
                    {
                        if (adjMatrix[currentNode, i] == 1)
                        {
                            if (!visited[i])
                            {
                                stack.Push(i);
                            }
                        }
                    }
                    visited[currentNode] = true;
                }
            }
        }

    }
}

