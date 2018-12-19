<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Contact Us.aspx.cs" Inherits="BradysProperties.Contact_Us" %>

<%@ MasterType VirtualPath="~/Main.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 239px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="PageLayout">
        <asp:Label ID="contactGreeting" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <div class="centerBox">
            <asp:Label ID="contactInfo" runat="server" Text="Label"></asp:Label><br />
        </div>
        <br />
        <div class="location">
            <asp:Label ID="submissionConfirm" runat="server" Text="" Visible="False"></asp:Label>
        </div>
        <br />
        <br />
        <div>
            <table>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="nameLbl" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="nameTxt" runat="server" OnTextChanged="nameTxt_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="nameRFV" runat="server" ErrorMessage="Please Enter Your Name." ForeColor="Red" ControlToValidate="nameTxt"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="phoneLbl" runat="server" Text="Phone"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="phoneTxt" runat="server" OnTextChanged="phoneTxt_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="phoneRFV" runat="server" ErrorMessage="Please Enter Your Phone Number" ControlToValidate="phoneTxt" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="phoneRegexV" runat="server" ErrorMessage="Enter a 10 Digit Phone Number." ControlToValidate="phoneTxt" ValidationExpression="\d{10}" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="emailRFV" runat="server" ErrorMessage="Please Enter Your Email" ForeColor="Red" ControlToValidate="emailTxt"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="emailRegexV" runat="server" ErrorMessage="Please Enter Your Email in format of Example@Example.com/net/edu" ControlToValidate="emailTxt" ValidationExpression=".*@\w*\.\D{3}" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="messageLbl" runat="server" Text="Message"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="messageTxt" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <div class="centerBox">
            <div>
                <asp:Button ID="enterCI" runat="server" Text="Submit" OnClick="enterCI_Click" />
            </div>
        </div>
    </div>
</asp:Content>
