using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal;
using System.Data;
using System.Data.SqlClient;


namespace bll
{
    public class userbll
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\user\Desktop\ASP College Project\other projects\login_form\login_form\App_Data\login_form_db.mdf';Integrated Security=True");

        public DataTable loginuser(userdal da)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand com = new SqlCommand("select * from users where username='"+da.username+"' and password='"+da.password+"'",con);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            sda.Fill(dt);
            return dt;
        }
    }
}
