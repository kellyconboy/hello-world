@ModelType NewsAlerts.NewsItem
@Code
    ViewData("Title") = "News Alert Details"
End Code

<h2>Details</h2>

<div>
    <h4>News Alert</h4>
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
            @Html.DisplayNameFor(Function(model) model.CreatedBy)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CreatedBy)
        </dd>
       <dt>
            @Html.DisplayNameFor(Function(model) model.DateCreated)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DateCreated)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ModifiedBy)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ModifiedBy)
        </dd>
        <dt>
            @Html.DisplayNameFor(Function(model) model.DateModified)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DateModified)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ArchiveDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ArchiveDate)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
