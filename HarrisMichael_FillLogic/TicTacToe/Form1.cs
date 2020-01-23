using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmTicTacToe : Form
    {
        // NAME: Michael Harris
        // CLASS AND TERM: DVP3 2001
        // PROJECT: Tic Tac Toe

        /* THINGS TO CONSIDER:
            - You must change the project name to conform to the required
              naming convention.
            - You must comment the code throughout.  Failure to do so could result
              in a lower grade.
            - All button names and other provided variables and controls must
              remain the same.  Changing these could result in a 0 on the project.
            - Selecting Blue or Red on the View menu should change the imageList
              attached to all buttons so that any current play will change the color
              of all button images.
            - Saved games should save to XML.  A game should load only from XML and
              should not crash the application if a user tries to load an incorrect 
              file.
        */

        public frmTicTacToe()
        {
            InitializeComponent();
            //Written by Keith Webster.  Used with permission.  Not to be distributed.  
            //Place this inside the class space in the form you would like to size.
            //Call this method AFTER InitializeComponent() inside the form's constructor.
            void HandleClientWindowSize()
            {
                //Modify ONLY these float values
                float HeightValueToChange = 1.4f;
                float WidthValueToChange = 6.0f;

                //DO NOT MODIFY THIS CODE
                int height = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Height / HeightValueToChange);
                int width = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Width / WidthValueToChange);
                if (height < Size.Height)
                    height = Size.Height;
                if (width < Size.Width)
                    width = Size.Width;
                this.Size = new Size(width, height);
                //this.Size = new Size(376, 720);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (blueToolStripMenuItem.Checked)
            {
                blueToolStripMenuItem.Checked = false;
                redToolStripMenuItem.Checked = true;

                r1c1button.ImageList = redImages;
                r1c2button.ImageList = redImages;
                r1c3button.ImageList = redImages;
                r2c1button.ImageList = redImages;
                r2c2button.ImageList = redImages;
                r2c3button.ImageList = redImages;
                r3c1button.ImageList = redImages;
                r3c2button.ImageList = redImages;
                r3c3button.ImageList = redImages;
            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (redToolStripMenuItem.Checked)
            {
                redToolStripMenuItem.Checked = false;
                blueToolStripMenuItem.Checked = true;

                r1c1button.ImageList = blueImages;
                r1c2button.ImageList = blueImages;
                r1c3button.ImageList = blueImages;
                r2c1button.ImageList = blueImages;
                r2c2button.ImageList = blueImages;
                r2c3button.ImageList = blueImages;
                r3c1button.ImageList = blueImages;
                r3c2button.ImageList = blueImages;
                r3c3button.ImageList = blueImages;
            }
        }
    }
}
