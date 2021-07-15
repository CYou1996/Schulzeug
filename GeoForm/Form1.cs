using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        static Point Position = new Point(197, 66);
        static Size Size = new Size(103, 88);
        Color Color = new Color();
        CsLine geoforms = new CsLine(Position, Size, Color.Aqua);

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            geoforms.Draw(e.Graphics);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
