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
using System.Net;
using Newtonsoft.Json.Linq;
using RestSharp;
using unirest_net.http;
using MySql.Data.MySqlClient;

namespace HarrisMichael_FinalApp
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection();


        DataTable theData = new DataTable();

        int currentR = 0;
        int addTo = 0;

        public Form1()
        {
            InitializeComponent();

            //call method to build the connection string
            string connString = DBUtils.BuildConnectionString();

            //invoke the method to make the connection
            conn = DBUtils.Connect(connString);

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

        string startApi = $"http://www.omdbapi.com/?i=tt3896198&apikey=160c8cc1";

        WebClient apiConnection = new WebClient();

        private void grabButton_Click(object sender, EventArgs e)
        {
            //Sets the textbox to the api string
            urlTB.Text = startApi;
            try
            {
                WebRequest rq = HttpWebRequest.Create("http://www.omdbapi.com/?i=tt3896198&apikey=160c8cc1&t="+TitleTB.Text);
                WebResponse rp = rq.GetResponse();
                StreamReader sr = new StreamReader(rp.GetResponseStream());

                string Movie_JSON = sr.ReadToEnd();

                Movie myM = Newtonsoft.Json.JsonConvert.DeserializeObject<Movie>(Movie_JSON);

                //Now to parse all of the data
                TitleTB.Text = myM.Title;
                YearTB.Text = myM.Year;
                RatedTB.Text = myM.Rated;
                GenreTB.Text = myM.Genre;
                DirectorTB.Text = myM.Director;

            }
            catch(Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public class Rating
        {
            public string Source { get; set; }
            public string Value { get; set; }
        }

        public class Movie
        {
            public string Title { get; set; }
            public string Year { get; set; }
            public string Rated { get; set; }
            public string Released { get; set; }
            public string Runtime { get; set; }
            public string Genre { get; set; }
            public string Director { get; set; }
            public string Writer { get; set; }
            public string Actors { get; set; }
            public string Plot { get; set; }
            public string Language { get; set; }
            public string Country { get; set; }
            public string Awards { get; set; }
            public string Poster { get; set; }
            public List<Rating> Ratings { get; set; }
            public string Metascore { get; set; }
            public string imdbRating { get; set; }
            public string imdbVotes { get; set; }
            public string imdbID { get; set; }
            public string Type { get; set; }
            public string DVD { get; set; }
            public string BoxOffice { get; set; }
            public string Production { get; set; }
            public string Website { get; set; }
            public string Response { get; set; }
        }

        private void SaveDBButton_Click(object sender, EventArgs e)
        {

            //When i click this button the current data on the form is saved to the database in the appropriate table and rows

           
            string connectionString = "server=172.16.41.1;userid=dbsAdmin;pwd=password;database=FinalProject;SslMode=none;port=8889";


            using (MySqlConnection cn = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO Movies(title, year, rating, genre, director) VALUES (@title, @year, @rating, @genre, @director)";

                    //string query = "INSERT INTO Movies(title, year, rating, genre, director) VALUES (t1, t1, t1,t1,t1)";

                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@title", TitleTB.Text);
                        cmd.Parameters.AddWithValue("@year", YearTB.Text);
                        cmd.Parameters.AddWithValue("@rating", RatedTB.Text);
                        cmd.Parameters.AddWithValue("@genre", GenreTB.Text);
                        cmd.Parameters.AddWithValue("@director", DirectorTB.Text);

                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
                catch (MySqlException em)
                {

                    MessageBox.Show(em.ToString());
                }
                
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            TitleTB.Clear();
            YearTB.Clear();
            RatedTB.Clear();
            GenreTB.Clear();
            DirectorTB.Clear();

        }
    }
}
