<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerMenu
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
        Me.Passbook_btn = New System.Windows.Forms.Button()
        Me.Edit_Btn = New System.Windows.Forms.Button()
        Me.Transfer_btn = New System.Windows.Forms.Button()
        Me.Logout_Btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Passbook_btn
        '
        Me.Passbook_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passbook_btn.Location = New System.Drawing.Point(12, 67)
        Me.Passbook_btn.Name = "Passbook_btn"
        Me.Passbook_btn.Size = New System.Drawing.Size(284, 39)
        Me.Passbook_btn.TabIndex = 0
        Me.Passbook_btn.Text = "Passbook"
        Me.Passbook_btn.UseVisualStyleBackColor = True
        '
        'Edit_Btn
        '
        Me.Edit_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_Btn.Location = New System.Drawing.Point(12, 129)
        Me.Edit_Btn.Name = "Edit_Btn"
        Me.Edit_Btn.Size = New System.Drawing.Size(284, 39)
        Me.Edit_Btn.TabIndex = 1
        Me.Edit_Btn.Text = "Edit Personal Details"
        Me.Edit_Btn.UseVisualStyleBackColor = True
        '
        'Transfer_btn
        '
        Me.Transfer_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Transfer_btn.Location = New System.Drawing.Point(12, 193)
        Me.Transfer_btn.Name = "Transfer_btn"
        Me.Transfer_btn.Size = New System.Drawing.Size(284, 39)
        Me.Transfer_btn.TabIndex = 2
        Me.Transfer_btn.Text = "Money Transfer"
        Me.Transfer_btn.UseVisualStyleBackColor = True
        '
        'Logout_Btn
        '
        Me.Logout_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout_Btn.Location = New System.Drawing.Point(12, 248)
        Me.Logout_Btn.Name = "Logout_Btn"
        Me.Logout_Btn.Size = New System.Drawing.Size(284, 39)
        Me.Logout_Btn.TabIndex = 3
        Me.Logout_Btn.Text = "Logout"
        Me.Logout_Btn.UseVisualStyleBackColor = True
        '
        'CustomerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 306)
        Me.Controls.Add(Me.Logout_Btn)
        Me.Controls.Add(Me.Transfer_btn)
        Me.Controls.Add(Me.Edit_Btn)
        Me.Controls.Add(Me.Passbook_btn)
        Me.Name = "CustomerMenu"
        Me.Text = "CustomerMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Passbook_btn As Button
    Friend WithEvents Edit_Btn As Button
    Friend WithEvents Transfer_btn As Button
    Friend WithEvents Logout_Btn As Button
End Class
