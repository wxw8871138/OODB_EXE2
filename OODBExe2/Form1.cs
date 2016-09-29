using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OODBExe2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            //1

            //var q = from x in context.Movies select x;
            //dataGridView1.DataSource = q.ToList();

            dataGridView1.DataSource = context.Movies.ToList();

            //2

            //var q = from x in context.Movies orderby x.MovieTitle select x;
            //dataGridView1.DataSource = q.ToList();

            //dataGridView1.DataSource = context.Movies.OrderBy(x => x.MovieTitle).ToList();

            //3

            //var q = from x in context.Movies orderby x.RentalPrice descending select x;
            //dataGridView1.DataSource = q.ToList();

            //dataGridView1.DataSource = context.Movies.OrderByDescending(x => x.RentalPrice).ToList();

            //4

            //var q = from x in context.Movies where x.Rating =="R" select x;
            //dataGridView1.DataSource = q.ToList();

            //dataGridView1.DataSource = context.Movies.Where(x => x.Rating == "R").ToList();

            //5

            //var q = from x in context.Movies where x.MovieType == "Sci-fi" && x.Producer == "Warner" select x;
            //dataGridView1.DataSource = q.ToList();

            //dataGridView1.DataSource = context.Movies.Where(x => x.MovieType == "Sci-fi" && x.Producer == "Warner").ToList();

            //6

            //label1.Text = context.Movies.Count(x => x.MovieType == "Action").ToString();

            //7

            //label1.Text = context.Movies.Where(x => x.MovieType == "Action").Sum(x => x.TotalStock).ToString();

            //8

            //label1.Text = context.Movies.Where(x => x.MovieType == "Comedy").Average(x => x.RentalPrice).ToString();

            //9

            //var q = from x in context.Movies select new { x.VideoCode, x.MovieTitle, x.RentalPrice };
            //dataGridView1.DataSource = q.ToList();

            //dataGridView1.DataSource= context.Movies.Select(x => new { x.MovieTitle, x.VideoCode, x.Rating }).ToList();

            //10

            //var q = from x in context.Movies
            //        group x by x.MovieType into g
            //        select new { MovieType = g.Key, copies = g.Sum(y => y.TotalStock) };
            //dataGridView1.DataSource = q.ToList();

            //？？dataGridView1.DataSource = context.Movies.GroupBy(x=>x.MovieType).Select()

        }
    }
}
