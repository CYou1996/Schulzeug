using System.Drawing;

namespace GeoForm
{
    /// <summary>
    /// The GeoForms Class <c>BasisKlasse</c>
    /// </summary>
    public class GeoForms
    {
        public Point Position;
        public Size Size;
        public Color Color;

        public GeoForms() { }

        public GeoForms(Point Position, Size Size, Color Color)
        {
            this.Position = Position;
            this.Size = Size;
            this.Color = Color;
        }
    }

    /// <summary>
    /// The CsRectangle Class <c>SubKlasse</c>
    /// </summary>
    /// <seealso cref="GeoForm.GeoForms" />
    public class CsRectangle : GeoForms
    {

        public CsRectangle(Point Position, Size Size, Color Color) : base(Position, Size, Color)
        {

        }

        public void Draw(Graphics e)
        {
            Pen pen = new Pen(this.Color);
            e.DrawRectangle(pen, new Rectangle(this.Position, this.Size));
        }
    }

    /// <summary>
    /// The CsEllipse Class.
    /// </summary>
    /// <seealso cref="GeoForm.GeoForms" />
    public class CsEllipse : GeoForms
    {
        public CsEllipse(Point Position, Size Size, Color Color) : base(Position, Size, Color)
        {

        }

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
        public CsLine(Point Position, Size Size, Color Color) : base(Position, Size, Color)
        {

        }

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