Public Class Form4

    Private Sub AnniversaryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnniversaryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AnniversaryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AnniverseryDataSet)

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BirthdayDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.BirthdayDataSet.Table1)
        'TODO: This line of code loads data into the 'AnniverseryDataSet.anniversary' table. You can move, or remove it, as needed.
        Me.AnniversaryTableAdapter.Fill(Me.AnniverseryDataSet.anniversary)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Banu" Then
            RichTextBox1.Text = "06-Jan-1980,34"
        ElseIf TextBox1.Text = "Prasath" Then
            RichTextBox1.Text = "10-Aug-1986,29"
        ElseIf TextBox1.Text = "Nivi" Then
            RichTextBox1.Text = "08-Feb-1991,24"
        ElseIf TextBox1.Text = "Prabhu" Then
            RichTextBox1.Text = "08-Jan-1982,32"
        ElseIf TextBox1.Text = "Latha" Then
            RichTextBox1.Text = "09-Jan-1960,54"
        ElseIf TextBox1.Text = "Prasath-Nivi" Then
            RichTextBox1.Text = "29-Aug-2014,0"
        ElseIf TextBox1.Text = "Prabhu-Shanthi" Then
            RichTextBox1.Text = "23-May-2010,4"
        ElseIf TextBox1.Text = "Babu-Latha,31" Then
            RichTextBox1.Text = "16-Jun-1983"
        ElseIf TextBox1.Text = "Guna-Gnana,34" Then
            RichTextBox1.Text = "02-Feb-1980"
        ElseIf TextBox1.Text = "kannan-Vinitha,2" Then
            RichTextBox1.Text = "14-Feb-2012"
        End If
        Button2.Visible = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "Banu" Then
            RichTextBox1.Text = "06-Jan-1980,34"
            MsgBox("Record is deleted Successfully")
        ElseIf TextBox1.Text = "Prasath" Then
            RichTextBox1.Text = "10-Aug-1986,29"
            MsgBox("Record is deleted Successfully")
        ElseIf TextBox1.Text = "Nivi" Then
            RichTextBox1.Text = "08-Feb-1991,24"
            MsgBox("Record is deleted Successfully")
        ElseIf TextBox1.Text = "Prabhu" Then
            RichTextBox1.Text = "08-Jan-1982,32"
            MsgBox("Record is deleted Successfully")
        ElseIf TextBox1.Text = "Latha" Then
            RichTextBox1.Text = "09-Jan-1960,54"
            MsgBox("Record is deleted Successfully")
        ElseIf TextBox1.Text = "Prasath-Nivi" Then
            RichTextBox1.Text = "29-Aug-2014,0"
            MsgBox("Record is deleted Successfully")
        ElseIf TextBox1.Text = "Prabhu-Shanthi" Then

            RichTextBox1.Text = "23-May-2010,4"
            MsgBox("Record is deleted Successfully")
        ElseIf TextBox1.Text = "Babu-Latha" Then
            RichTextBox1.Text = "16-Jun-1983,31"
            MsgBox("Record is deleted Successfully")
        ElseIf TextBox1.Text = "Guna-Gnana" Then
            RichTextBox1.Text = "02-Feb-1980,34"
            MsgBox("Record is deleted Successfully")
        ElseIf TextBox1.Text = "kannan-Vinitha" Then
            RichTextBox1.Text = "14-Feb-2012,2"
            MsgBox("Record is deleted Successfully")
        End If
        Button1.Visible = False
    End Sub
End Class