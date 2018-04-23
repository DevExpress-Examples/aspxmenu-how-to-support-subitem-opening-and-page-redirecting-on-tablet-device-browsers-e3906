Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Web.ASPxMenu

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub ASPxMenu1_Init(ByVal sender As Object, ByVal e As EventArgs)
		TryCast(sender, ASPxMenu).ItemTextTemplate = New MenuItemTemplate()
	End Sub
End Class