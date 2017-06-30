@ModelType IEnumerable(Of NewsAlerts.NewsItem)
@Code
    ViewData("Title") = "News Alerts Administration"
End Code

<h2>News Alerts Administration</h2>

<p>
    @Html.ActionLink("Create News Alert", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.DisplayItem)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Category)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Organization)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Title)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Description)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
         <td>
            @Html.DisplayFor(Function(modelItem) item.DisplayItem)
         </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Category)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Organization)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Title)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Description)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id})
        </td>
    </tr>
Next

</table>
