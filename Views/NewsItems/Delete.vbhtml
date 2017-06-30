@ModelType NewsAlerts.NewsItem
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>NewsAlert</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.DisplayItem)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DisplayItem)
        </dd>
        <dt> 
            @Html.DisplayNameFor(Function(model) model.Category)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Category)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Organization)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Organization)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Title)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LinkTitle)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LinkTitle)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Description)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DateCreated)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DateCreated)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DateModified)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DateModified)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CreatedBy)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CreatedBy)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ModifiedBy)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ModifiedBy)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ArchiveDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ArchiveDate)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
