<%@ Page Title="" Language="C#" MasterPageFile="~/layout_user.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="Bai01.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Form đăng ký thông tin tài khoản</h3>
    <asp:Label runat="server">Username: </asp:Label>
    <asp:TextBox ID="txtuser" name="txtuser" runat="server" CssClass="form-control" placeholder="Vui lòng nhập Username"></asp:TextBox>
    <asp:Label runat="server">Password:</asp:Label>
    <asp:TextBox ID="txtpassword" name="txtpassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Nhập mật khẩu vào"></asp:TextBox>
    <asp:Label runat="server">Avatar: </asp:Label>
    <asp:FileUpload ID="FileUpload1" name="FileUpload1" runat="server" CssClass="form-control" />
    <br />
    <asp:Button ID="btndangky" name="btndangky" runat="server" Text="Đăng ký" CssClass="btn-default" OnClick="btndangky_Click" />
</asp:Content>

