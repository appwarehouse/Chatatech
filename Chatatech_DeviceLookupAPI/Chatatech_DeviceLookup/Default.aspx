<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Chatatech_DeviceLookup._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Chatatech Device Lookup</h1>
        <p class="lead">Welcome to Chatatech. We specialise in identifying devices with the use of just the serial number. 
            Contact us if you would like to know more of our servies.
        </p>
        <p><a href="/Contact" class="btn btn-primary btn-lg">Contact Us &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Serial Matching</h2>
            <p>
                <img src="Content/Images/serial_bar.png" width="200px" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>QR Code Matching</h2>
            <p>
                <img src="Content/Images/serial_QR.png" width="200px" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Our Services</h2>
            <p>We are able to match devices based on a scanned bar code or QR code found on electronic devices. Based on this we can give
                you the model name, price and year of manufacture.
            </p>
            <p>
                <a class="btn btn-default" href="/Contact">Contact Us &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
