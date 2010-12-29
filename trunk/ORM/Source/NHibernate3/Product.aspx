<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="NHibernate3.Product" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="productList" runat="server">
            <HeaderTemplate>
                <ul>
            </HeaderTemplate>
            <FooterTemplate>
                </ul></FooterTemplate>
            <ItemTemplate>
                <li>
                    <%#DataBinder.Eval(Container.DataItem, "Name")%></li>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
