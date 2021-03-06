﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<Models.AlocarPessoaMoradiaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>tb_pessoamoradia</legend>

    <div class="display-label">Nome da Pessoa</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomePessoa) %>
    </div>

    <div class="display-label">Condominio</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Condominio) %>
    </div>

    <div class="display-label">Bloco</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Bloco) %>
    </div>

    <div class="display-label">Apartamento</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NumeroMoradia) %>
    </div>

    <div class="display-label">Tipo</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Tipo) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
<% } %>

</asp:Content>
