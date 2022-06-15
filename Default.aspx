<%@ Page Title="Sistema de Turnos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InpecTurnos._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Sistema de Turnos INPEC </h1>
        <p class="lead">Agende su turno haciendo clic en el botón.</p>
        <!-- Button trigger modal -->
        <button  id="btn_AgendeTurno" type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">Agende Su Turno</button>
        <asp:Button ID="btn_CancelarAgenda" runat="server" Text="Cancelar Agendamiento" class="btn btn-danger " OnClick="btn_CancelarAgenda_Click"/>
        <!-- Modal -->
        <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h2 class="modal-title" id="TituloModal">Teminos y condiciones</h2>

                    </div>
                    <div class="modal-body">
                        <asp:Panel ID="Panel1" runat="server" ScrollBars="Auto" Width="580" Height="600">
                             <b> AGENDAMIENTO TURNOS OFICINAS DE ATENCIÓN AL CIUDADANO INPEC<br /></b>
                                <b>1.ACEPTACIÓN<br /></b>
                                Por favor lee estos términos y condiciones detenidamente antes de solicitar tu agendamiento de turno. Desde el momento en el que leas el presente documento, habrás aceptado estos términos y condiciones. El organizador es el Instituto Nacional Penitenciario y Carcelario, identificada con NIT. 800215546-5 domiciliado en la Calle 26 # 27-48 de Bogotá D.C. en adelante el organizador se denominará como INPEC<br />
                                <b>2. REQUISITOS AGENDAR TURNO<br /></b>
                               2.1.	Ser mayor de edad y tener documento de identificación vigente.<br />
                               2.2.	Residir legalmente en Colombia.<br />
                                <b>3. INFORMACIÓN GENERAL<br /></b>
                                El servicio Agendamiento turnos de la OFICINA DE ATENCIÓN AL CIUDADANO INPEC es un servicio gratuito de selección a través de la página www.inpec.gov.co  una agenda para que el cliente pueda ingresar a las Oficinas de Atención al ciudadano a solicitar su turno, de acuerdo a la capacidad (espacio físico) establecida, en el horario que el cliente determine, esto evita las filas reduciendo el riesgo de exposición a concentraciones de gente.<br />
                                3.1.	Solo puede ingresarse desde el navegador.<br />
                                3.2.	Los únicos datos requeridos es el número de la cédula de quien a va realizar el trámite<br />
                                3.3.	En tal caso de ingresar de manera incorrecta los datos solicitados, no será posible la validación de identidad al ingreso a la Oficina de Atención al ciudadano, por lo cual no se puede atender con cita previa, ingresaría a una espera normal de capacidad o debe hacerse un nuevo agendamiento.<br />
                                3.4.	No hay posibilidad de transferir los agendamientos entre Oficinas de atención al ciudadano ni entre personas.<br />
                                3.5.	Los días de atención son de lunes a viernes de 8:00 a.m. a 4:00 p.m.<br />
                                3.6.	Hay un tiempo de espera de 20 minutos después de la hora pactada por el cliente<br />
                                3.7.	El servicio sirve únicamente para el agendamiento de turnos.<br />
                                3.8.	En tal caso se caiga el servicio de agendamiento de turnos, se atenderán a los clientes bajo la premisa de creer al cliente, permitiendo el ingreso al punto.<br />
                                <b>4. FUNCIONAMIENTO AGENDAMIENTO TURNOS <br /></b>
                                Para evitar la congestión de nuestras Oficinas de Atención al Ciudadano; y como medida de prevención para la protección de nuestros visitantes y colaboradores, a partir del día de hoy hemos habilitado en nuestra página Web un módulo en el cual nuestros clientes pueden agendar sus visitas a las oficinas de atención al ciudadano con anticipación<br />
                                <b>5. TRATAMIENTO DE DATOS<br /></b>
                                Al participar en el Agendamiento de turnos en la Oficina de Atención al ciudadano el usuario otorga a INPEC su consentimiento previo, expreso e informado para el tratamiento de sus datos personales, de conformidad con lo señalado en la Ley 1581 de 2012. Como titular de los datos provistos declara que ha sido informado que tiene los siguientes derechos:<br />
                                5.1 	Acceder en forma gratuita a los datos proporcionados a INPEC que hayan sido objeto de tratamiento;<br />
                                5.2 	Conocer, actualizar y rectificar su información frente a datos parciales, inexactos, incompletos, fraccionados, que induzcan a error, o a aquellos cuyo tratamiento está prohibido o no haya sido autorizado;<br />
                                5.3 	Presentar ante la Superintendencia de Industria y Comercio (SIC) quejas por infracciones a lo dispuesto en la normatividad vigente;<br />
                        </asp:Panel>
                            
                                
                    </div>
                    <div class="modal-footer">
                        <button id="NoAcepto" type="button" class="btn btn-secondary" data-dismiss="modal">No Acepto</button>
                        <asp:Button ID="Acepta" runat="server" class="btn btn-primary" Text="Acepto Teminos y condiciones" OnClick="Acepto_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>




