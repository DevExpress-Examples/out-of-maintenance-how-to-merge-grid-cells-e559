Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid

Namespace WindowsApplication93
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			For i As Integer = 0 To 99
				dataTable1.Rows.Add(New Object() {i Mod 5, "Product " & i, i Mod 7 })
			Next i
			gridView1.OptionsView.AllowCellMerge = True
			For i As Integer = 0 To gridView1.Columns.Count - 1
				If gridView1.Columns(i).FieldName = "CategoryID" Then
					gridView1.Columns(i).OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True
				Else
					gridView1.Columns(i).OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
				End If
			Next i
		End Sub

		Private Sub gridView1_CellMerge(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs) Handles gridView1.CellMerge
			Dim view As GridView = TryCast(sender, GridView)
			Try
				If (e.Column.FieldName = "CategoryID") Then
					Dim value1 As Integer = Convert.ToInt32(view.GetRowCellValue(e.RowHandle1, e.Column))
					Dim value2 As Integer = Convert.ToInt32(view.GetRowCellValue(e.RowHandle2, e.Column))

					e.Merge = (value1 = value2)
					e.Handled = True
					Return
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
End Namespace