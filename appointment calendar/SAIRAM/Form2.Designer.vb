<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calender
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mc1 = New System.Windows.Forms.MonthCalendar
        Me.SuspendLayout()
        '
        'mc1
        '
        Me.mc1.Location = New System.Drawing.Point(196, 97)
        Me.mc1.Name = "mc1"
        Me.mc1.TabIndex = 1
        '
        'calender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._1
        Me.ClientSize = New System.Drawing.Size(634, 372)
        Me.Controls.Add(Me.mc1)
        Me.Name = "calender"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mc1 As System.Windows.Forms.MonthCalendar
End Class
