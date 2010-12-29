<%@ Page Inherits="NHibernate3.Category" Language="C#" AutoEventWireup="True" CodeBehind="Category.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="_htmlForm" runat="server">
    <div>
        <h1>
            Kategorien
        </h1>
        <asp:Repeater ID="categoryList" runat="server">
            <HeaderTemplate>
                <ul>
            </HeaderTemplate>
            <FooterTemplate>
                </ul></FooterTemplate>
            <ItemTemplate>
                <li>
                    <a href="Product.aspx?categoryId=<%#DataBinder.Eval(Container.DataItem,"Id") %>">
                        <%#DataBinder.Eval(Container.DataItem, "Name")%></a></li>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
