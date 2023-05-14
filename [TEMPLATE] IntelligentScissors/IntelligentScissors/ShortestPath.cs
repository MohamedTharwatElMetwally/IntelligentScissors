using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelligentScissors
{
    public static class ShortestPath
    {

        public static PriorityQueue Queue { get; private set; }


        public static void DijkstraSSSP(int anchorX, int anchorY)
        {
            Node[,] extractedImage;
            int newWidth = 0;
            int newHight = 0;
            int xFrom, xTo;

            int yFrom, yTo;

            xFrom = Math.Max(anchorX - 300, 0);
            xTo = Math.Min(Graph.ImgWidth, anchorX + 300);
            yFrom = Math.Max(anchorY - 300, 0);
            yTo = Math.Min(Graph.ImgHeight, anchorY + 300);

            newWidth = xTo - xFrom;
            newHight = yTo - yFrom;
            extractedImage = new Node[newWidth, newHight];

            int x = 0, y = 0;
            for (int i = xFrom; i < xTo; i++,x++)
            {
                y = 0;
                for (int j = yFrom; j < yTo; j++,y++)
                {
                    Graph.ImgNodes[i, j] = new Node(i, j);
                    extractedImage[x, y] = Graph.ImgNodes[i, j];
                }
            }

            Graph.ImgNodes[anchorX, anchorY].Distance = 0;
            Queue = new PriorityQueue(newWidth, newHight,ref extractedImage);
            

            while (!Queue.IsEmpty())
            {
                Node minNode = Queue.extractMin();
                relaxNeighborsEdges(ref minNode, Queue);
            }

            Queue = null;
        }

        public static void relaxNeighborsEdges(ref Node node, PriorityQueue queue)
        {
            if (node.pixel.X > 0)
            {
                Pixel pixel1, pixel2;
                pixel1 = node.pixel;
                pixel2.X = node.pixel.X - 1;
                pixel2.Y = node.pixel.Y;
                relaxEdge(ref node, ref Graph.ImgNodes[node.pixel.X - 1, node.pixel.Y], Graph.calcWeight(pixel1, pixel2), queue);
            }
            if (node.pixel.Y > 0)
            {
                Pixel pixel1, pixel2;
                pixel1 = node.pixel;
                pixel2.X = node.pixel.X;
                pixel2.Y = node.pixel.Y - 1;
                relaxEdge(ref node, ref Graph.ImgNodes[node.pixel.X, node.pixel.Y - 1], Graph.calcWeight(pixel1, pixel2), queue);
            }
            if (node.pixel.Y < Graph.ImgHeight - 1)
            {
                Pixel pixel1, pixel2;
                pixel1 = node.pixel;
                pixel2.X = node.pixel.X;
                pixel2.Y = node.pixel.Y + 1;
                relaxEdge(ref node, ref Graph.ImgNodes[node.pixel.X, node.pixel.Y + 1], Graph.calcWeight(pixel1, pixel2), queue);
            }
            if (node.pixel.X < Graph.ImgWidth - 1)
            {
                Pixel pixel1, pixel2;
                pixel1 = node.pixel;
                pixel2.X = node.pixel.X + 1;
                pixel2.Y = node.pixel.Y;
                relaxEdge(ref node, ref Graph.ImgNodes[node.pixel.X + 1, node.pixel.Y], Graph.calcWeight(pixel1, pixel2), queue);
            }
        }

        public static void relaxEdge(ref Node node, ref Node neighbor, double weight, PriorityQueue queue)
        {
            if (node == null || neighbor == null || (!Graph.CheckAccess[neighbor.pixel.X, neighbor.pixel.Y]))
                return;

            if (neighbor.Distance > node.Distance + weight)
            {
                neighbor.Distance = node.Distance + weight;
                Pixel temp = new Pixel();
                temp.X = node.pixel.X;
                temp.Y = node.pixel.Y;
                neighbor.Parent = temp;

                neighbor.roadToParent = node.roadToParent + 1;
                while (queue.getParent(neighbor.HeapKey) > 0 && queue.MinHeapArr[neighbor.HeapKey].Distance < queue.MinHeapArr[queue.getParent(neighbor.HeapKey)].Distance)
                {

                    queue.Swap<Node>(ref queue.MinHeapArr[neighbor.HeapKey], ref queue.MinHeapArr[queue.getParent(neighbor.HeapKey)]);
                    queue.Swap<int>(ref queue.MinHeapArr[neighbor.HeapKey].HeapKey, ref queue.MinHeapArr[queue.getParent(neighbor.HeapKey)].HeapKey);
                }
            }
        }

    }
}
