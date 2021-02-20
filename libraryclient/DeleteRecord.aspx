<%@ Page Title="" Language="C#" MasterPageFile="~/library.Master" AutoEventWireup="true" CodeBehind="DeleteRecord.aspx.cs" Inherits="libraryclient.DeleteRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table id="panSearch" runat="server" style="width:auto; color:Black; font-family:Segoe UI; font-size:14px; float:left; text-align:left; padding:10px; padding-bottom:20px;" >  
<tr>  
<td>ID</td>  
<td><asp:TextBox ID="txtSearch" runat="server" CssClass="textBox" Placeholder="Enter Id to delete it" ></asp:TextBox></td>  
<td><asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="button" onclick="btnDelete_Click"   
        ></asp:Button></td>  
</tr>  
<tr>  
<td colspan="3" ><asp:Label ID="lblSearchResult" runat="server" Font-Size="Medium" ></asp:Label></td></tr>  
</table>  
 <hr />  
 <div style="float:left" >  
 <asp:GridView ID="grdRecord" runat="server">  
        <AlternatingRowStyle BackColor="White" />  
        <HeaderStyle BackColor="#ff6347" Font-Bold="True" ForeColor="White" />  
    </asp:GridView>  
    </div>  

</asp:Content>
