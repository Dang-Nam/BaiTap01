<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính Lương</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Tính lương</h2>
            <label for="soNgayLam">Số ngày làm:</label>
            <asp:TextBox ID="txtSoNgayLam" runat="server"></asp:TextBox>
            <br /><br />
            <label for="tienCong">Tiền công mỗi ngày:</label>
            <asp:TextBox ID="txtTienCong" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnTinhLuong" runat="server" Text="Tính lương" OnClick="btnTinhLuong_Click" />
            <br /><br />
            <label for="ketQua">Tổng lương:</label>
            <asp:Label ID="lblTongLuong" runat="server" Text="0"></asp:Label>
        </div>
    </form>
</body>
</html>
