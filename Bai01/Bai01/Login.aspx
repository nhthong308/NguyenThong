<%@ Page Title="" Language="C#" MasterPageFile="~/layout_user.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Bai01.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h3>Đăng nhập vào hệ thống</h3>
    <asp:Label runat="server">Username</asp:Label>
    <asp:TextBox ID="txtuser" name="txtuser" runat="server" placeholder="Nhap vao username" CssClass="form-control"></asp:TextBox>
    <asp:Label runat="server">Password</asp:Label>
    <asp:TextBox ID="txtpassword" name="txtpassword" runat="server" TextMode="Password" placeholder="Nhap vao password" CssClass="form-control"></asp:TextBox>
    <asp:Button ID="btndangnhap" runat="server" Text="Dang nhap" CssClass="btn-default" OnClick="btndangnhap_Click"/> <br />
    <a href="dangnhapgg.aspx">Dang nhap Google</a>
</asp:Content>
