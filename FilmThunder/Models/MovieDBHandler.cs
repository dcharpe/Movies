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
    }
}