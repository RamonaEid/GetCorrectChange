<%@ Page Title="Home Page" Description="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GCC.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Get Correct Change</h1>
        <!-- Out of SPECIFIC Denomination Checkboxes -->
        <div class="row">
            <div class="col-md-12">
                Please check Currency Type(s) <span style="color: red; font-weight: bolder">not</span> in the Till:
                <asp:CheckBoxList ID="excludeCheckBoxList" runat="server" CellPadding="4" CellSpacing="0" RepeatDirection="Horizontal" RepeatColumns="7">
                    <asp:ListItem>Hundred</asp:ListItem>
                    <asp:ListItem>Twenty</asp:ListItem>
                    <asp:ListItem>Ten</asp:ListItem>
                    <asp:ListItem>Five</asp:ListItem>
                    <asp:ListItem>One</asp:ListItem>
                    <asp:ListItem>Dime</asp:ListItem>
                    <asp:ListItem>Nickel</asp:ListItem>
                </asp:CheckBoxList>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="labelSale" runat="server" AssociatedControlID="saleTextBox" CssClass="col-md-12 control-label">Amount Of Sale (500.00 or less: dollars and cents without $)</asp:Label>
            <div class="col-md-12">
                <asp:TextBox ID="saleTextBox" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="RequiredValidatorSale" runat="server" ControlToValidate="saleTextBox"
                    CssClass="text-danger" ErrorMessage="Amount Of Sale is required." />
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorSale" runat="server" ControlToValidate="saleTextBox"
                    CssClass="text-danger" ValidationExpression="\d{0,3}\.\d{2}"
                    ErrorMessage="You must enter dollars AND cents including the dot." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="cashLabel" runat="server" AssociatedControlID="cashTextBox" CssClass="col-md-12">Customer Gave Me (dollars and cents without $)</asp:Label>
            <div class="col-md-12">
                <asp:TextBox ID="cashTextBox" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorCash" runat="server" ControlToValidate="cashTextBox"
                    CssClass="text-danger" ErrorMessage="Custsomer Game Me is required." />
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorCash" runat="server" ControlToValidate="cashTextBox"
                    CssClass="text-danger" ValidationExpression="\d{0,3}\.\d{2}"
                    ErrorMessage="You must enter dollars AND cents including the dot." />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-12">
                <asp:Button ID="getChangeButton" runat="server" Text="Get Change" OnClick="getChangeButton_Click" />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-12">
                <asp:Label ID="resultLabel" runat="server"></asp:Label>
            </div>
        </div>

    </div>

    <div class="row">
        <div class="col-md-3">
            <h2>Hundred</h2>
            <h3>
                <asp:Label ID="labelHundred" runat="server"></asp:Label>
            </h3>
            <p>
                <asp:Image ID="imgHundred" runat="server" />
            </p>
        </div>
        <div class="col-md-3">
            <h2>Twenty</h2>
            <h3>
                <asp:Label ID="labelTwenty" runat="server"></asp:Label>
            </h3>
            <p>
                <asp:Image ID="imgTwenty" runat="server" />
            </p>
        </div>
        <div class="col-md-3">
            <h2>Ten</h2>
            <h3>
                <asp:Label ID="labelTen" runat="server"></asp:Label>
            </h3>
            <p>
                <asp:Image ID="imgTen" runat="server" />
            </p>
        </div>
        <div class="col-md-3">
            <h2>Five</h2>
            <h3>
                <asp:Label ID="labelFive" runat="server"></asp:Label>
            </h3>
            <p>
                <asp:Image ID="imgFive" runat="server" />
            </p>
        </div>
    </div>

    <div class="row">
        <div class="col-md-3">
            <h2>One</h2>
            <h3>
                <asp:Label ID="labelOne" runat="server"></asp:Label>
            </h3>
            <p>
                <asp:Image ID="imgOne" runat="server" />
            </p>
        </div>
        <div class="col-md-3">
            <h2>Dime</h2>
            <h3>
                <asp:Label ID="labelDime" runat="server"></asp:Label>
            </h3>
            <p>
                <asp:Image ID="imgDime" runat="server" />
            </p>
        </div>
        <div class="col-md-3">
            <h2>Nickel</h2>
            <h3>
                <asp:Label ID="labelNickel" runat="server"></asp:Label>
            </h3>
            <p>
                <asp:Image ID="imgNickel" runat="server" />
            </p>
        </div>
        <div class="col-md-3">
            <h2>Penny</h2>
            <h3>
                <asp:Label ID="labelPenny" runat="server"></asp:Label>
            </h3>
            <p>
                <asp:Image ID="imgPenny" runat="server" />
            </p>
        </div>
    </div>

</asp:Content>
