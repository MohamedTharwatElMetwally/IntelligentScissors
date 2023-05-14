using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelligentScissors
{
    public struct Pixel
    {
        public int X;
        public int Y;
    }

    
    public static class Graph
    {
      
        public static int ImgWidth { get; set; }
        public static int ImgHeight { get; set; }
        public static RGBPixel[,] ImgMatrix { get; set; }
        public static Node[,] ImgNodes { get; set; }
        public static bool[,] CheckAccess { get; set; }


        public static void constructGraph(RGBPixel[,] ImgMatrix)
        {

            ImgWidth = ImageOperations.GetWidth(ImgMatrix);
            ImgHeight = ImageOperations.GetHeight(ImgMatrix);

            Graph.ImgMatrix = ImgMatrix;
            
            ImgNodes = new Node[ImgWidth, ImgHeight];
            CheckAccess = new bool[ImgWidth, ImgHeight];

            for (int i = 0; i < ImgWidth; i++)
            {
                for (int j = 0; j < ImgHeight; j++)
                {
                    CheckAccess[i, j] = true;
                }
            }
        }


        public static double calcWeight(Pixel pixel1,Pixel pixel2)
        {

            double weight;

            if (pixel1.X < pixel2.X) 
                weight = ImageOperations.CalculatePixelEnergies(pixel1.X, pixel1.Y, ImgMatrix).X;
            else if (pixel1.X > pixel2.X) 
                weight = ImageOperations.CalculatePixelEnergies(pixel2.X, pixel2.Y, ImgMatrix).X;
            else if (pixel1.Y < pixel2.Y) 
                weight = ImageOperations.CalculatePixelEnergies(pixel1.X, pixel1.Y, ImgMatrix).Y;
            else 
                weight = ImageOperations.CalculatePixelEnergies(pixel2.X, pixel2.Y, ImgMatrix).Y;


            if (weight != 0)
                return 1.0 / weight;
            else
                return double.PositiveInfinity;

        }

    }
}
