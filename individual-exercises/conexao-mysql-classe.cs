using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projeto_BD
{
    internal class ConexaoAluno
    {
        MySqlConnection con;

        public void ConectarBD()
        {
            try
            {
                con = new MySqlConnection("Persist Security info=false; server = localhost;" + "database=escola;user = root; pwd=;");

                con.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void executarcomandos(string sql)
        {
            try
            {
                ConectarBD();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public DataTable exercutarconsulta(string sql)
        {
            try
            {
                ConectarBD();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }

}