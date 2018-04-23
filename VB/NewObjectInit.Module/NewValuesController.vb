Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.SystemModule
Imports DevExpress.Persistent.BaseImpl

Namespace NewObjectInit.Module
	Partial Public Class NewValuesController
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
		End Sub

		Private detailViewController As DetailViewController

		Private Sub ViewController1_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
			detailViewController = Frame.GetController(Of DetailViewController)()
			AddHandler detailViewController.SaveAndNewAction.Executing, AddressOf SaveAndNewAction_Executing
			AddHandler Frame.ViewChanged, AddressOf Frame_ViewChanged
		End Sub

		Private Sub Frame_ViewChanged(ByVal sender As Object, ByVal e As ViewChangedEventArgs)
			If person IsNot Nothing AndAlso View.CurrentObject IsNot Nothing AndAlso View.CurrentObject.GetType() Is GetType(Person) Then
				Dim current As Person = CType(View.CurrentObject, Person)
				current.FirstName = person.FirstName
				current.LastName = person.LastName
				person = Nothing
			End If
		End Sub

		Private Shared person As Person

		Private Sub SaveAndNewAction_Executing(ByVal sender As Object, ByVal e As CancelEventArgs)
			If View.CurrentObject.GetType() Is GetType(Person) Then
				person = CType(View.CurrentObject, Person)
			End If
		End Sub


	End Class
End Namespace
