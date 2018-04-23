Namespace NewObjectInit.Module
    Partial Public Class NewValuesController
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
                If detailViewController IsNot Nothing Then
                    detailViewController.Dispose()
                    detailViewController = Nothing
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            ' 
            ' ViewController1
            ' 
            Me.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView
            Me.TypeOfView = GetType(DevExpress.ExpressApp.DetailView)

        End Sub

        #End Region
    End Class
End Namespace
