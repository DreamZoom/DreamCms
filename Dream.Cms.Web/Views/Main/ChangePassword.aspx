<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Frame.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    ChangePassword
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-horizontal">
        <% using (Html.BeginForm())
           { %>
        <%: Html.AntiForgeryToken() %>
        <%: Html.ValidationSummary(true) %>


       
        <div class="form-body">
            
            <div class="form-group">
                <label class="col-sm-2 control-label" for="password">原密码</label>

                <div class="col-sm-10">
                    <span>
                        <%:Html.TextBox("password") %>

                    </span>

                    <span class="help-block"><%:Html.ValidationMessage("password") %></span>
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-2 control-label" for="password">新密码</label>

                <div class="col-sm-10">
                    <span>
                        <%:Html.Password("newpassword") %>

                    </span>

                    <span class="help-block"><%:Html.ValidationMessage("newpassword") %></span>
                </div>
            </div>
          
        </div>
        <div class="form-actions">
            <div class="row">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="修改密码" class="btn blue " />
                </div>
            </div>
        </div>

        <% } %>
    </div>
</asp:Content>
