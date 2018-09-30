<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageWithGridView.aspx.cs" Inherits="GameStore.PageWithGridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>GridView</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="grid" runat="server" AutoGenerateColumns="true" />
    </form>
</body>
</html>
