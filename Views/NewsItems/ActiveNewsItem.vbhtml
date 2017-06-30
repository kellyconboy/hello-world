@ModelType IEnumerable(Of NewsAlerts.ActiveNewsAlert)
@Code
    ViewData("Title") = "News Alerts Administration"
End Code

<table class="table">

@For Each item In Model
    @<tr>
         <td>
             

             @Html.ActionLink(item.LinkTitle, "Details", New With {.id = item.Id})
            
         </td>
    </tr>
Next

</table>
