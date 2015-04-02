Imports System.Data.OleDb

Public Class Main
    Public a As DateTime
    

    Private Sub b2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b2.Click
        Form3.Show()
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
    End Sub

    Private Sub b3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b3.Click
        Form4.Show()
        Form4.Button2.Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Place:Le meridian" & vbCrLf & " Date of appointment:10-Oct-2014" & vbCrLf & "Time of appointment:6.00 pm" & vbCrLf & " Host's Name:Karthick")



    End Sub

    Private Sub cb1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb1.SelectedIndexChanged
        If cb1.SelectedItem = "January" Then
            a = "1 - jan - 14"
        ElseIf cb1.SelectedItem = "Febuarary" Then
            a = "1-Feb-14"
        ElseIf cb1.SelectedItem = "March" Then
            a = "1-Mar-14"
        ElseIf cb1.SelectedItem = "April" Then
            a = "1-Apr-14"
        ElseIf cb1.SelectedItem = "May" Then
            a = "1-May-14"
        ElseIf cb1.SelectedItem = "June" Then
            a = "1-Jun-14"
        ElseIf cb1.SelectedItem = "July" Then
            a = "1-Jul-14"
        ElseIf cb1.SelectedItem = "August" Then
            a = "1-Aug-14"
        ElseIf cb1.SelectedItem = "September" Then
            a = "1-Sep-14"
        ElseIf cb1.SelectedItem = "October" Then
            a = "1-Oct-14"
        ElseIf cb1.SelectedItem = "November" Then
            a = "1-Nov-14"
        ElseIf cb1.SelectedItem = "December" Then
            a = "1-Dec-14"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        calender.Show()

    End Sub

    Private Sub b4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b4.Click
        Form4.Show()
        Form4.Button1.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Form5.Show()

    End Sub
End Class
