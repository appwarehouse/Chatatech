<%@ Page UICulture="en-za" Culture="en-za" Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Devices.aspx.cs" Inherits="Chatatech_DeviceLookup.Account.Devices" %>

<%@ Register Assembly="Syncfusion.EJ.Web, Version=17.1460.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.Web" TagPrefix="ej" %>
<%@ Register assembly="Syncfusion.EJ, Version=17.1460.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" namespace="Syncfusion.JavaScript.Models" tagprefix="ej" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Device List</h1>
        <p class="lead">Manage the devices that you have in&nbsp; the database.</p>
    </div>
    <div class="col-12">
        <ej:Grid ID="gridDevices" runat='server' CssClass="table table-striped" DataSourceCachingMode="None" 
                 EnableLoadOnDemand="False" MinWidth="0" AllowFiltering="True" AllowPaging="True" 
                 AllowSorting="True" >
            <ToolbarSettings ShowToolbar="True" ToolbarItems="add,edit,update,cancel">
            </ToolbarSettings>
            <Columns>
                <ej:Column AllowEditing="False" DataType="number" Field="Id" IsIdentity="True" IsPrimaryKey="True" Visible="False">
                </ej:Column>
                <ej:Column DataType="string" Field="Model">
                </ej:Column>
                <ej:Column DataType="string" Field="SerialMatch">
                </ej:Column>
                <ej:Column DataType="string" Field="Manufacturer">
                </ej:Column>
                <ej:Column DataType="string" Field="Product Name">
                </ej:Column>
                <ej:Column DataType="string" Field="Size">
                </ej:Column>
                <ej:Column DataType="string" Field="Type">
                </ej:Column>
                <ej:Column DataType="string" Field="OriginalCost" Format="{0:C2}">
                </ej:Column>
                <ej:Column DataType="string" Field="Discontinued">
                </ej:Column>
                <ej:Column DataType="string" Field="Replacement">
                    </ej:Column>
            </Columns>
            <EditSettings AllowEditing="True" />
        </ej:Grid>
        </div>
</asp:Content>