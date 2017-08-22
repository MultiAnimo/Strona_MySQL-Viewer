using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Strona_MySQL_Viewer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Login login;

        protected void Page_Load(object sender, EventArgs e)
        {
            login = new Login();
        }

        protected void Button_Zaloguj_Click(object sender, EventArgs e)
        {
            if (login.OpenConnection(this, buildConnectionString()))
            {
                Response.Redirect("Panel.aspx");
            }
        }


        public void setStatus (string status)
        {
            La_Status.Text = status;
        }

        public string buildConnectionString ()
        {
            return $"server={FHost.Text};uid={FLogin.Text};pwd={FPassword.Text};database={FDataBase.Text}";
        }
   
    }
}