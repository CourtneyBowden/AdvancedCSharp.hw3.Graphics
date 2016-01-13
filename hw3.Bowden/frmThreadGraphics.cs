using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace hw3.Bowden
{
    public partial class frmThreadGraphics : Form
    {
        //class level variables
        private const int shapeSize = 16;
        private string shapeType = "Circle";
        public volatile System.Windows.Forms.Panel panelDraw;
        private volatile Graphics graphics;
        public static Color shapeColor = Color.Blue;
        public Color ThreadColor;
        public static int threadCount = 0;
        private static bool blnRun = true; 

        //hashtable to keep track of threads
        private Hashtable threadHolder = new Hashtable();

        //default constructor
        public frmThreadGraphics()
        {
            InitializeComponent();

            //populate the panel variable used for drawing
            panelDraw = pnlDraw;

            //create the graphics object
            graphics = panelDraw.CreateGraphics();
        }//end default constructor

        //form load event
        private void frmThreadGraphics_Load(object sender, EventArgs e)
        {
            //use code to set default control behavior
            this.cboShape.SelectedIndex = 0;
            this.AcceptButton = btnAddShape;

            //set the panel to be double buffered to reduce flickering
            typeof(Panel).InvokeMember("DoubleBuffered",
                 BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                 null, panelDraw, new object[] { true });
        }//end form load event

        //begin new thread
        private void StartThread()
        {
            //create shapes
            Shapes shapes = new Circle(0, 0, shapeSize, shapeSize, shapeColor, GetSpeed(), panelDraw);
            switch (shapeType)
            {
                case "Triangle":
                    shapes = new Triangle(0, 0, shapeSize, shapeSize, shapeColor, GetSpeed(), panelDraw);
                    break;

                case "Rectangle":
                    shapes = new Rectangle(0, 0, shapeSize, shapeSize, shapeColor, GetSpeed(), panelDraw);
                    break;

                default:
                    //Do nothing because a circle is our default object
                    break;
            }

            //main loop
            while (true)
            {
                //check to make sure we're supposed to be running
                if (blnRun)
                {
                    try
                    {
                        //paint the shape object on each pass
                        shapes.paint(graphics);
                    }
                    catch 
                    {
                        //shut down gracefully
                        Shutdown();
                        break;
                    }
                }
            }
        }//end StartThread

        //user has pushed the btnColor and will choose a color
        private void btnColor_Click(object sender, EventArgs e)
        {
            //show the color dialog
            dlgColor.ShowDialog();
            shapeColor = dlgColor.Color;
        }//end color choice


        //user pushed the btnRusume button 
        private void btnResume_Click(object sender, EventArgs e)
        {
            //change our button text
            if (btnResume.Text == "Resume")
            {
                //change the text to Pause
                btnResume.Text = "Pause";

                //resume all threads
                Resume();
            }
            else
            {
                //change the text to Resume
                btnResume.Text = "Resume";

                //pause all threads
                Pause();

            }
        }//end resume/pause

        //AddShape_Click event
        private void btnAddShape_Click(object sender, EventArgs e)
        {
            //local variables
            shapeType = this.cboShape.Text;

            //enable the pause/resume button
            btnResume.Enabled = true;

            //Check to make sure we haven't reached our maximum thread count
            if(threadCount >= 50)
            {
                MessageBox.Show("This program is limited to a maximum of 50 threads to prevent overloading system resources.");
            }
            else
            {
                //add a new thread
                Thread thread = new Thread(new ThreadStart(StartThread));
                threadHolder.Add(threadCount++, thread);
                thread.Name = "Thread ID: " + threadCount.ToString();
                thread.IsBackground = true;
                thread.Start();
                this.lblThreadCount.Text = "Thread Count = " + threadCount.ToString();
            }
        }//end AddShape_Click event

        //pauses all threads
        private void Pause()
        {
            //thread.suspend is deprecated.  use a boolean variable to pause.
            blnRun = false; 
        }//end pause

        //resumes all threads
        private void Resume()
        {
            //thread.resume is deprecated.  use a boolean variable to resume.
            blnRun = true; 
        }//end resume

        //returns the speed the shape should move
        private int GetSpeed()
        {
            //Invert the speed displayed on the Numeric Up/Down Control
            return 105 - Convert.ToInt32(nudSpeed.Text.Trim());
        }//end GetSpeed

        //btnExit_Click event
        private void btnExit_Click(object sender, EventArgs e)
        {
            //call the shutdown function
            Shutdown();
        }//end btnExit_Click event

        //shutdown function is broken out into its own method to 
        //prevent having to pass sender and EventArgs from an error handler
        private void Shutdown()
        {
            //shut down all threads
            foreach (Thread thread in threadHolder.Values)
            {
                if (thread != null && thread.IsAlive)
                {
                    thread.Abort();
                }
            }

            //exit gracefully
            frmThreadGraphics.ActiveForm.Close();
        }//end shutdown
    }

}
