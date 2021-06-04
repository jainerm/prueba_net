<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CrearCiudades.aspx.cs" Inherits="paginamaestra.pages.CrearCiudades" %>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script runat="server">
        void bloquear_onSubmit (object sender, EventArgs e)
        {
            Label1.Text = "Listo para digitar.";
            TextBox1.Focus();
            String scriptText = "return false;";
            ClientScript.RegisterOnSubmitStatement(this.GetType(),
            "ConfirmSubmit", scriptText);
        }
    </script>
    <!-- Barra de opciones seleccionadas -->
    <div class="wrapper col2">
      <div id="breadcrumb">
        <ul>
          <li class="first">Inicio</li>
          <li>&#187;</li>
          <li><a href="#">Registrar clima</a></li>
          <li class="current"><a href="#">Crear Ciudades</a></li>
        </ul>
      </div>
    </div>
<!-- ####################################################################################################### -->
<div class="wrapper col3">
  <div id="container">
    <div id="content">
      <h1>Ingresa ciudades de Colombia.</h1>
      <img class="imgr" src="../images/ciudades/Bogota.png" alt="" width="125" height="125" />
      <p>Ingrese la ciudad que desea para poder registrar los datos del clima.</p>
      <p>Tambien puede tomar una de las ciudades existentes para registrar la temperatura para este dia.</p>
      <p>LA información aqui suministrada será actualizada en la portada principal de Ciudades principales.</p>
      <p>Esta información que aqui se registre estará disponible a todos los usuarios que ingresen a esta aplicación Web..</p>
      <h2>Tabla de Ciudades principales</h2>
    </div>
        
        <asp:SqlDataSource runat="server" ID="SqlCiudades"
            ConnectionString="data source=(LocalDb)\MSSQLLocalDB;initial catalog=paginamaestra.ClimaEF;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" 
            ProviderName="System.Data.SqlClient"
            SelectCommand="SELECT a.[IdCiudad],[NomCiudad],[Temperatura] FROM dbo.Ciudades AS a, dbo.Climas AS b WHERE a.IdCiudad = b.IdCiudad AND b.DiaSemana = 4 ORDER BY Nomciudad DESC">
        </asp:SqlDataSource>
        <asp:GridView runat="server" ID="CiudadesGrid"
            AutoGenerateColumns="False"
            DataKeyNames="IdCiudad"
            DataSourceID="SqlCiudades" BackColor="White">
            <Columns>
                <asp:BoundField DataField="IdCiudad" HeaderText="IdCiudad" InsertVisible="False" ReadOnly="True" SortExpression="IdCiudad"/>
                <asp:BoundField DataField="NomCiudad" HeaderText="NomCiudad" SortExpression="NomCiudad" />
                <asp:BoundField DataField="Temperatura" HeaderText="Temperatura" SortExpression="Temperatura" />
            </Columns>
            <HeaderStyle BackColor="#006699" BorderColor="Black" Font-Bold="True" Font-Size="Larger" ForeColor="White" Height="26px" />
        </asp:GridView>
        <div id="topnav">
         <asp:LinkButton ID="LinkButton1" runat="server" Height="20px" Width="70px" OnClientClick="return jsNuevaCiudad();" onclick="bloquear_onSubmit">Nuevo</asp:LinkButton>     
         <asp:LinkButton ID="LinkButton2" runat="server" Height="20px" Width="70px" OnClientClick="return jsEditarCiudad();" onclick="bloquear_onSubmit">Editar</asp:LinkButton>
        </div>
      <br class="clear" />
      <asp:PlaceHolder ID="PlaceHolder1" runat="server">
     <div id="formDatosCiudad" class="box1" style="display: none;">

       <h1>Ingreso de datos!</h1>
         <table>
             <tr>
                <td>
                <asp:Label ID="Label1" runat="server" Text="Nombre Ciudad"></asp:Label>
                </td>
                <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="90%"></asp:TextBox>
                </td>
             </tr>
             <tr>
                <td style="height: 30px">
                <asp:Label ID="Label2" runat="server" Text="Temperatura"></asp:Label>
                </td>
                <td style="height: 30px">
                <asp:TextBox ID="TextBox2" runat="server" Width="20%"></asp:TextBox>
                </td>
             </tr>
             <tr>
                <td style="height: 30px">
                <asp:Label ID="Label3" runat="server" Text="" Visible="false"></asp:Label>
                </td>
             </tr>
         </table>
          <asp:PlaceHolder ID="PlaceHolder2" runat="server">
            <div id="topnav">
                <asp:LinkButton ID="LinkButton3" runat="server" Height="30px" Width="70px" OnClick="LinkButton3_click"> Guardar</asp:LinkButton>
            </div>
          </asp:PlaceHolder>
     </div>
      </asp:PlaceHolder>
      <br class="clear" />
    </div>
  </div>
</div>
<!-- ####################################################################################################### -->
<div class="wrapper col4">
  <div id="footer">
    <div class="box1">
      <h2>Ciudad de Medellin !</h2>
      <img class="imgl" src="../images/ciudades/Medellin.png" alt="" width="150%"/>
      <p>Esta aplicacion permite registrar el estado de clima en las principales ciudades del pais.</p>
      <p>Toda la información ha sido tomada de Wikipedia - La enciclopedia libre.</p>
    </div>
    <div class="box flickrbox">
      <h2>Ciudades principales !</h2>
      <div class="wrap">
        <div class="fix"></div>
        <div class="flickr_badge_image" id="flickr_badge_image1"><a href="#"><img src="../images/ciudades/Bogota.png" alt="" width="100%" /></a></div>
        <div class="flickr_badge_image" id="flickr_badge_image2"><a href="#"><img src="../images/ciudades/Barranquilla.png" alt="" width="100%" /></a></div>
        <div class="flickr_badge_image" id="flickr_badge_image3"><a href="#"><img src="../images/ciudades/Medellin.png" alt=""  width="100%" /></a></div>
        <div class="flickr_badge_image" id="flickr_badge_image4"><a href="#"><img src="../images/ciudades/Ibague.png" alt=""  width="100%" /></a></div>
        <div class="flickr_badge_image" id="flickr_badge_image5"><a href="#"><img src="../images/ciudades/Manizales.png" alt=""  width="100%" /></a></div>
        <div class="flickr_badge_image" id="flickr_badge_image6"><a href="#"><img src="../images/ciudades/santamarta.png" alt=""  width="100%" /></a></div>
        <div class="fix"></div>
      </div>
    </div>
    <br class="clear" />
  </div>
</div>
</div>
<!-- ####################################################################################################### -->

</asp:Content>
