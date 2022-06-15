using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace InpecTurnos.Models
{
    public class CadenaConexion
    {
        public DataSet Consultar(string cmd_SQL)
        {

            string conex = "Data Source=192.168.51.200;Initial Catalog=PruebaINPEC;User ID=sa;Password=Sql4dmin;MultipleActiveResultSets=True;Connect Timeout=100;Encrypt=False;Application Name=InpecPrueba;Current Language=spanish";
            SqlConnection con = new SqlConnection(conex);
            con.Open();
            SqlCommand cmd = new SqlCommand(cmd_SQL, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
    }

    
    
}