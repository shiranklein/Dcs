<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DcsTest2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
    <asp:Button ID="Button1" runat="server" Text="GetUsernameAndPassword" OnClick="Button1_Click" />
     &ensp;
        <p ><asp:Label ID="Label1" runat="server" Text=""></asp:Label> </p>
     <br /> 

   <table>  
    <tr>  
        <td>Id:</td>  
        <td><input type="text" id="Text1" runat="server" /></td>  
    </tr>  
    <tr>  
        <td>Name:</td>  
        <td><input type="text" id="Text2" runat="server" /></td>  
    </tr>  
        <tr>  
        <td>Brutto:</td>  
        <td><input type="text" id="Text3" runat="server" /></td>  
    </tr>  
        <tr>  
        <td>Netto:</td>  
        <td><input type="text" id="Text4" runat="server" /></td>  
    </tr>  
          </table>
          &ensp;
        <table>  
    <tr>  
        <td>Id:</td>  
        <td><input type="text" id="Text5" runat="server" /></td>  
    </tr>  
    <tr>  
        <td>Name:</td>  
        <td><input type="text" id="Text6" runat="server" /></td>  
    </tr>  
        <tr>  
        <td>Brutto:</td>  
        <td><input type="text" id="Text7" runat="server" /></td>  
    </tr>  
        <tr>  
        <td>Netto:</td>  
        <td><input type="text" id="Text8" runat="server" /></td>  
    </tr>  
          </table>
          &ensp;
        <table>  
    <tr>  
        <td>Id:</td>  
        <td><input type="text" id="Text9" runat="server" /></td>  
    </tr>  
    <tr>  
        <td>Name:</td>  
        <td><input type="text" id="Text10" runat="server" /></td>  
    </tr>  
        <tr>  
        <td>Brutto:</td>  
        <td><input type="text" id="Text11" runat="server" /></td>  
    </tr>  
        <tr>  
        <td>Netto:</td>  
        <td><input type="text" id="Text12" runat="server" /></td>  
    </tr>  
          </table>
   &ensp;<br /> 
    <asp:Button ID="Button2" runat="server" Text="SuppliersGain" OnClick="Button2_Click" />
      
     <p ><asp:Label ID="Label2" runat="server" Text=""></asp:Label> </p>
     <p ><asp:Label ID="Label3" runat="server" Text=""></asp:Label> </p>
     <p ><asp:Label ID="Label4" runat="server" Text=""></asp:Label> </p>
         </div>

</asp:Content>
