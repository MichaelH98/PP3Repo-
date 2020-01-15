using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisMichael_CodeExercise2
{
    public class Movie
    {
        int id;
        string title;
        decimal yr;
        string publisher;
        string author;
        string genre;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public decimal Yr { get => yr; set => yr = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Author { get => author; set => author = value; }
        public string Genre { get => genre; set => genre = value; }

        public override string ToString()
        {
            return Title;
        }
    }
}
