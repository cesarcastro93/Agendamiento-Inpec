using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace InpecTurnos
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Acepto_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormAgenda.aspx");
        }

        protected void btn_CancelarAgenda_Click(object sender, EventArgs e)
        {
            Response.Redirect("CancelarAgendamiento.aspx");
        }
    }
}