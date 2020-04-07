using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabalho_04_04
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admim" && txtSenha.Text == "1234")
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}
