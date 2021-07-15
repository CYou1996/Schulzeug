using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeoForm
{
    /// <summary>
    /// The Form1 Class.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets the color.
        /// Aufgabe [5] a).
        /// </summary>
        /// <returns>The Color.</returns>
        private Color GetColor()
        {
            // Default Color.
            Color selectedColor = default(Color);

            // User Color choose.
            int inputColors = this.cmbColor.SelectedIndex;

            switch (inputColors)
            {
                case 0:
                    selectedColor = Color.Red;
                    break;
                case 1:
                    selectedColor = Color.Green;
                    break;
                case 2:
                    selectedColor = Color.Green;
                    break;
            }

            return selectedColor;
        }

        /// <summary>
        /// The geo forms.
        /// </summary>
        /// Ref Objects
        private GeoForms geoForms = new GeoForms();

        /// <summary>
        /// Handles the MouseClick event of the pictureBox1 control.
        /// Aufgabe [5] b).
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // Start Position speichern.
            if (e.Button == MouseButtons.Left)
            {
                this.geoForms.Position = e.Location;
            }
            else if (e.Button == MouseButtons.Right)
            {
                // b) Breite und Höhe berechnen.
                int width = e.Location.X - this.geoForms.Position.X;
                int height = e.Location.Y - this.geoForms.Position.Y;

                CsRectangle rechteckt = new CsRectangle(this.geoForms.Position, new Size (width, height), Color.Black);
                Graphics theGrCtx = pictureBox1.CreateGraphics();
                rechteckt.Draw(theGrCtx);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
