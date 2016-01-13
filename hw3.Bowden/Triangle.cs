using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

namespace hw3.Bowden
{
    public class Triangle: Shapes
    {
        //constructor
        public Triangle(int LeftPosition, int TopPosition, int Width, int Height, Color ShapeColor, int Speed, System.Windows.Forms.Panel drwPanel)
        {
            //fill the variable values with our incoming data
            leftPosition = LeftPosition;
            topPosition = TopPosition;
            width = Width;
            height = Height;
            shapeColor = ShapeColor;
            speed = Speed;
            DrwPanel = drwPanel;
        }
        //call the paint method
        public override void paint (Graphics graphics)
        {
            try
            {
                //save the old value of the triangle position
                previousLeftPosition = leftPosition;
                previousTopPosition = topPosition;
                
                //put this thread to sleep
                Thread.Sleep(speed);

                //lock thread to prevent thread from running back on itself
                lock(typeof(Thread))
                {
                    leftPosition = leftPosition + base.directionX;
                    topPosition = topPosition + base.directionY;
                    base.CheckCoordinates();

                    //draw the colored in part of the triangle
                    var drawingPen = new Pen(Color.White, 1);
                    graphics.DrawLine(drawingPen, new Point(previousLeftPosition, previousTopPosition + 16), new Point(previousLeftPosition + 8, previousTopPosition));
                    graphics.DrawLine(drawingPen, new Point(previousLeftPosition + 8, previousTopPosition), new Point(previousLeftPosition + 16, previousTopPosition + 16));
                    graphics.DrawLine(drawingPen, new Point(previousLeftPosition, previousTopPosition + 16), new Point(previousLeftPosition + 16, previousTopPosition + 16));

                    //draw the colored in part of the triangle
                    drawingPen = new Pen(shapeColor, 1);
                    graphics.DrawLine(drawingPen, new Point(leftPosition, topPosition + 16), new Point(leftPosition + 8, topPosition));
                    graphics.DrawLine(drawingPen, new Point(leftPosition + 8, topPosition), new Point(leftPosition + 16, topPosition + 16));
                    graphics.DrawLine(drawingPen, new Point(leftPosition, topPosition + 16), new Point(leftPosition + 16, topPosition + 16));
                }
            }
            catch 
            {
                //force the thread to end, but only after removing the shape from the screen
                graphics.Clear(Color.White);
                Thread.CurrentThread.Abort();
            }
        }//end paint
    }
}