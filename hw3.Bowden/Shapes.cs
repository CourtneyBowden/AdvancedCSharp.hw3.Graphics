using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;


namespace hw3.Bowden
{
    public abstract class Shapes
    {
        //class level variables
        protected int leftPosition;
        protected int topPosition;
        protected int width;
        protected int height;
        protected  Color shapeColor;
        protected int directionY = 1;
        protected int directionX = 1;
        protected int speed;
        protected int previousLeftPosition;
        protected int previousTopPosition;
        protected System.Windows.Forms.Panel DrwPanel;

        //default constructor
        public Shapes()
        {

        }
        //abstract paint event
        public abstract void paint(Graphics graphics);

        //check to make sure we don't bounce into the edge of panel
        public void CheckCoordinates()
        {
            if ((DrwPanel.Size.Height - 20 < topPosition) || (topPosition <= 0)) directionY = directionY * (-1);
            if ((DrwPanel.Size.Width - 20 < leftPosition) || (leftPosition <= 0)) directionX = directionX * (-1);
        }//end CheckCoordinates
    }
}
