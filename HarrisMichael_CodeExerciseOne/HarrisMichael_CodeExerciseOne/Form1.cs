using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarrisMichael_CodeExerciseOne
{
    public partial class IPhone : Form
    {
        public IPhone()
        {
            InitializeComponent();

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

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input newI = new Input();
            newI.AddToListBox += NewI_AddToListBox;
            newI.ShowDialog();
        }

        private void NewI_AddToListBox(object sender, ClassEventArgs e)
        {
            Classs newClass = new Classs();
            newClass.Name = e.Name;
            newClass.Type = e.Type;

            if (newClass.Type)
            {
                CoreClassesLB.Items.Add(newClass);
            }
            else
            {
                SpecialClassesLB.Items.Add(newClass);
            }
        }

        private void CoreButton_Click(object sender, EventArgs e)
        {
            if (SpecialClassesLB.SelectedItem != null)
            {
                CoreClassesLB.Items.Add(SpecialClassesLB.SelectedItem);
                SpecialClassesLB.Items.RemoveAt(SpecialClassesLB.SelectedIndex);
            }
            else
            {

            }
        }
    }
}
