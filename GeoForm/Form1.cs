using System;
using System.Collections.Generic;
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
        /// The geo forms.
        /// </summary>
        /// Ref Objects
        private GeoForms geoForms = new GeoForms();

        /// <summary>
        /// The rechteckt.
        /// </summary>
        private CsRectangle rechteckt;

        /// <summary>
        /// The list of rects.
        /// </summary>
        private List<CsRectangle> rects;

        /// <summary>
        /// The list of ellipses.
        /// </summary>
        private List<CsEllipse> ellipses;

        /// <summary>
        /// The list of lines.
        /// </summary>
        private List<CsLine> lines;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();

            // Init.
            this.rects = new List<CsRectangle>();
            this.ellipses = new List<CsEllipse>();
            this.lines = new List<CsLine>();
        }

        /// <summary>
        /// Gets the color.
        /// Aufgabe [5] a).
        /// </summary>
        /// <returns>The Color.</returns>
        private Color GetColor()
        {
            // Default Color.
            Color selectedColor = Color.Black;

            // User Color choose.
            int inputColors = this.cmbColor.SelectedIndex;

            switch (inputColors)
            {
                case 0:
                    selectedColor = Color.Red;
                    break;
                case 1:
                    selectedColor = Color.Blue;
                    break;
                case 2:
                    selectedColor = Color.Black;
                    break;
                case 3:
                    selectedColor = Color.Yellow;
                    break;
            }

            return selectedColor;
        }

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

                // Je nach dem welche Form ausgewählt ist.
                switch (this.comboBox1.SelectedIndex)
                {
                    case 0:
                        // Neues Objekt von Rechteck.
                        this.rechteckt = new CsRectangle(this.geoForms.Position.X, this.geoForms.Position.Y, width, height, this.GetColor());

                        // Die Rechtecke in die Liste speichern.
                        this.rects.Add(this.rechteckt);

                        // New Object von Graphic Objekt.
                        // "Using" um die Graphic Object zu leeren.
                        using (Graphics theGrCtx = this.pictureBox1.CreateGraphics())
                        {
                            // Rechteck zeichnen.
                            this.rechteckt.Draw(theGrCtx);
                        }

                        break;
                    default:
                        break;
                }

            }
        }

        /// <summary>
        /// Handles the Paint event of the pictureBox1 control.
        /// Aufgabe [5] c).
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // New Object von Graphic Objekt.
            Graphics theGrCtx = e.Graphics;

            // Rechteck zeichnen.
            if (this.rechteckt != null)
            {
                this.rechteckt.Draw(theGrCtx);
            }
        }
    }
}
