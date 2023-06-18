using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CS_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 700;
            Bmap = new Bitmap(pcbx_bg.Width, pcbx_bg.Height);
            Grap = Graphics.FromImage(Bmap);
            Grap.Clear(Color.White);
            pcbx_bg.Image = Bmap;
            Brush = new Stright_Line();
            l = new Line();
        }

        Brush Brush;
        Bitmap Bmap;
        Graphics Grap;
        ColorDialog cd = new ColorDialog();
        List<Stright_Line> Stirght_Line_list = new List<Stright_Line>();
        List<Ellipse> Ellipse_list = new List<Ellipse>();
        List<myRectangle> Rectangle_list = new List<myRectangle>();
        Line l;

        //color
        private void btn_used_color_Click(object sender, EventArgs e)
        {
            if (Brush.Status != 2)
            {
                if (cd.ShowDialog() == DialogResult.OK)
                    Brush.Color = cd.Color;
                btn_used_color.BackColor = Brush.Color;
            }
        }
        private void color_change(Color c)
        {
            Brush.Color = c;
            btn_used_color.BackColor = c;
        }
        //--color
        //INTERFACE
        private void btn_Save_img_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg |*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap BM = Bmap.Clone(new Rectangle(0, 0, pcbx_bg.Width, pcbx_bg.Height), Bmap.PixelFormat);
                BM.Save(sfd.FileName);
                MessageBox.Show("Image saved!");
            }
        }

        private void btn_save_file_Click(object sender, EventArgs e)
        {
            SaveFileDialog Dialog = new SaveFileDialog();
            Dialog.InitialDirectory = Directory.GetCurrentDirectory();
            Dialog.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            Dialog.FilterIndex = 1;
            Dialog.RestoreDirectory = true;
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(Dialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, Bmap);
                }
                MessageBox.Show("File saved!");
            }
        }
        private void btn_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.InitialDirectory = Directory.GetCurrentDirectory();
            Dialog.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            Dialog.FilterIndex = 1;
            Dialog.RestoreDirectory = true;
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(Dialog.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Bmap = (Bitmap)binaryFormatter.Deserialize(stream);
                Grap = Graphics.FromImage(Bmap);
                pcbx_bg.Image = Bmap;
                MessageBox.Show("File loaded!");
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Grap.Clear(Color.White);
            pcbx_bg.Image = Bmap;
            MessageBox.Show("canvas was cleared!");
        }
        //--interface
        //mouse
        private void pcbx_bg_MouseClick(object sender, MouseEventArgs e)
        {
            if (Brush.Status == 3)
            {
                Point point = set_point(pcbx_bg, e.Location);
                Fill(Bmap, point.X, point.Y, Brush.Color);
            }
        }
        private void pcbx_bg_MouseDown(object sender, MouseEventArgs e)
        {
            Brush.Switch = true;
            if (Brush.Status <= 2)
            {
                l.p2 = e.Location;
            }
            else if (Brush.Status == 4)
            {
                Rectangle_list.Add(new myRectangle());
                Rectangle_list[Rectangle_list.Count - 1].p1.X = e.X;
                Rectangle_list[Rectangle_list.Count - 1].p1.Y = e.Y;

            }
            else if (Brush.Status == 5)
            {
                Ellipse_list.Add(new Ellipse());
                Ellipse_list[Ellipse_list.Count - 1].p1.X = e.X;
                Ellipse_list[Ellipse_list.Count - 1].p1.Y = e.Y;

            }
            else if (Brush.Status == 6)
            {
                Stirght_Line_list.Add(new Stright_Line());
                Stirght_Line_list[Stirght_Line_list.Count - 1].pstart = e.Location;
            }
        }

        private void pcbx_bg_MouseMove(object sender, MouseEventArgs e)
        {
            if (Brush.Switch)
            {
                if (Brush.Status <= 2)
                {
                    l.p1 = e.Location;
                    l.Draw(Grap);
                    l.p2 = l.p1;
                    
                }
                else if (Brush.Status == 4)
                {
                    Rectangle_list[Rectangle_list.Count - 1].p2.X = e.X;
                    Rectangle_list[Rectangle_list.Count - 1].p2.Y = e.Y;
                    Rectangle_list[Rectangle_list.Count - 1].Width = e.X - Rectangle_list[Rectangle_list.Count - 1].p1.X;
                    Rectangle_list[Rectangle_list.Count - 1].Height = e.Y - Rectangle_list[Rectangle_list.Count - 1].p1.Y;
                }else if(Brush.Status == 5)
                {
                    Ellipse_list[Ellipse_list.Count - 1].p2.X = e.X;
                    Ellipse_list[Ellipse_list.Count - 1].p2.Y = e.Y;
                    Ellipse_list[Ellipse_list.Count - 1].Width = e.X - Ellipse_list[Ellipse_list.Count - 1].p1.X;
                    Ellipse_list[Ellipse_list.Count - 1].Height = e.Y - Ellipse_list[Ellipse_list.Count - 1].p1.Y;
                }
                else if (Brush.Status == 6)
                {
                    Stirght_Line_list[Stirght_Line_list.Count - 1].pend = e.Location;
                }
                pcbx_bg.Refresh();
            }
        }

        private void pcbx_bg_MouseUp(object sender, MouseEventArgs e)
        {
            Brush.Switch = false;
            if (Brush.Status == 4)
            {
                Rectangle_list[Rectangle_list.Count - 1].Width = Rectangle_list[Rectangle_list.Count - 1].p2.X - Rectangle_list[Rectangle_list.Count - 1].p1.X;
                Rectangle_list[Rectangle_list.Count - 1].Height = Rectangle_list[Rectangle_list.Count - 1].p2.Y - Rectangle_list[Rectangle_list.Count - 1].p1.Y;
                Rectangle_list[Rectangle_list.Count - 1].Draw(Grap);
            }
            else if(Brush.Status == 5)
            {
                Ellipse_list[Ellipse_list.Count - 1].Width = Ellipse_list[Ellipse_list.Count - 1].p2.X - Ellipse_list[Ellipse_list.Count - 1].p1.X;
                Ellipse_list[Ellipse_list.Count - 1].Height = Ellipse_list[Ellipse_list.Count - 1].p2.Y - Ellipse_list[Ellipse_list.Count - 1].p1.Y;
                Ellipse_list[Ellipse_list.Count - 1].Draw(Grap);
            }
            else if(Brush.Status == 6)
            {
                Stirght_Line_list[Stirght_Line_list.Count - 1].Draw(Grap);
            }
            pcbx_bg.Refresh();
        }
        private void pcbx_bg_Paint(object sender, PaintEventArgs e)
        {
            Graphics Grap = e.Graphics;
            if (Brush.Switch)
            {
                if (Brush.Status == 4)
                {
                    Grap.DrawRectangle(Brush.pen, Rectangle_list[Rectangle_list.Count - 1].p1.X, Rectangle_list[Rectangle_list.Count - 1].p1.Y, Rectangle_list[Rectangle_list.Count - 1].Width, Rectangle_list[Rectangle_list.Count - 1].Height);
                }
                else if(Brush.Status == 5)
                {
                    Grap.DrawEllipse(Brush.pen, Ellipse_list[Ellipse_list.Count - 1].p1.X, Ellipse_list[Ellipse_list.Count - 1].p1.Y, Ellipse_list[Ellipse_list.Count - 1].Width, Ellipse_list[Ellipse_list.Count - 1].Height);
                }
                else if(Brush.Status == 6)
                {
                    Grap.DrawLine(Brush.pen, Stirght_Line_list[Stirght_Line_list.Count - 1].pstart, Stirght_Line_list[Stirght_Line_list.Count - 1].pend);
                }
            }
        }
        //--mouse
        //buttons
        private void btn_Pen_Click(object sender, EventArgs e)
        {
            Brush.Status = 1;
            TKB_Size.Value = 1;
            TKB_Size.Maximum = 11;
        }

        private void btn_Eraser_Click(object sender, EventArgs e)
        {
            color_change(Color.White);
            Brush.Status = 2;
            TKB_Size.Value = 1;
            TKB_Size.Maximum = 11;

        }
        private void TKB_Size_Scroll(object sender, EventArgs e)
        {
            Brush.Size = (short)TKB_Size.Value;
        }

        private void btl_Ellipse_Click(object sender, EventArgs e)
        {
            Brush.Status = 5;
            Brush.Size = 5;
            TKB_Size.Value = 5;
            TKB_Size.Maximum = 30;
        }

        private void btl_Rectangle_Click(object sender, EventArgs e)
        {
            Brush.Status = 4;
            Brush.Size = 5;
            TKB_Size.Value = 5;
            TKB_Size.Maximum = 30;
        }

        private void btn_Line_Click(object sender, EventArgs e)
        {
            Brush.Status = 6;
            Brush.Size = 5;
            TKB_Size.Value = 5;
            TKB_Size.Maximum = 30;
        }

        private void btn_Fill_Click(object sender, EventArgs e)
        {
            Brush.Status = 3;
            TKB_Size.Value = 1;
            TKB_Size.Maximum = 11;
        }
        //--buttons
        //fill
        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }
        private void validate(Bitmap bmap, Stack<Point> sp, int x, int y, Color Old_Color, Color New_Color)
        {
            Color cx = bmap.GetPixel(x, y);
            if (cx == Old_Color && Old_Color != New_Color)
            {
                sp.Push(new Point(x, y));
                bmap.SetPixel(x, y, New_Color);
            }
        }
        public void Fill(Bitmap bmap, int x, int y, Color New_Color)
        {
            Color old_color = Bmap.GetPixel(x, y);
            Stack<Point> Pixel;
            if (New_Color == old_color) return;
            Pixel = new Stack<Point>();
            Pixel.Push(new Point(x, y));
            bmap.SetPixel(x, y, New_Color);
            while (Pixel.Count > 0)
            {
                Point pt = (Point)Pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bmap.Width - 1 && pt.Y < bmap.Height - 1)
                {
                    validate(bmap, Pixel, pt.X - 1, pt.Y, old_color, New_Color);
                    validate(bmap, Pixel, pt.X, pt.Y - 1, old_color, New_Color);
                    validate(bmap, Pixel, pt.X + 1, pt.Y, old_color, New_Color);
                    validate(bmap, Pixel, pt.X, pt.Y + 1, old_color, New_Color);
                }
            }
        }
        //--fill
    }
}
