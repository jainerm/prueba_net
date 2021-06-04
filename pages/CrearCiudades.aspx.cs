using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using paginamaestra.Models;
using System.Data.Entity;

namespace paginamaestra.pages
{
    public partial class CrearCiudades : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton3_click(object sender, EventArgs e)
        {
            String scriptText = "";
            Label3.Text = "Datos completos...";
            Label3.Visible = true;

        }
    }
}
