namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(7);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(2, 4);
            g.AddEdge(2, 3);
            g.AddEdge(3, 6);
            g.AddEdge(4, 6);
            g.AddEdge(4, 5);
            g.DFS_1(0);
            Console.WriteLine();
            g.DFS_2(0);
        }
    }
}
