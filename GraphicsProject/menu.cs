using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicsProject.DrawingAlgorithms;
using GraphicsProject.TransformingAlgorithms;
using Tao.OpenGl;
using Tao.Platform.Windows;


namespace GraphicsProject
{
    public partial class menu : Form
    {
        string operation = "";
        public List<Point> coordinate = new List<Point>();


        public menu()
        {
            InitializeComponent();
        }



        private void draw_Click(object sender, EventArgs e)
        {

            if (circle.Checked || line.Checked || ellipse.Checked)
            {
                switch (operation)
                {
                    case "line":
                        {
                            var coordinates = coordinate = Line.BresLineOrig(new Point(int.Parse(textBox1.Text), int.Parse(textBox2.Text)), new Point(int.Parse(textBox3.Text), int.Parse(textBox4.Text)));
                            Bitmap bmp = new Bitmap(pictureBox1.Image);
                            foreach (var item in coordinates)
                            {
                                bmp.SetPixel((bmp.Size.Width - item.X) / 2, (bmp.Size.Height - item.Y) / 2, Color.Red);
                            }
                            pictureBox1.Image = bmp;


                        }
                        break;

                    case "circle":
                        {
                            var coordinates = coordinate = Circle.DrawCircle(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(R.Text));
                            Bitmap bmp = new Bitmap(pictureBox1.Image);
                            foreach (var item in coordinates)
                            {
                                bmp.SetPixel((bmp.Size.Width - item.X) / 2, (bmp.Size.Height - item.Y) / 2, Color.Red);
                            }
                            pictureBox1.Image = bmp;

                        }
                        break;

                    case "ellipse":
                        {
                            var coordinates = coordinate = Eclipse.DrawEclipse(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text), double.Parse(textBox4.Text));
                            Bitmap bmp = new Bitmap(pictureBox1.Image);
                            foreach (var item in coordinates)
                            {
                                bmp.SetPixel((bmp.Size.Width - item.X) / 2, (bmp.Size.Height - item.Y) / 2, Color.Red);
                            }
                            pictureBox1.Image = bmp;

                        }
                        break;

                }


            }

        }

        private void clean_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("empty.jpg");
            pictureBox1.Image = bmp;
            coordinate.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void line_CheckedChanged(object sender, EventArgs e)
        {
            operation = "line";

        }

        private void circle_CheckedChanged(object sender, EventArgs e)
        {
            operation = "circle";

        }

        private void ellipse_CheckedChanged(object sender, EventArgs e)
        {
            operation = "ellipse";

        }

        private void scalling_Click(object sender, EventArgs e)
        {

            if (coordinate.Count > 0)
            {
                var newCoordinates = Scaling.Scale(int.Parse(TSX.Text), int.Parse(TSY.Text), coordinate);
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                foreach (var item in newCoordinates)
                {
                    bmp.SetPixel(pictureBox1.Size.Width / 2 + item.X, (bmp.Size.Height / 2 - item.Y), Color.Red);
                }
                pictureBox1.Image = bmp;
            }


        }

        private void button25_Click(object sender, EventArgs e)
        {
            

            if (coordinate.Count > 0)
            {
                var newCoordinates = Rotation.Rotate(double.Parse(Theta.Text), coordinate);
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                foreach (var item in newCoordinates)
                {
                    bmp.SetPixel(pictureBox1.Size.Width / 2 + item.X, (bmp.Size.Height / 2 - item.Y), Color.Red);
                }
                pictureBox1.Image = bmp;
            }

        }

        private void translate_Click(object sender, EventArgs e)
        {
            if (coordinate.Count > 0)
            {
                var newCoordinates = Translation.Translate(int.Parse(TSX.Text), int.Parse(TSY.Text), coordinate);
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                foreach (var item in newCoordinates)
                {
                    bmp.SetPixel(pictureBox1.Size.Width / 2 + item.X, (bmp.Size.Height / 2 - item.Y), Color.Red);
                }
                pictureBox1.Image = bmp;
            }

        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (coordinate.Count > 0)
            {
                var newCoordinates = Share.ShareXY(int.Parse(TSX.Text), int.Parse(TSY.Text), coordinate);
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                foreach (var item in newCoordinates)
                {
                    bmp.SetPixel(pictureBox1.Size.Width / 2 + item.X, (bmp.Size.Height / 2 - item.Y), Color.Red);
                }
                pictureBox1.Image = bmp;
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {

            if (coordinate.Count > 0)
            {
                if (axis.Items.Contains("X"))
                {
                    var newCoordinates = Reflection.reflectX(coordinate);
                    Bitmap bmp = new Bitmap(pictureBox1.Image);
                    foreach (var item in newCoordinates)
                    {
                        bmp.SetPixel(pictureBox1.Size.Width / 2 + item.X, (bmp.Size.Height / 2 - item.Y), Color.Red);
                    }
                    pictureBox1.Image = bmp;
                }
                else
                {
                    var newCoordinates = Reflection.reflectY(coordinate);
                    Bitmap bmp = new Bitmap(pictureBox1.Image);
                    foreach (var item in newCoordinates)
                    {
                        bmp.SetPixel(pictureBox1.Size.Width / 2 + item.X, (bmp.Size.Height / 2 - item.Y), Color.Red);
                    }
                    pictureBox1.Image = bmp;
                
                }
            }
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (coordinate.Count > 0)
            {

                var newCoordinates = Clipping.clipLiangBarsky(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox7.Text), int.Parse(textBox6.Text), int.Parse(textBox8.Text));
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                foreach (var item in newCoordinates)
                {
                    bmp.SetPixel(pictureBox1.Size.Width / 2 + item.X, (bmp.Size.Height / 2 - item.Y), Color.Red);
                }
                pictureBox1.Image = bmp;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


    }

}
