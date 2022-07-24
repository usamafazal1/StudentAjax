<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentAjax.aspx.cs" Inherits="StudentAjax.StudentAjax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    <script>
        function isStudentInfo()
        {
            var inputVal = document.getElementById("DropDownList1").value;
            if (inputVal == "") return;
            $.ajax({
                url: 'StudentAjax.aspx/GetStInfo',
                type: 'post',
                data: JSON.stringify({ "inputValue": inputVal }),
                contentType: 'application/json',
                async: false,
                success: function (data)
                {
                    var information = data.d;
                    var display = "";

                    for (var i in information) {
                        
                        display =  display + i + ": " + information[i] + "<br>";
                    }
                    document.getElementById("datahere").innerHTML = display;
                    
                }
                
            })
        };
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div style = "text-align: center;" >
            <asp:DropDownList ID="DropDownList1" runat="server"> </asp:DropDownList>
            <br /><br />
            <input type="button" id="btn" value="Get Data" onclick="isStudentInfo()" />
            <br /><br />
            <p id="datahere" style= "font-size:20px; font-weight:700; font-family:Arial" ></p>

        </div>
    </form>
</body>
</html>
