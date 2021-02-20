<%@ Page Title="" Language="C#" MasterPageFile="~/library.Master" AutoEventWireup="true" CodeBehind="DisplayRecord.aspx.cs" Inherits="libraryclient.DisplayRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grdRecord" runat="server">  
       <AlternatingRowStyle BackColor="White" />  
       <HeaderStyle BackColor="#ff6347" Font-Bold="True" ForeColor="White" />  
   </asp:GridView>
</asp:Content>
