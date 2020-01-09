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
    public partial class Input : Form
    {
        public event EventHandler<ClassEventArgs> AddToListBox;

        public Input()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddToListBox != null)
            {
                ClassEventArgs args = new ClassEventArgs();

                args.Name = ClassNameTB.Text;
                args.Type = CoreClassCB.Checked;

                AddToListBox(this, args);
            }
        }
    }
}
