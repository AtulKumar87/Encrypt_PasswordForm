<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="EncryptPassword.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table style="width:100%;">  
                    <tr>  
                        <td class="style1"> LoginName:</td>  
                        <asp:Label ID="msg" runat="server" Text=""></asp:Label>
                        <td class="style2">  
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
                        </td>  
                        <td>  </td>  
                    </tr>  
                    <tr>  
                        <td class="style1"> Pass:</td>  
                        <td class="style2">  
                            <asp:TextBox ID="TextBox2" runat="server" EnableTheming="True" TextMode="Password"></asp:TextBox>  
                        </td>  
                        <td>  </td>  
                    </tr>   
                    <tr>  
                        <td class="style2">  
                            <asp:Button ID="BtnLogin" runat="server" onclick="BtnLogin_Click" Text="Login" /> </td>  
                        <td>  </td>  
                    </tr>  
                </table>  
    </div>
    </form>
</body>
</html>
