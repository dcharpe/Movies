using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace FilmThunder.Models
{
    public class MovieDBHandler
    {
        private SqlConnection con;
        private void Connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["MovieConn"].ToString();
            con = new SqlConnection(constring);
        }

        public List<movie> GetAllMovie()
        {
            Connection();
            List<movie> Movielist = new List<movie>();

            SqlCommand cmd = new SqlCommand("displaydatabase", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {

                Movielist.Add(
                    new movie
                    {
                        filmName = Convert.ToString(dr["Film Name"]),
                        certName = Convert.ToString(dr["Rating Name"]),
                        genreName = Convert.ToString(dr["Genre Name"]),
                        


                    });
            }
            return Movielist;
        }
       
        public List<allmovies> DisplayAllMovies()
        {
            Connection();
            List<allmovies> Movielist = new List<allmovies>();

            SqlCommand cmd = new SqlCommand("filmsearch", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter am = new SqlDataAdapter(cmd);
            DataTable af = new DataTable();

            con.Open();
            am.Fill(af);
            con.Close();

            foreach (DataRow dr in af.Rows)
            {

                Movielist.Add(
                    new allmovies
                    {
                        filmName = Convert.ToString(dr["Film Name"]),
                        certName = Convert.ToString(dr["Rating Name"]),
                        genreName = Convert.ToString(dr["Genre Name"]),
                        producerFirstName = Convert.ToString(dr["producerFirstName"]),
                        producerLastName = Convert.ToString(dr["producerLastName"]),
                        actorFirstName = Convert.ToString(dr["actorFirstName"]),
                        actorLastName = Convert.ToString(dr["actorLastName"]),
                        roleName = Convert.ToString(dr["roleName"]),
                        /*filmRelease = date,  */


                    });
            }
            return Movielist;
        } 

    }
}