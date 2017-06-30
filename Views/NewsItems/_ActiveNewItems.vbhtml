@ModelType IEnumerable(Of NewsAlerts.ActiveNewsAlert)

<ul><li>
@For Each item In Model _
          
          <a href = "~/Views/NewsItems/Details.vbhgml?id=" + item.Id > item.LinkTitle</a> _

Next
</li>
</ul>
