using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace HarrisMichael_CodeExerciseOne
{
    public partial class IPhone : Form
    {
        List<Classs> cList = new List<Classs>();

        List<string> classList = new List<string>()
        {
            "Creative Presentation",
            "Psycology Of Play",
            "TEM",
            "English",
            "Discrete Math",
            "Intro To Development 1",
            "Intro To Development 2",
            "Application Development",
            "PP1",
            "EMI",
            "Interface Programming",
            "Physical Science",
            "Apple Programming",
            "IOS Development",
            "IOS Development 2",
            "Statistics",
            "PP3",
            "Google Programming",
            "Android Development",
            "PP4",
            "Android Development 2",
            "PP5",
            "Intergrated Product Development",
            "PP6"
        };

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

        //Subscription to pass the data
        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Input newI = new Input();
            newI.AddToListBox += NewI_AddToListBox;
            newI.Show();
        }

        private void NewI_AddToListBox(object sender, ClassEventArgs e)
        {
           //Create the class and set they name and class type
            Classs newClass = new Classs();
            newClass.Name = e.Name;
            newClass.Type = e.Type;

            //Logic for which listbox to add class to
            if (newClass.Type)
            {
                CoreClassesLB.Items.Add(newClass);
            }
            else
            {
                SpecialClassesLB.Items.Add(newClass);
            }
        }

        //Button for moving the selected item to Core
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

        //Button for moving the selected item to Special
        private void SpecialButton_Click(object sender, EventArgs e)
        {
            if (CoreClassesLB.SelectedItem != null)
            {
                SpecialClassesLB.Items.Add(CoreClassesLB.SelectedItem);
                CoreClassesLB.Items.RemoveAt(CoreClassesLB.SelectedIndex);
            }
            else
            {

            }
        }

        //Delete Button
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //If the item isnt null then delete the from the listbox
            if (CoreClassesLB.SelectedItem != null)
            {
                CoreClassesLB.Items.Remove(CoreClassesLB.SelectedItem);
            }
            else if (SpecialClassesLB.SelectedItem != null)
            {
                SpecialClassesLB.Items.Remove(SpecialClassesLB.SelectedItem);
            }
            else
            {

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Code for saving the data
        private void saveListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDLG = new SaveFileDialog();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt) |*.txt |All files (*.*) |*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sr = new StreamWriter(saveFileDialog.FileName))
                {
                    sr.WriteLine(classList);
                }
            }
        }

        //Loading Data code
        private void loadListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            var fileContent = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt) | *.txt| All files (*.*) | *.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }
    }
}
