Imports System.ComponentModel.DataAnnotations

<MetadataType(GetType(NewsItem.NewsAlertMetaData))>
Partial Public Class NewsItem
    Friend NotInheritable Class NewsAlertMetaData

        'Metadata classes are not meant to be instantiated.
        Private Sub New()
            MyBase.New
        End Sub


        Public Property Category As String


        Public Property Organization As String



        Public Property Title As String


        <StringLength(100)>
        <Display(Name:="Link Title")>
        Public Property LinkTitle As String

        Public Property Description As String

        <Display(Name:="Date Created")>
        <DataType(DataType.Date)>
        <DisplayFormat(DataFormatString:="{0:MM/dd/yyyy}", ApplyFormatInEditMode:=True)>
        Public Property DateCreated As Nullable(Of Date)


        <StringLength(50)>
        <Display(Name:="Created By")>
        Public Property CreatedBy As String

        <StringLength(50)>
        <Display(Name:="Modified By")>
        Public Property ModifiedBy As String

        <Display(Name:="Date Modified")>
        <DataType(DataType.Date)>
        <DisplayFormat(DataFormatString:="{0:MM/dd/yyyy}", ApplyFormatInEditMode:=True)>
        Public Property DateModified As Nullable(Of Date)

        <Display(Name:="Display Item?")>
        Public Property DisplayItem As Boolean

        <Display(Name:="Archive Date")>
        <DataType(DataType.Date)>
        <DisplayFormat(DataFormatString:="{0:MM/dd/yyyy}", ApplyFormatInEditMode:=True)>
        Public Property ArchiveDate As Nullable(Of Date)


    End Class
End Class