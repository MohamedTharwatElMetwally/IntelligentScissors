using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelligentScissors
{
    public class Node
    {
        public Pixel pixel { get; set; }
        public Pixel Parent { get; set; }
        public double Distance { get; set; }
        public int roadToParent { get; set; }

        public int HeapKey;


        public Node(int x, int y)
        {
            Pixel pixel = new Pixel();
            pixel.X = x;
            pixel.Y = y;
            this.pixel = pixel;

            Pixel parent = new Pixel();
            parent.X = -1;
            parent.Y = -1;
            this.Parent = parent;

            Distance = double.PositiveInfinity;

            roadToParent = 0;
        }
    }

    public class PriorityQueue
    {
        public int Capacity { get; set; }
        public int CurrentSize { get; set; }
        public Node[] MinHeapArr { get; set; }

        public PriorityQueue(int Capacity)
        {
            this.Capacity = Capacity;
            MinHeapArr = new Node[Capacity];
            CurrentSize = 0;
        }

        public PriorityQueue(int ImgWidth, int ImgHeight, ref Node[,] ImgNodes)
        {

            Capacity = ImgWidth * ImgHeight;
            MinHeapArr = new Node[Capacity];
            CurrentSize = 0;

            for (int i = 0; i < ImgWidth; i++)
                for (int j = 0; j < ImgHeight; j++)
                    ImgNodes[i, j].HeapKey = insert(ImgNodes[i, j]);

            for (int i = getParent(CurrentSize); i > 0; i--)
                minHeapify(i);

        }

        public bool IsEmpty()
        {
            if (CurrentSize == 0)
                return true;
            return false;
        }

        public void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public int getParent(int index)
        {
            return index / 2;
        }
        public int getLiftChild(int index)
        {
            return 2 * index;
        }
        public int getRightChild(int index)
        {
            return 2 * index + 1;
        }

        public void minHeapify(int index)
        {
            if (IsEmpty())
                return;

            int left = getLiftChild(index);
            int right = getRightChild(index);
            int smallest = index;

            if (left < CurrentSize && MinHeapArr[left].Distance < MinHeapArr[smallest].Distance)
            {
                smallest = left;
            }

            if (right < CurrentSize && MinHeapArr[right].Distance < MinHeapArr[smallest].Distance)
            {
                smallest = right;
            }

            if (smallest != index)
            {
                Swap<int>(ref MinHeapArr[smallest].HeapKey, ref MinHeapArr[index].HeapKey);
                Swap<Node>(ref MinHeapArr[smallest], ref MinHeapArr[index]);
                minHeapify(smallest);
            }

        }

        public int insert(Node newNode)
        {

            if (CurrentSize == Capacity)
                return -1;

            int index = CurrentSize;
            MinHeapArr[index] = newNode;
            CurrentSize++;

            minHeapify(index);

            return CurrentSize - 1;
        }


        public Node extractMin()
        {
            Node node = MinHeapArr[0];
            MinHeapArr[0] = MinHeapArr[CurrentSize - 1];
            MinHeapArr[0].HeapKey = 0;
            CurrentSize--;
            minHeapify(0);
            return node;
        }
    }
}
