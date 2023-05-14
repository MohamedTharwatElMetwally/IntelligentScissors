using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace IntelligentScissors
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        RGBPixel[,] ImgMatrix;
        Bitmap ImageCopy;
        Pixel curentClick;
        Pixel previousClick;
        bool isAnchorPixel;
        bool check_access;

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the browsed image and display it
                string OpenedFilePath = openFileDialog1.FileName;
                ImgMatrix = ImageOperations.OpenImage(OpenedFilePath);
                ImageOperations.DisplayImage(ImgMatrix, originalImage);
                Graph.constructGraph(ImgMatrix);
            }
            txtWidth.Text = ImageOperations.GetWidth(ImgMatrix).ToString();
            txtHeight.Text = ImageOperations.GetHeight(ImgMatrix).ToString();

            //======================== 
            ImageCopy = new Bitmap(originalImage.Image);
            isAnchorPixel = check_access = false;
        }
                                         

        private void MouseMove(object sender, MouseEventArgs e)    
        {
            mouse_x_position.Text = e.X.ToString();
            mouse_y_position.Text = e.Y.ToString();

            if (isAnchorPixel == true)
            {
                curentClick.X = e.X;
                curentClick.Y = e.Y;
                originalImage.Image = (Bitmap)ImageCopy.Clone();
                originalImage.Refresh();
                if (Graph.ImgNodes[curentClick.X, curentClick.Y] == null)
                    return;

                Draw();
            }
        }

       private void MouseClick(object sender, MouseEventArgs e)
        {

            anchor_x.Text = e.X.ToString();
            anchor_y.Text = e.Y.ToString();

            Pixel anchorPosition;
            anchorPosition.X = e.X;
            anchorPosition.Y = e.Y;


            if (e.Button == MouseButtons.Right)
            {
                mouseClick(anchorPosition);


                isAnchorPixel = false;
                for (int i = 0; i < Graph.ImgWidth; i++)
                    for (int j = 0; j < Graph.ImgHeight; j++)
                        Graph.CheckAccess[i, j] = true;
            }

            mouseClick(anchorPosition);
        }


        private void mouseClick(Pixel e)
        {

            if (isAnchorPixel == false)
            {
                isAnchorPixel = true;
                previousClick.X = e.X;
                previousClick.Y = e.Y;
            }
            else
            {
                originalImage.Refresh();
                curentClick.X = e.X;
                curentClick.Y = e.Y;
                check_access = true;
                Draw();
                check_access = false;
                ImageCopy = (Bitmap)originalImage.Image;
                previousClick = curentClick;
            }

            ShortestPath.DijkstraSSSP(previousClick.X, previousClick.Y);
        }

        //public void drawPoint(int x, int y, int size, Color color)
        //{
        //    Graphics g = Graphics.FromHwnd(originalImage.Handle);
        //    SolidBrush brush = new SolidBrush(color);
        //    Point dPoint = new Point(x, y);
        //    Rectangle rect = new Rectangle(dPoint, new Size(size, size));
        //    g.FillRectangle(brush, rect);
        //    g.Dispose();
        //}

        private void Draw()
        {
            Node node = new Node(0, 0);
            Node parent = new Node(0, 0);
            node = Graph.ImgNodes[curentClick.X, curentClick.Y];
            if (node == null)
                return;

            Graphics G = Graphics.FromImage(originalImage.Image);

            while ((node.Parent.X != -1 && node.Parent.Y != -1) && (node.Parent.X != previousClick.X || node.Parent.Y != previousClick.Y))
            {
                parent = Graph.ImgNodes[(int)node.Parent.X, (int)node.Parent.Y];
                if (check_access == true)
                    Graph.CheckAccess[parent.pixel.X, parent.pixel.Y] = false;
                using (var p = new Pen(Color.Yellow, 2))
                {

                    G.DrawLine(p, new Point(node.pixel.X, node.pixel.Y), new Point(parent.pixel.X, parent.pixel.Y));

                }
                node = parent;

            }

            originalImage.Refresh();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ImageOperations.DisplayImage(ImgMatrix, originalImage);
            Graph.constructGraph(ImgMatrix);
            ImageCopy = new Bitmap(originalImage.Image);
            isAnchorPixel = check_access = false;
        }

        private void autoAnchor_Click(object sender, EventArgs e)
        {

        }

        private void crop_Click(object sender, EventArgs e)
        {

        }
    }
}