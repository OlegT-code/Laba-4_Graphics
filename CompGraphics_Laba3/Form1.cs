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

namespace CompGraphics_Laba3
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Graphics g;
        string filename = @"Strings.txt";
        string[] sm = {
            "First line", "Second line", "Third line",
            "Fourth line", "Fifth line", "Sixth line",
            "Seventh line", "Eighth line", "Ninth line",
            "Tenth line", "Eleventh line" };

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void ClearFile_Click_1(object sender, EventArgs e)
        {
            g.Clear(Color.FromArgb(255, 255, 255));
            File.Delete(filename);
            MessageBox.Show("Файл Strings.txt удалён!");
        }

        private void ShowText_Click_1(object sender, EventArgs e)
        {
            int k = 0;
            try
            {
                StreamReader f = new StreamReader(new FileStream(filename,
                FileMode.Open, FileAccess.Read));
                for (int i = 0; i < 11; i++) { sm[i] = f.ReadLine(); }
                f.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            pictureBox1.BackColor = Color.FromName("Azure");
            pictureBox1.Refresh();

            for (int i = 0; i < 11; i++)
            {
                if ((i >= 0) && (i < 8))
                {
                    Font fn = new Font("Courier Now", 18, FontStyle.Regular);
                    StringFormat sf =
                    (StringFormat)StringFormat.GenericTypographic.Clone();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Far;
                    g.DrawString(sm[i], fn, Brushes.Blue,
                    new RectangleF(0, -130 + i * 20, pictureBox1.Size.Width - 20,
                    pictureBox1.Size.Height - 20), sf);
                    fn.Dispose();
                }
                if ((i >= 8) && (i < 10))
                {
                    k = i - 9;
                    Font fn = new Font("Arial", 24, FontStyle.Italic);
                    StringFormat sf =
                    (StringFormat)StringFormat.GenericTypographic.Clone();
                    sf.FormatFlags = StringFormatFlags.DirectionVertical;
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Far;
                    g.DrawString(sm[i], fn, Brushes.Black,
                    new RectangleF(0 + k * 26, 10, pictureBox1.Size.Width - 20,
                    pictureBox1.Size.Height - 20), sf);
                    fn.Dispose();
                }
                if (i == 10)
                {
                    Font fn = new Font("Times New Roman", 50, FontStyle.Bold);
                    StringFormat sf =
                    (StringFormat)StringFormat.GenericTypographic.Clone();
                    sf.Alignment = StringAlignment.Center;

                    sf.LineAlignment = StringAlignment.Near;
                    g.DrawString(sm[i], fn, Brushes.Green,
                    new RectangleF(0, 0 + i * 5, pictureBox1.Size.Width - 20,
                    pictureBox1.Size.Height - 20), sf);
                    fn.Dispose();
                }
            }
        }

        private void InFile_Click_1(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter(new FileStream(filename,
            FileMode.Create, FileAccess.Write));

            foreach (string s in sm) { f.WriteLine(s); }
            f.Close();

            MessageBox.Show("11 строк записано в файл!");
        }
    }
}
