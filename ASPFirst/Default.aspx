<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPFirst._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>X AND O !</h1>
        <p class="lead">The classic game of noughts and crosses.</p>
        <p>
            <asp:Button ID="btn_start" runat="server" OnClick="btn_start_Click" Text="Start A New Game" />
        </p>
        <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="lbl_message" runat="server" Text="Start!"></asp:Label>
                <br />
                1
                <asp:Button ID="btn_1" runat="server" Height="38px" OnClick="btn_1_Click" style="text-align:center" Text=" " Width="38px" Font-Size="Large" />
                <asp:Button ID="btn_2" runat="server" Height="38px" OnClick="btn_2_Click" style="text-align:center" Text=" " Width="38px" Font-Size="Large" />
                <asp:Button ID="btn_3" runat="server" Height="38px" OnClick="btn_3_Click" style="text-align:center" Text=" " Width="38px" Font-Size="Large" />
                <br />
                2
                <asp:Button ID="btn_4" runat="server" Height="38px" OnClick="btn_4_Click" style="text-align:center" Text=" " Width="38px" Font-Size="Large" />
                <asp:Button ID="btn_5" runat="server" Height="38px" OnClick="btn_5_Click" style="text-align:center" Text=" " Width="38px" Font-Size="Large" />
                <asp:Button ID="btn_6" runat="server" Height="38px" OnClick="btn_6_Click" style="text-align:center" Text=" " Width="38px" Font-Size="Large" />
                <br />
                3
                <asp:Button ID="btn_7" runat="server" Height="38px" OnClick="btn_7_Click" style="text-align:center" Text=" " Width="38px" Font-Size="Large" />
                <asp:Button ID="btn_8" runat="server" Height="38px" OnClick="btn_8_Click" style="text-align:center" Text=" " Width="38px" Font-Size="Large" />
                <asp:Button ID="btn_9" runat="server" Height="38px" OnClick="btn_9_Click" style="text-align:center" Text=" " Width="38px" Font-Size="Large" />
        </asp:Panel>
    </div>

    <div class="row">
    </div>

</asp:Content>
