﻿@ModelType NewsAlerts.NewsItem
@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>News Alert</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

         <div class="form-group">
             @Html.LabelFor(Function(model) model.DisplayItem, htmlAttributes:=New With {.class = "control-label col-md-2"})
             <div class="col-md-10">
                 <div class="checkbox">
                     @Html.EditorFor(Function(model) model.DisplayItem)
                     @Html.ValidationMessageFor(Function(model) model.DisplayItem, "", New With {.class = "text-danger"})
                 </div>
             </div>
         </div>
        
        <div class="form-group">
            @Html.LabelFor(Function(model) model.Category, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Category, New With {.htmlAttributes = New With {.class = "form-control Category"}})
                @Html.ValidationMessageFor(Function(model) model.Category, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Organization, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Organization, New With {.htmlAttributes = New With {.class = "form-control Organization"}})
                @Html.ValidationMessageFor(Function(model) model.Organization, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Title, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Title, New With {.htmlAttributes = New With {.class = "form-control Title"}})
                @Html.ValidationMessageFor(Function(model) model.Title, "", New With {.class = "text-danger"})
            </div>
        </div>
           <div class="form-group">
            @Html.LabelFor(Function(model) model.LinkTitle, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.LinkTitle, New With {.htmlAttributes = New With {.class = "form-control LinkTitle"}})
                @Html.ValidationMessageFor(Function(model) model.LinkTitle, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Description, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.TextAreaFor(Function(model) model.Description, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.Description, "", New With {.class = "text-danger"})
            </div>
        </div>

       <div class="form-group">
            @Html.LabelFor(Function(model) model.CreatedBy, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.CreatedBy, New With {.htmlAttributes = New With {.class = "form-control CreatedBy"}})
                @Html.ValidationMessageFor(Function(model) model.CreatedBy, "", New With {.class = "text-danger"})
            </div>
        </div>




        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
