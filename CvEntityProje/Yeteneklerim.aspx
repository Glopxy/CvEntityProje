<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yeteneklerim.aspx.cs" Inherits="CvEntityProje.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <table class="table table-bordered" style="margin-left:20px;margin-right:20px">
        <tr>
            <th>Id</th>
            <th>Yetenek</th>
            <th>Sil</th>
            <th>Güncelle</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Id")%></td>
                    <td><%#Eval("Yetenek")%></td>
                    <td><a href="#" class="btn btn-danger">Sil</td>
                    <td><a href="#" class="btn btn-info">Güncelle</td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
