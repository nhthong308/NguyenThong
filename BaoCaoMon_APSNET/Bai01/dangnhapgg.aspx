<%@ Page Title="" Language="C#" MasterPageFile="~/layout_user.Master" AutoEventWireup="true" CodeBehind="dangnhapgg.aspx.cs" Inherits="Bai01.dangnhapgg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Button ID="btnLogin" Text="Đăng nhập" runat="server" OnClick="Login" />
        <asp:Panel ID="pnlProfile" runat="server" Visible="false">
            <hr />
            <table>
                <tr>
                    <td rowspan="6" valign="top">
                        <asp:Image ID="ProfileImage" runat="server" Width="50" Height="50" />
                    </td>
                </tr>
                
                <tr>
                    <td class="auto-style1">
                        Name:
                        <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Email:
                        <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
               
                <tr>
                    <td>
                        <asp:Button Text="Thoát" runat="server" OnClick="Clear" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
</asp:Content>
