<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lottery.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        tr {cursor:pointer;}
        tr:hover {background: grey; }
    </style>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script type ="text/javascript">
        $(document).ready(function () {
            $('.member').click(function () {
                var clickedClass = $(this);
                var memId = $(this).find('.id').html();
                $.ajax({
                    url: 'MembersService.asmx/ChangeWinner',
                    data: { memberId: memId },
                    dataType: "json",
                    method: "post",
                    success: function(data)
                    {
                        clickedClass.find('.winner').html(data.winner);
                    },
                    error: function (err) {
                        alert(err);
                    }
                })
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID ="output" runat ="server"></asp:Label>
            <table border="1" id ="tableid">
                <asp:Repeater id = "repMembers" runat = "server">
                    <ItemTemplate>
                        <tr class ="member">
                            <th class ="id"><%# Eval("id") %></th>
                            <th class ="name"><%# Eval("name") %></th>
                            <th class ="winner"><%# Eval("winner") %></th>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
            
        </div>
    </form>
</body>
</html>
