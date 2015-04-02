Imports System.IO


Public Class Form3
    Dim m As MsgBoxResult
    Dim t As String
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BirthdayDataSet1.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter2.Fill(Me.BirthdayDataSet1.Table1)
        'TODO: This line of code loads data into the 'AppoinmentDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter1.Fill(Me.AppoinmentDataSet.Table1)
        'TODO: This line of code loads data into the 'AnniverseryDataSet.anniversary' table. You can move, or remove it, as needed.
        Me.AnniversaryTableAdapter.Fill(Me.AnniverseryDataSet.anniversary)
        'TODO: This line of code loads data into the 'BirthdayDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.BirthdayDataSet.Table1)
        gb1.Visible = False
        gb2.Visible = False
        gb3.Visible = False

    End Sub

    Private Sub cb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked = True Then
            gb1.Visible = True
        End If
    End Sub

    Private Sub cb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb2.CheckedChanged
        If cb2.Checked = True Then
            gb2.Visible = True
        End If

    End Sub

    Private Sub cb3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb3.CheckedChanged
        If cb3.Checked = True Then
            gb3.Visible = True
        End If

    End Sub
    
    Private Sub Table1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Table1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BirthdayDataSet)

    End Sub

    Private Sub gb2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gb2.Enter

    End Sub

    Private Sub Couple_nameLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Couple_nameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Time_of_appointmentDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Time_of_appointmentDateTimePicker.ValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Table1BindingSource.AddNew()
    End Sub
End Class