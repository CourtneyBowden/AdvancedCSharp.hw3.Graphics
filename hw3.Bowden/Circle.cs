using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;



namespace hw3.Bowden
{
    public class Circle: Shapes
    {
        //constructor
        public Circle(int LeftPosition, int TopPosition, int Width, int Height, Color ShapeColor, int Speed, System.Windows.Forms.Panel drwPanel)
        {
            //fill the variable values with our incoming data
            leftPosition = LeftPosition;
            topPosition = TopPosition;
            width = Width;
            height = Height;
            shapeColor = ShapeColor;
            speed = Speed;
            DrwPanel = drwPanel;
        }//end constructor

        //call the paint method
        public override void paint (Graphics graphics)
        {
            try
            {
                //save the old value of the circle position
                previousLeftPosition = leftPosition;
                previousTopPosition = topPosition;

                //put this thread to sleep
                Thread.Sleep(speed);

                //lock thread to prevent thread from running back on itself
                lock (typeof(Thread))
                {
                    leftPosition = leftPosition + base.directionX;
                    topPosition = topPosition + base.directionY;
                    base.CheckCoordinates();

                    //grouped the drawing functions together like this to slightly reduce flickering
                    graphics.DrawEllipse(new System.Drawing.Pen(Color.White), previousLeftPosition, previousTopPosition, width, height);
                    graphics.DrawEllipse(new System.Drawing.Pen(shapeColor), leftPosition, topPosition, width, height);
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
