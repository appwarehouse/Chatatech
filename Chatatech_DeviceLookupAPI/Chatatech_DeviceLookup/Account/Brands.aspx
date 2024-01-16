<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Brands.aspx.cs" Inherits="Chatatech_DeviceLookup.Account.Brands" %>

<%@ Register Assembly="Syncfusion.EJ.Web, Version=17.1460.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.Web" TagPrefix="ej" %>
<%@ Register assembly="Syncfusion.EJ, Version=17.1460.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" namespace="Syncfusion.JavaScript.Models" tagprefix="ej" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Device Manufacturers</h1>
        <p class="lead">Manage the device manufacturers (brands) in use.</p>
    </div>
    <div class="col-12">
        <ej:Grid ID="gridManufacturers" runat='server' CssClass="table table-striped" DataSourceCachingMode="None" 
             EnableLoadOnDemand="False" MinWidth="0" AllowFiltering="True" AllowPaging="True" 
            AllowSorting="True" OnServerEditRow="gridManufacturers_EditRow">
            <ToolbarSettings ShowToolbar="True" ToolbarItems="add,edit,update,cancel">
            </ToolbarSettings>
            <Columns>
                <ej:Column AllowEditing="False" DataType="number" Field="Id" IsIdentity="True" IsPrimaryKey="True" Visible="False">
                </ej:Column>
                <ej:Column DataType="string" Field="Name">
                </ej:Column>
                <ej:Column DataType="string" Field="Description">
                </ej:Column>
                <ej:Column DataType="string" Field="Active">
                </ej:Column>
            </Columns>
            <EditSettings AllowEditing="True" />
        </ej:Grid>
        <asp:SqlDataSource ID="sdsBrands" runat="server" ConnectionString="<%$ ConnectionStrings:conn %>" SelectCommand="SELECT [Id], [Name], [Description], [Active] FROM [DeviceManufacturers]"></asp:SqlDataSource>
    </div>
</asp:Content>
