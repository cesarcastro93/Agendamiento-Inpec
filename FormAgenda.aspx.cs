using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using InpecTurnos.WSAgenda;
using InpecTurnos.ws_servicios;
using System.ServiceModel;

namespace InpecTurnos
{
    public partial class About : Page
    {
        WSAgenda.WSAgendaSoapClient ws = new WSAgenda.WSAgendaSoapClient();



        DataSet dsSedes = new DataSet();
        DataSet dsServicios = new DataSet();
        DataSet dsObtenerHorario = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                try
                {
                    //Obtener SEDES//
                    ///////////////
                    dsSedes = ws.ObtenerOficinas();
                    if (dsSedes != null)
                    {


                        List_sede.DataSource = dsSedes.Tables[0];
                        for (int i = 0; i <= dsSedes.Tables[0].Rows.Count; i++)
                        {
                            List_sede.DataTextField = dsSedes.Tables[0].Columns["Nombre"].ToString();
                            List_sede.DataValueField = dsSedes.Tables[0].Columns["Id"].ToString();
                            List_sede.DataBind();
                        }
                    }
                    // Obtener SERVICIOS//
                    /////////////////////
                    dsServicios = ws.ObtenerServicios();
                    List_Servicios.DataSource = dsServicios.Tables[0];
                    for (int i = 0; i <= dsServicios.Tables[0].Rows.Count; i++)
                    {
                        List_Servicios.DataTextField = dsServicios.Tables[0].Columns["Nombre"].ToString();
                        List_Servicios.DataValueField = dsServicios.Tables[0].Columns["Id"].ToString();
                        List_Servicios.DataBind();
                    }


                }
                catch (Exception ex)
                {
                    warning.Text = "Error:" + ex.ToString();
                }
                //Obtener FECHAS//
                /////////////////
                DateTime today = DateTime.Now;
                try
                {
                    if (today.DayOfWeek != DayOfWeek.Sunday && today.DayOfWeek != DayOfWeek.Saturday)
                    {
                        DDLFechas.Items.Add(today.ToString("D", new CultureInfo("es-ES")));
                    }
                    for (int i = 1; i < 21; i++)
                    {
                        if (today.AddDays(i).DayOfWeek != DayOfWeek.Sunday && today.AddDays(i).DayOfWeek != DayOfWeek.Saturday)
                        {
                            DDLFechas.Items.Add(today.AddDays(i).ToString("D", new CultureInfo("es-ES")));
                        }
                    }
                }
                catch (Exception ex)
                {
                    warning.Text = "Error:" + ex.ToString();

                }

            }
            
        }

        protected void btn_Ok_Click(object sender, EventArgs e)
        {
          
            try
            {
                String TipoServicio = List_Servicios.SelectedValue;
                
                var cultureInfo = new CultureInfo("es-ES");
                string dateString = DDLFechas.SelectedValue;
                var date = DateTime.Parse(dateString, cultureInfo);

                dateString = date.Year + "-" + date.Month.ToString("#00") + "-" + date.Day.ToString("#00");

                warning.Text = List_sede.SelectedValue + " - " + dateString;
               
                if (txt_IngID.Text == "")
                {
                    warning.Text = "Debe digitar un número de cédula";
                }
                else
                {


                    if (ws.ValidaCedula(txt_IngID.Text))
                    {
                        warning.Text = "El usuario con número de cédula = " + txt_IngID.Text + " ya cuenta con un agendamiento asignado  ";
                    }
                    else
                    {
                        Response.Redirect("AgendaHorario.aspx?sede=" + List_sede.SelectedValue + "&fecha=" + dateString + "&Tiposerv="
                            + TipoServicio + "&Cedula=" + txt_IngID.Text + "&NombreSede="
                            + List_sede.SelectedItem.Text + "&NombreServicio=" + List_Servicios.SelectedItem.Text);

                    }
                }
            }
            catch(Exception ex)
            { 

            }
        }

        protected void btn_cancelarAgenda_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }

}
