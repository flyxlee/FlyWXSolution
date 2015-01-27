<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WXSolution.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="CreateBtn" runat="server" Text="创建" OnClick="CreateBtn_Click"  />
        <br />
        <asp:Button ID="GetBtn" runat="server"  Text="获取" OnClick="GetBtn_Click" />
          <br />
        <asp:Button ID="DeleteBtn" runat="server" Text="删除" OnClick="DeleteBtn_Click" />
        <br />
        <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
    </div>
        
        
    </form>
</body>
</html>
