<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Courses.aspx.cs" Inherits="ContosoUniversityModelBinding.Courses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView runat="server" ID="coursesGrid"
        ItemType="ContosoUniversityModelBinding.Models.Enrollment"
        SelectMethod="GetCourses" AutoGenerateColumns="false"
        OnCallingDataMethods="coursesGrid_CallingDataMethods">
        <Columns>
            <asp:BoundField HeaderText="Title" DataField="Course.Title" />
            <asp:BoundField HeaderText="Credits" DataField="Course.Credits" />
            <asp:BoundField HeaderText="Grade" DataField="Grade" />
        </Columns>
        <EmptyDataTemplate>
            <asp:Label Text="No Enrolled Courses" runat="server" />
        </EmptyDataTemplate>
    </asp:GridView>
</asp:Content>
