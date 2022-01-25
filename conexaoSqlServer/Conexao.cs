using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace conexaoSqlServer
{
    public class Conexao
    {
        string strCon;
        SqlConnection con;

        public Conexao()
        {
            strCon = "Data Source=WINAP0ZNJLT5TKK\\SQLEXPRESS; " +
                "Initial Catalog=conexao; " +
                "Integrated Security=True";

        }

        public SqlConnection GetConnection()
        {
            con = new SqlConnection(strCon);

            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return con;
        }
    }
}
