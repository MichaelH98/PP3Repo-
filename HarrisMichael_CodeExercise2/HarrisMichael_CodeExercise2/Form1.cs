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
using MySql.Data.MySqlClient;


namespace HarrisMichael_CodeExercise2
{
    public partial class MainWindow : Form
    {
        List<Movie> MovieList = new List<Movie>();

        MySqlConnection conn = new MySqlConnection();

        DataTable theData = new DataTable();

        int currentR = 0;
        int addTo = 0;

        public MainWindow()
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

            //call method to build the connection string
            string connString = DBUtils.BuildConnectionString();

            //invoke the method to make the connection
            conn = DBUtils.Connect(connString);

            RetrieveData();

        }
        public Movie mo
        {
            get
            {
                Movie m = new Movie();
                m.Title = titleTB.Text;
                m.Yr = yearUD.Value;
                m.Publisher = pubTB.Text;
                m.Author = authorTB.Text;
                m.Genre = genreTB.Text;
                return m;

            }
            set
            {
                titleTB.Text = value.Title;
                yearUD.Value = value.Yr;
                pubTB.Text = value.Publisher;
                authorTB.Text = value.Author;
                genreTB.Text = value.Genre;
            }
        }
        private bool RetrieveData()
        {

            string sql = "SELECT Title, YearReleased, Publisher, Author, Genre FROM SeriesTitles";

            MySqlDataAdapter adaptr = new MySqlDataAdapter(sql, conn);

            //set the command type for the select
            adaptr.SelectCommand.CommandType = CommandType.Text;

            adaptr.Fill(theData);
            foreach (DataRow d in theData.Rows)
            {
                Movie m = new Movie();

               // m.Id = int.Parse(theData.Rows[currentR]["id"].ToString());
                m.Title = theData.Rows[currentR]["Title"].ToString();
                m.Yr = decimal.Parse(theData.Rows[currentR]["YearReleased"].ToString());
                m.Publisher = theData.Rows[currentR]["Publisher"].ToString();
                m.Author = theData.Rows[currentR]["Author"].ToString();
                m.Genre = theData.Rows[currentR]["Genre"].ToString();

                ListViewItem lvi = new ListViewItem();
                lvi.Text = m.ToString();
                if (m.Genre == "Action")
                {
                    lvi.ImageIndex = 0;
                }
                else if(m.Genre == "Comedy")
                {
                    lvi.ImageIndex = 1;

                }
                else
                {
                    lvi.ImageIndex = 2;
                }
                MovieLB.Items.Add(lvi);

                lvi.Tag = m;
                currentR++;
            }
            
            conn.Close();

            return true;
        }

        private void MovieLB_DoubleClick(object sender, EventArgs e)
        {
            if (MovieLB.SelectedItems != null)
            {
                Movie m = (Movie)MovieLB.SelectedItems[0].Tag;

                titleTB.Text = m.Title;
                yearUD.Value = m.Yr;
                pubTB.Text = m.Publisher;
                authorTB.Text = m.Author;
                genreTB.Text = m.Genre;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in MovieLB.Items)
            {
                if (lvi.Selected)
                {
                    MovieLB.Items.Remove(lvi);
                }
            }
        }
    }
}
