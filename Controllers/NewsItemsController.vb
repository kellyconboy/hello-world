Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Microsoft.Ajax.Utilities
Imports NewsAlerts

Namespace Controllers
    Public Class NewsItemsController
        Inherits System.Web.Mvc.Controller

        Private db As New DLANewsAlertsEntities

        ' GET: NewsItems
        Function Index() As ActionResult
            If (db.NewsItems.Count() > 0) Then
                Return View(db.NewsItems.ToList())
            Else
                Return RedirectToAction("Index")
            End If
        End Function
        ' GET: NewsItems
        Function _ActiveNewsItems() As ActionResult
            If (db.ActiveNewsAlerts.Count() > 0) Then
                Return View(db.ActiveNewsAlerts.ToList())
            Else
                Return RedirectToAction("Index")
            End If
        End Function




        ' GET: NewsItems/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim newsItem As NewsItem = db.NewsItems.Find(id)
            If IsNothing(newsItem) Then
                Return HttpNotFound()
            End If
            Return View(newsItem)
        End Function

        ' GET: NewsItems/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: NewsItems/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,Category,Organization,Title,LinkTitle,Description,DateCreated,DateModified,CreatedBy,ModifiedBy,DisplayItem,ArchiveDate")> ByVal newsItem As NewsItem) As ActionResult
            newsItem.DateCreated = DateTime.Now
            newsItem.DateModified = DateTime.Now
            newsItem.ModifiedBy = newsItem.CreatedBy
            If ModelState.IsValid Then
                db.NewsItems.Add(newsItem)
                Try
                    db.SaveChanges()
                Catch ex As Exception
                    Console.Write(ex.Message)
                End Try
                Return RedirectToAction("Index")
            End If
            Return View(newsItem)
        End Function

        ' GET: NewsItems/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim newsItem As NewsItem = db.NewsItems.Find(id)
            If IsNothing(newsItem) Then
                Return HttpNotFound()
            End If
            Return View(newsItem)
        End Function

        ' POST: NewsItems/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,Category,Organization,Title,LinkTitle,Description,DateCreated,DateModified,CreatedBy,ModifiedBy,DisplayItem,ArchiveDate")> ByVal newsItem As NewsItem) As ActionResult
            newsItem.DateModified = Date.Now
            If ModelState.IsValid Then
                db.Entry(newsItem).State = EntityState.Modified
                Try
                    db.SaveChanges()
                Catch ex As Exception
                    System.Diagnostics.Debug.WriteLine("Exception caught for db.SaveChanges(): {0}", ex)
                End Try
                Return RedirectToAction("Index")
            End If
            Return View(newsItem)
        End Function

        ' GET: NewsItems/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim newsItem As NewsItem = db.NewsItems.Find(id)
            If IsNothing(newsItem) Then
                Return HttpNotFound()
            End If
            Return View(newsItem)
        End Function

        ' POST: NewsItems/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim newsItem As NewsItem = db.NewsItems.Find(id)
            db.NewsItems.Remove(newsItem)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
