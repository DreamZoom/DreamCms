<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Frame.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Dream.Cms.Category>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>类别管理</h2>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>
    <table class="easyui-datagrid">
        <thead>
            <tr>
                <th>
                    <%: Html.DisplayNameFor(model => model.CategoryName) %>
                </th>
                <th>
                    <%: Html.DisplayNameFor(model => model.ParentID) %>
                </th>

                <th>
                    <%: Html.DisplayNameFor(model => model.Sort) %>
                </th>
                <th>
                    <%: Html.DisplayNameFor(model => model.CreateTime) %>
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            <% foreach (var item in Model)
               { %>
            <tr>
                <td>
                    <%: Html.DisplayFor(modelItem => item.CategoryName) %>
                </td>
                <td>
                    <%: Html.DisplayFor(modelItem => item.ParentID) %>
                </td>

                <td>
                    <%: Html.DisplayFor(modelItem => item.Sort) %>
                </td>
                <td>
                    <%: Html.DisplayFor(modelItem => item.CreateTime) %>
                </td>
                <td>
                    <%: Html.ActionLink("Edit", "Edit", new { id=item.ID }) %> |
                    <%: Html.ActionLink("Details", "Details", new { id=item.ID }) %> |
                    <%: Html.ActionLink("Delete", "Delete", new { id=item.ID }) %>
                </td>
            </tr>
            <% } %>
        </tbody>
    </table>

</asp:Content>
