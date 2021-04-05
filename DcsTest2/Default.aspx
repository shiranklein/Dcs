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
         <%-- <asp:Button ID="Button3" runat="server" Text="Add suppliar" OnClick="Button3_Click" />--%>
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
   &ensp;</br>
    <asp:Button ID="Button2" runat="server" Text="SuppliersGain" OnClick="Button2_Click" />
         <p ><asp:Label ID="Label2" runat="server" Text=""></asp:Label> </p>
     <p ><asp:Label ID="Label3" runat="server" Text=""></asp:Label> </p>
     <p ><asp:Label ID="Label4" runat="server" Text=""></asp:Label> </p>
            </div>
 

    
  


    <%--<div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>--%>

</asp:Content>
