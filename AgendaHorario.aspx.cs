using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace InpecTurnos
{
    public partial class AgendaHorario : System.Web.UI.Page
    {

        WSAgenda.WSAgendaSoapClient ws = new WSAgenda.WSAgendaSoapClient();

        String Lasede = "";
        String LAFecha = "";
        String TipServ = "";
        String documento = "";
        String NombreSede = "";
        String NombreServicio = "";

        DataSet dsObtenerHorario = new DataSet();
        protected void Page_Load(object sender, EventArgs e)

        {
                    Lasede = Request.QueryString["sede"];
                    LAFecha = Request.QueryString["fecha"];
                    TipServ = Request.QueryString["Tiposerv"];
                    documento = Request.QueryString["Cedula"];
                    NombreSede = Request.QueryString["NombreSede"];
                    NombreServicio = Request.QueryString["NombreServicio"];


            Loficina.Text = "Oficina:" + NombreSede;
            Lservicio.Text = "Servicio:" + NombreServicio;
            Lhorario.Text = "Fecha:" + LAFecha;
            Ldocumento.Text = "Número de documento :" + documento;


            if (!Page.IsPostBack)
            {
                try


                {    // Obtener HORARIOS//
                    /////////////////////
                    dsObtenerHorario = ws.ObtenerHorariosAgenda(Lasede, LAFecha);
                    DDLHorario.DataSource = dsObtenerHorario.Tables[0];
                    for (int i = 0; i <= dsObtenerHorario.Tables[0].Rows.Count; i++)
                    {
                        DDLHorario.DataTextField = dsObtenerHorario.Tables[0].Columns["Horario"].ToString();
                        DDLHorario.DataValueField = dsObtenerHorario.Tables[0].Columns["Id"].ToString();
                        DDLHorario.DataBind();
                    }
                }
                catch (Exception ex)
                {
                }

            }

          
        }

        protected void Acepto_Click(object sender, EventArgs e)
        {
           
                if (ws.InsertaAgenda(Lasede, TipServ, LAFecha, DDLHorario.SelectedValue, documento))
            {
                Msn.Text = "Agendamiento Realizado correctamente";
            }
            else 
            {
                Msn.Text = "En este momento no se puede realizar el agendamiento. Por favor intente más tarde";
            }

            // Response.Redirect("FormAgenda.aspx");
            Msn.Visible = true;
        }

        protected void btn_cancelarAgenda_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormAgenda.aspx");



        }
    }
}