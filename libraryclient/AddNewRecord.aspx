<%@ Page Title="" Language="C#" MasterPageFile="~/library.Master" AutoEventWireup="true" CodeBehind="AddNewRecord.aspx.cs" Inherits="libraryclient.AddNewRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width:100%; color:Black; font-family:Segoe UI; font-size:14px; float:left; text-align:left;">  
<tr>  
<td colspan="2"><asp:Label ID="lblMsg" runat="server" Font-Size="Medium" ></asp:Label></td>  
</tr>  
<tr>  
<td>Id</td>  
<td><asp:TextBox ID="txtId" runat="server" CssClass="textBox" ></asp:TextBox></td>  
</tr>  
<tr>  
<td>Student Name</td>  
<td><asp:TextBox ID="txtName" runat="server" CssClass="textBox" ></asp:TextBox></td>  
</tr>  
<tr>  
<td>Student Id</td>  
<td><asp:TextBox ID="txtSid" runat="server" CssClass="textBox" ></asp:TextBox></td>  
</tr>  
<tr>  
<td>Book Name</td>  
<td><asp:TextBox ID="txtBname" runat="server" CssClass="textBox" ></asp:TextBox></td>  
</tr>  
<tr>  
<td>Author Name</td>  
<td><asp:TextBox ID="txtAname" runat="server" CssClass="textBox" ></asp:TextBox></td>  
</tr>  
<tr>  
<td>Price</td>  
<td><asp:TextBox ID="txtprice" runat="server" CssClass="textBox" ></asp:TextBox></td>  
</tr>  

<tr>  
<td colspan="2">  
<asp:Button ID="btnSave" runat="server" Text="Save" CssClass="button"   
        onclick="btnSave_Click" />  
<asp:Button ID="bntReset" runat="server" Text="Reset" CssClass="button"   
        onclick="bntReset_Click" />  
</td>  
</tr>  

</table>  
</asp:Content>
