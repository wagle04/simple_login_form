using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using dal;
using bll;

namespace login_form
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        userbll ba = new userbll();
        userdal da = new userdal();
        DataTable dt=new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            da.username = txtname.Text;
            da.password = txtpassword.Text;
            dt = ba.loginuser(da);
            if (dt.Rows.Count>0)
            {
                Response.Redirect("home.aspx");
            }
            else
            {
                Response.Write("<script>alert('invalid username or password')</script>");
            }
        }
    }
}