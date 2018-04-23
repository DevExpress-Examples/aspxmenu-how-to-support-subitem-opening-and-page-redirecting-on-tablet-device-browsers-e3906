Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports DevExpress.Web.ASPxMenu
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls

''' <summary>
''' Summary description for MenuItemTemplate
''' </summary>
Public Class MenuItemTemplate
	Implements ITemplate
	Public Sub New()
	End Sub

	Public Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
		Dim c As DevExpress.Web.ASPxMenu.MenuItemTemplateContainer = TryCast(container, DevExpress.Web.ASPxMenu.MenuItemTemplateContainer)
		Dim item As DevExpress.Web.ASPxMenu.MenuItem = c.Item
		If String.IsNullOrEmpty(item.NavigateUrl) Then
			Dim l As Literal = New Literal With {.Text = item.Text}
			c.Controls.Add(l)
		ElseIf c.Item.HasChildren Then
			Dim itemText As String = String.Format("<div onclick=""javascript:PageRedirectTo(event,'{0}')"">{1}</div>", c.ResolveUrl(item.NavigateUrl), item.Text)
			Dim l As Literal = New Literal With {.Text = itemText}
			c.Controls.Add(l)
		Else
			Dim a As HyperLink = New HyperLink With {.NavigateUrl = item.NavigateUrl, .Text = item.Text}
			c.Controls.Add(a)
		End If
	End Sub
End Class