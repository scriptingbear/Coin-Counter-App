<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoinCounter
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.spnAmount = New System.Windows.Forms.NumericUpDown()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        CType(Me.spnAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "# Quarters"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "# Dimes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 28)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "# Nickels"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 28)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "# Pennies"
        '
        'spnAmount
        '
        Me.spnAmount.Location = New System.Drawing.Point(112, 25)
        Me.spnAmount.Name = "spnAmount"
        Me.spnAmount.Size = New System.Drawing.Size(66, 34)
        Me.spnAmount.TabIndex = 1
        '
        'lblQuarters
        '
        Me.lblQuarters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQuarters.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblQuarters.Location = New System.Drawing.Point(112, 67)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(66, 25)
        Me.lblQuarters.TabIndex = 2
        Me.lblQuarters.Tag = "25"
        Me.lblQuarters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDimes
        '
        Me.lblDimes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDimes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDimes.Location = New System.Drawing.Point(112, 110)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(66, 25)
        Me.lblDimes.TabIndex = 2
        Me.lblDimes.Tag = "10"
        Me.lblDimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNickels
        '
        Me.lblNickels.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNickels.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNickels.Location = New System.Drawing.Point(112, 149)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(66, 25)
        Me.lblNickels.TabIndex = 2
        Me.lblNickels.Tag = "5"
        Me.lblNickels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPennies
        '
        Me.lblPennies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPennies.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPennies.Location = New System.Drawing.Point(112, 189)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(66, 25)
        Me.lblPennies.TabIndex = 2
        Me.lblPennies.Tag = "1"
        Me.lblPennies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCoinCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 290)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.spnAmount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCoinCounter"
        Me.Text = "Coin Counter"
        CType(Me.spnAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents spnAmount As NumericUpDown
    Friend WithEvents lblQuarters As Label
    Friend WithEvents lblDimes As Label
    Friend WithEvents lblNickels As Label
    Friend WithEvents lblPennies As Label
End Class
