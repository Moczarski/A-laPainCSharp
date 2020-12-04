using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie3_Mateusz_Moczarski
{
    public partial class MoczarskiPaint : Form
    {
        public MoczarskiPaint()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            g = Graphics.FromImage(bitmap);
            comboBoxFigury.SelectedIndex = 0;
            comboBoxWidth.SelectedIndex = 0;
        }

        Bitmap bitmap;
        Image image;
        Graphics g;
        int? iniX = null;
        int? iniY = null;
        int wspX;
        int wspY;
        int width;
        int size;
        bool drawPen = false;
        bool drawPunkt = false;
        bool drawKoło = false;
        bool drawKwadrat = false;
        bool drawElipsa = false;
        bool drawŁuk = false;
        bool drawWycinek = false;
        bool drawWielokąt = false;
        bool drawKrzywa = false;
        bool gumka = false;
        string caseSwitch;

        private void PointerMove(object sender, MouseEventArgs e)
        {
            if (drawPen)
            {
                Pen pen = new Pen(buttonColor.BackColor, width);
                g.DrawLine(pen, new Point(iniX ?? e.X, iniY ?? e.Y), new Point(e.X, e.Y));
                iniX = e.X;
                iniY = e.Y;
                pictureBox1.Invalidate();
            }
            if (gumka)
            {
                Pen pen = new Pen(pictureBox1.BackColor, size);
                g.DrawLine(pen, new Point(iniX ?? e.X, iniY ?? e.Y), new Point(e.X, e.Y));
                iniX = e.X;
                iniY = e.Y;
                pictureBox1.Invalidate();
            }

            string wspX = e.X.ToString();
            string wspY = e.Y.ToString();
            toolStripStatusLabel1.Text = caseSwitch+", "+buttonColor.BackColor+", "+comboBoxWidth.SelectedItem.ToString()+", X:"+wspX+", Y:"+wspY;
        }

        private void PointerDown(object sender, MouseEventArgs e)
        {
            try
            {
                wspX = e.X;
                wspY = e.Y;
                if (comboBoxWidth.SelectedItem.ToString() == "cienki")
                {
                    width = 1;
                }
                else if (comboBoxWidth.SelectedItem.ToString() == "normalny")
                {
                    width = 2;
                }
                else if (comboBoxWidth.SelectedItem.ToString() == "gruby")
                {
                    width = 4;
                }

                if (String.IsNullOrEmpty(textBoxSize.Text))
                {
                    MessageBox.Show("Wprowadź rozmiar figury!");
                } else
                {
                    try
                    {
                        size = int.Parse(textBoxSize.Text);
                    } catch
                    {
                        MessageBox.Show("Wprowadź poprawny rozmiar figury!");
                    }
                }

                if (comboBoxFigury.SelectedItem.ToString() == "rysowanie")
                {
                    drawPen = true;
                    gumka = false;
                }
                if (comboBoxFigury.SelectedItem.ToString() == "gumka")
                {
                    drawPen = false;
                    gumka = true;
                }
                pictureBox1.Invalidate();
            } catch
            {
                MessageBox.Show("Wybierz narzędzie, figurę lub grubość!");
            }
            
        }

        private void PointerUp(object sender, MouseEventArgs e)
        {
            drawPen = false;
            gumka = false;
            iniX = null;
            iniY = null;
            try
            {
                if (drawPunkt)
                {
                    SolidBrush sb = new SolidBrush(buttonColor.BackColor);
                    g.FillEllipse(sb, e.X, e.Y, size, size);
                    drawPen = false;
                }
                if (drawKoło)
                {
                    if (checkBoxFill.Checked)
                    {
                        SolidBrush sb = new SolidBrush(buttonColor.BackColor);
                        g.FillEllipse(sb, wspX, wspY, Math.Abs(e.X - wspX), Math.Abs(e.Y - wspY));
                    }
                    else
                    {
                        Pen pen = new Pen(buttonColor.BackColor, width);
                        g.DrawEllipse(pen, wspX, wspY, Math.Abs(e.X - wspX), Math.Abs(e.Y - wspY));
                    }
                    drawPen = false;
                }
                if (drawKwadrat)
                {
                    if (checkBoxFill.Checked)
                    {
                        SolidBrush sb = new SolidBrush(buttonColor.BackColor);
                        g.FillRectangle(sb, wspX, wspY, Math.Abs(e.X - wspX), Math.Abs(e.Y - wspY));
                    }
                    else
                    {
                        Pen pen = new Pen(buttonColor.BackColor, width);
                        g.DrawRectangle(pen, wspX, wspY, Math.Abs(e.X - wspX), Math.Abs(e.Y - wspY));
                    }
                    drawPen = false;
                }
                if (drawElipsa)
                {
                    if (checkBoxFill.Checked)
                    {
                        SolidBrush sb = new SolidBrush(buttonColor.BackColor);
                        g.FillEllipse(sb, wspX, wspY, 2 * Math.Abs(e.X - wspX), Math.Abs(e.Y - wspY));
                    }
                    else
                    {
                        Pen pen = new Pen(buttonColor.BackColor, width);
                        g.DrawEllipse(pen, wspX, wspY, 2 * Math.Abs(e.X - wspX), Math.Abs(e.Y - wspY));
                    }
                    drawPen = false;
                }
                if (drawŁuk)
                {
                    Pen pen = new Pen(buttonColor.BackColor, width);
                    g.DrawArc(pen, wspX, wspY, Math.Abs(e.X - wspX), Math.Abs(e.Y - wspY), Math.Abs(e.X - wspX), Math.Abs(e.Y - wspY));
                    drawPen = false;
                }
                if (drawWycinek)
                {
                    if (checkBoxFill.Checked)
                    {
                        SolidBrush sb = new SolidBrush(buttonColor.BackColor);
                        g.FillPie(sb, wspX, wspY, Math.Abs(e.X - wspX), Math.Abs(e.Y - wspY), Math.Abs(e.X - wspX), Math.Abs(e.Y - wspY));
                    }
                    else
                    {
                        Pen pen = new Pen(buttonColor.BackColor, width);
                        g.DrawPie(pen, wspX, wspY, Math.Abs(e.X - wspX), Math.Abs(e.Y - wspY), Math.Abs(e.X - wspX), Math.Abs(e.Y - wspY));
                    }
                    drawPen = false;
                }
                if (drawWielokąt)
                {
                    Point[] p = {
                        new Point(wspX, wspY),
                        new Point((wspX+e.X)/4, wspY+e.Y/7),
                        new Point((wspX+e.X)/3, wspY+e.Y/5),
                        new Point((wspX+e.X)/2, wspY+e.Y/3),
                        new Point(e.X, e.Y)
                    };
                    if (checkBoxFill.Checked)
                    {
                        SolidBrush sb = new SolidBrush(buttonColor.BackColor);
                        g.FillPolygon(sb, p);
                    }
                    else
                    {
                        Pen pen = new Pen(buttonColor.BackColor, width);
                        g.DrawPolygon(pen, p);
                    }
                    drawPen = false;
                }
                if (drawKrzywa)
                {
                    Point[] p = {
                           new Point(wspX, wspY),
                           new Point(e.X-wspX, e.Y+wspY),
                           new Point(e.X-wspX/2, e.Y-wspY/2),
                           new Point(e.X, e.Y)
                        };

                    Pen pen = new Pen(buttonColor.BackColor, width);
                    g.DrawBeziers(pen, p);
                    drawPen = false;
                }
                pictureBox1.Invalidate();
            } catch
            {
                toolStripStatusLabel1.Text = "Coś poszło źle...";
            }
            
        }

        private void Color(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = c.Color;
            }
        }

        private void FigureIsChanged(object sender, EventArgs e)
        {
            WhichFigure();
        }

        private void WhichFigure()
        {
            caseSwitch = comboBoxFigury.SelectedItem.ToString();
            switch (caseSwitch)
            {
                case "punkt":
                    drawPunkt = true;
                    drawKoło = false;
                    drawKwadrat = false;
                    drawElipsa = false;
                    drawŁuk = false;
                    drawWycinek = false;
                    drawWielokąt = false;
                    drawKrzywa = false;
                    gumka = false;
                    break;
                case "koło":
                    drawPunkt = false;
                    drawKoło = true;
                    drawKwadrat = false;
                    drawElipsa = false;
                    drawŁuk = false;
                    drawWycinek = false;
                    drawWielokąt = false;
                    drawKrzywa = false;
                    gumka = false;
                    break;
                case "kwadrat":
                    drawPunkt = false;
                    drawKoło = false;
                    drawKwadrat = true;
                    drawElipsa = false;
                    drawŁuk = false;
                    drawWycinek = false;
                    drawWielokąt = false;
                    drawKrzywa = false;
                    gumka = false;
                    break;
                case "elipsa":
                    drawPunkt = false;
                    drawKoło = false;
                    drawKwadrat = false;
                    drawElipsa = true;
                    drawŁuk = false;
                    drawWycinek = false;
                    drawWielokąt = false;
                    drawKrzywa = false;
                    gumka = false;
                    break;
                case "łuk":
                    drawPunkt = false;
                    drawKoło = false;
                    drawKwadrat = false;
                    drawElipsa = false;
                    drawŁuk = true;
                    drawWycinek = false;
                    drawWielokąt = false;
                    drawKrzywa = false;
                    gumka = false;
                    break;
                case "wycinek koła":
                    drawPunkt = false;
                    drawKoło = false;
                    drawKwadrat = false;
                    drawElipsa = false;
                    drawŁuk = false;
                    drawWycinek = true;
                    drawWielokąt = false;
                    drawKrzywa = false;
                    gumka = false;
                    break;
                case "wielokąt":
                    drawPunkt = false;
                    drawKoło = false;
                    drawKwadrat = false;
                    drawElipsa = false;
                    drawŁuk = false;
                    drawWycinek = false;
                    drawWielokąt = true;
                    drawKrzywa = false;
                    gumka = false;
                    break;
                case "krzywa beziera":
                    drawPunkt = false;
                    drawKoło = false;
                    drawKwadrat = false;
                    drawElipsa = false;
                    drawŁuk = false;
                    drawWycinek = false;
                    drawWielokąt = false;
                    drawKrzywa = true;
                    gumka = false;
                    break;
                default:
                    drawPunkt = false;
                    drawKoło = false;
                    drawKwadrat = false;
                    drawElipsa = false;
                    drawŁuk = false;
                    drawWycinek = false;
                    drawWielokąt = false;
                    drawKrzywa = false;
                    gumka = false;
                    break;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            try
            {
                g.Clear(pictureBox1.BackColor);
                pictureBox1.Image = null;
                bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = bitmap;
                g = Graphics.FromImage(bitmap);
            } catch
            {
                toolStripStatusLabel1.Text = "Nie można wyczyścić ekranu!";
            }
            
        }

        private void SizeIsChanged(object sender, EventArgs e)
        {
            try
            {
                if (bitmap != null)
                {
                    if (image != null)
                    {
                        bitmap = new Bitmap(image, pictureBox1.Width, pictureBox1.Height);
                    }
                    else
                    {
                        bitmap = new Bitmap(bitmap, pictureBox1.Width, pictureBox1.Height);
                    }
                    g = Graphics.FromImage(bitmap);
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    pictureBox1.Image = bitmap;
                    image = bitmap;
                }
            } catch
            {
                toolStripStatusLabel1.Text = "Nie można poprawnie zmienić rozmiaru!";
            }
            
        }

        private void OtwórzJakoTłoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|" + "All files (*.*)|*.*";
                string file = openFileDialog1.FileName;
                try
                {
                    if (System.IO.Path.GetExtension(file) == ".bmp" || System.IO.Path.GetExtension(file) == ".png" || System.IO.Path.GetExtension(file) == ".jpg" || System.IO.Path.GetExtension(file) == ".gif")
                    {
                        image = Image.FromFile(file);
                        Bitmap bmp = new Bitmap(image, pictureBox1.Width, pictureBox1.Height);
                        g = Graphics.FromImage(bmp);
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        pictureBox1.Image = bmp;
                        image = bmp;
                        toolStripStatusLabel1.Text = "Otwarto: " + file;
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Wybierz plik JPG, BMP lub PNG!";
                    }
                }
                catch
                {
                    toolStripStatusLabel1.Text = "Problem z plikiem!";
                }
            }
        }

        private void ZapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox1.Image.Save(sfd.FileName, format);
                }
                toolStripStatusLabel1.Text = "Zapisano w "+sfd.FileName;
            } catch
            {
                toolStripStatusLabel1.Text = "Nie udało się zapisać obrazu!";
            }
        }
    }   
}