Imports System.Data.OleDb

Public Class calender
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Public x As String
    Dim b As Integer
    Dim c As Integer
    Dim m As Integer
    Dim n As Integer
    Dim i As Integer = 0
    Public j As Integer = 0





    Private Sub mc1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mc1.DateChanged
        i = i + 1
        If i <> 1 Then
            If j = 0 Then
                MsgBox(mc1.SelectionRange.Start() & vbCrLf & "sankari birthday ")
                j = j + 1
            ElseIf j = 1 Then
                MsgBox(mc1.SelectionRange.Start() & vbCrLf & "kumar birthday ")
                j = j + 1
            ElseIf j = 1 Then
                MsgBox(mc1.SelectionRange.Start() & vbCrLf & "keerthu birthday ")
                j = j + 1
            ElseIf j = 1 Then
                MsgBox(mc1.SelectionRange.Start() & vbCrLf & "Prasath birthday ")
                j = j + 1

            End If


        End If




    End Sub

    Private Sub calender_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\keerthana\Documents\birthday.accdb")
            cn.Open()
            cmd = New OleDbCommand("select DOB from table1", cn)
            dr = cmd.ExecuteReader
            x = Main.a
            mc1.SetDate(x)
            mc1.ShowToday = False
            mc1.ShowTodayCircle = False
            mc1.TitleBackColor = Color.Black
            mc1.TitleForeColor = Color.White
            While dr.Read()
                b = Date.Parse(dr(0)).Month
                c = Date.Parse(dr(0)).Day
                If b = Date.Parse(x).Month Then
                    mc1.AddBoldedDate(New Date(2014, b, c))

                End If
            End While

        Catch
            MsgBox("keerthu")
        End Try
        dr.Close()
        cn.Close()

        

       
        mc1.UpdateBoldedDates()
    End Sub
End Class