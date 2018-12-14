<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lottery.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID ="output" runat ="server"></asp:Label>
            <table border="1">
            <%
                int count = members.Count;
                for (int i = 0; i < count; i++)
                {
                    Response.Write("<tr>");
                    Response.Write(String.Format("<th>{0}</th>", members[i].id));
                    Response.Write(String.Format("<th>{0}</th>", members[i].name));
                    Response.Write(String.Format("<th>{0}</th>", members[i].winner));
                    Response.Write("</tr>");
                }
            %>
            </table>
        </div>
        <%-- <script type ="text/javascript">
            $(document).ready(function () {
                setInterval(function () {
                    $('#output').html(new Date($.now()));
                }, 1000)
            });
        </script> --%>
    </form>
</body>
</html>
