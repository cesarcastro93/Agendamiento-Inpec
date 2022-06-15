using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InpecTurnos.WSAgenda;

namespace InpecTurnos
{
    
    public partial class CancelarAgendamiento : System.Web.UI.Page
    {
        WSAgenda.WSAgendaSoapClient ws = new WSAgenda.WSAgendaSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Ok_eliminarAgenda_Click(object sender, EventArgs e)
        {

            if (txt_IngID.Text == "")
            {
                Lrespuesta.Text = "Debe ingresar un número de documento";
                //MsgBox("Debe digitar un número de cédula", this.Page, this);
                
               
            }
            else
            {

                int respuesta = ws.BorraAgenda(txt_IngID.Text);


                if (respuesta == 1)
                {
                    Lrespuesta.Text = "El agendamiento asignado con cédula: " + txt_IngID.Text + " ha sido cancelado ";
                }
                else
                {
                    Lrespuesta.Text = "La cédula: " + txt_IngID.Text + " no cuenta con agendamiento";
                    
                }

                
            }
            Lrespuesta.Visible = true;
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");

        }

        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }


    }
}