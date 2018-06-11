<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="image.aspx.cs" Inherits="metoo1.image" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div>
            후보사진 등록 : <input type="file" name="Image"/><br />
        </div>
        <asp:Button ID ="btnSqlConnection" runat="server" 
            Text="OK" OnClick="btn_Click"/>
        <hr />
    </form>

    <asp:Label ID="aa" runat="server"></asp:Label> <br />
    <asp:Label ID="dbcheck" runat="server"></asp:Label>
</body>
</html>
