using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoForm
{
    public class GeoForms
    {
        public Point Position;
        public Size Size;
        public Color Color;

        public GeoForms(Point Position, Size Size, Color Color)
        {
            this.Position = Position;
            this.Size = Size;
            this.Color = Color;
        }
    }


        //Aufgabe 1
        /*public void Draw(Graphics e)
        {
            Pen pen = new Pen(Colour);
            //e.

        }*/



        public class CsRectangle : GeoForms
        {

            public CsRectangle(Point Position, Size Size, Color Color) : base(Position, Size, Color)
            {

            }
            public void Draw( Graphics e)
            {
                Pen pen = new Pen(this.Color);
                e.DrawRectangle(pen, new Rectangle(Position, Size));
            }
        }

        public class CsEllipse : GeoForms
        {
            public CsEllipse(Point Position, Size Size, Color Color) : base(Position, Size, Color)
            {

            }

            public void Draw(Graphics e)
            {
                Pen pen = new Pen(this.Color);
                e.DrawEllipse(pen, new Rectangle(Position, Size));
            }
        }

        public class CsLine : GeoForms
        {
            public CsLine(Point Position, Size Size, Color Color) : base(Position, Size, Color)
            {

            }
            public void Draw(Graphics e)
            {
            int pointNewX = Position.X + Size.Width;
            int pointNewY = Position.Y + Size.Height;

                Point Endpunkt = new Point(pointNewX, pointNewY);
               
                Pen pen = new Pen(this.Color);
                e.DrawLine(pen, Position, Endpunkt);
            }



        }
    }

