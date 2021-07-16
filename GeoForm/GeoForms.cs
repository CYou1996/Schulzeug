// <copyright file="GeoForms.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Drawing;

namespace GeoForm
{
    /// <summary>
    /// The GeoForms Class <c>BasisKlasse</c>
    /// </summary>
    public class GeoForms
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoForms"/> class.
        /// </summary>
        public GeoForms() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoForms"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="color">The color.</param>
        public GeoForms(int x, int y, int width, int height, Color color)
        {
            this.Position = new Point(x,y);
            this.Size = new Size(width, height);
            this.Color = color;
        }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public Point Position { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public Size Size { get; set; }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        public Color Color { get; set; }
    }

    /// <summary>
    /// The CsRectangle Class <c>SubKlasse</c>
    /// </summary>
    /// <seealso cref="GeoForm.GeoForms" />
    public class CsRectangle : GeoForms
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsRectangle"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="color">The color.</param>
        public CsRectangle(int x, int y, int width, int height, Color color)
            : base(x, y, width, height, color)
        {
            // Aufgabe [6].
            if (width < 0)
            {

                width = -width;


                if (x < 0)
                {
                    x = -x;
                }

            }
            if (height < 0) {
                height = -height;

                if (y < 0)
                {
                    y = -y;
                }
            }
        }

        /// <summary>
        /// Draws the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(this.Color);
            g.DrawRectangle(pen, new Rectangle(this.Position, this.Size));
        }
    }

    /// <summary>
    /// The CsEllipse Class.
    /// </summary>
    /// <seealso cref="GeoForm.GeoForms" />
    public class CsEllipse : GeoForms
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsEllipse"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="color">The color.</param>
        public CsEllipse(int x, int y, int width, int height, Color color)
            : base(x, y, width, height, color) { }

        public void Draw(Graphics e)
        {
            Pen pen = new Pen(this.Color);
            e.DrawEllipse(pen, new Rectangle(this.Position, this.Size));
        }
    }

    /// <summary>
    /// The CsLine Class.
    /// </summary>
    /// <seealso cref="GeoForm.GeoForms" />
    public class CsLine : GeoForms
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsLine"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="color">The color.</param>
        public CsLine(int x, int y, int width, int height, Color color)
            : base(x, y, width, height, color) { }

        public void Draw(Graphics e)
        {
            int pointNewX = this.Position.X + this.Size.Width;
            int pointNewY = this.Position.Y + this.Size.Height;

            Point endpunkt = new Point(pointNewX, pointNewY);

            Pen pen = new Pen(this.Color);
            e.DrawLine(pen, this.Position, endpunkt);
        }
    }
}