﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.BlocoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.apagarBloco %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <%: Models.App_GlobalResources.Mensagem.apagarBloco %></h2>
    <h3>
        <%: Models.App_GlobalResources.Mensagem.confirmacaoBloco %></h3>
    <fieldset>
        <legend>
            <%: Models.App_GlobalResources.Mensagem.apagar %></legend>
        <%: Html.HiddenFor(model => model.IdBloco) %>
        <div class="display-label">
            <%: Models.App_GlobalResources.Mensagem.condominio %></div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.NomeCondominio) %>
        </div>
        <div class="display-label">
            <%: Models.App_GlobalResources.Mensagem.nome %></div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Nome) %>
        </div>
        <div class="display-label">
            <%: Models.App_GlobalResources.Mensagem.qtdeAndares %></div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.QuantidadeAndares) %>
        </div>
        <div class="display-label">
            <%: Models.App_GlobalResources.Mensagem.qtdeMoradias %></div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.QuantidadeMoradias) %>
        </div>
    </fieldset>
    <% using (Html.BeginForm())
       { %>
    <p>
        <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.apagar %>" />
        |
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index") %>
    </p>
    <% } %>
</asp:Content>
