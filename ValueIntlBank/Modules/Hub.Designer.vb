<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hub
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hub))
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.EmployeeSelect = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SelfServiceSelect = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.CustomerServiceSelect = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.AdminSelect_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.AdminSelect_btn)
        Me.BunifuGradientPanel1.Controls.Add(Me.EmployeeSelect)
        Me.BunifuGradientPanel1.Controls.Add(Me.SelfServiceSelect)
        Me.BunifuGradientPanel1.Controls.Add(Me.CustomerServiceSelect)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Silver
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Black
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Navy
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DeepPink
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(241, 381)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'EmployeeSelect
        '
        Me.EmployeeSelect.Active = False
        Me.EmployeeSelect.Activecolor = System.Drawing.Color.DarkViolet
        Me.EmployeeSelect.BackColor = System.Drawing.Color.DarkOrchid
        Me.EmployeeSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EmployeeSelect.BorderRadius = 0
        Me.EmployeeSelect.ButtonText = "Employee"
        Me.EmployeeSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmployeeSelect.DisabledColor = System.Drawing.Color.Gray
        Me.EmployeeSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.EmployeeSelect.Iconcolor = System.Drawing.Color.Transparent
        Me.EmployeeSelect.Iconimage = Nothing
        Me.EmployeeSelect.Iconimage_right = Nothing
        Me.EmployeeSelect.Iconimage_right_Selected = Nothing
        Me.EmployeeSelect.Iconimage_Selected = Nothing
        Me.EmployeeSelect.IconMarginLeft = 0
        Me.EmployeeSelect.IconMarginRight = 0
        Me.EmployeeSelect.IconRightVisible = False
        Me.EmployeeSelect.IconRightZoom = 0R
        Me.EmployeeSelect.IconVisible = True
        Me.EmployeeSelect.IconZoom = 90.0R
        Me.EmployeeSelect.IsTab = False
        Me.EmployeeSelect.Location = New System.Drawing.Point(1, 176)
        Me.EmployeeSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeSelect.Name = "EmployeeSelect"
        Me.EmployeeSelect.Normalcolor = System.Drawing.Color.DarkOrchid
        Me.EmployeeSelect.OnHovercolor = System.Drawing.Color.DarkViolet
        Me.EmployeeSelect.OnHoverTextColor = System.Drawing.Color.White
        Me.EmployeeSelect.selected = False
        Me.EmployeeSelect.Size = New System.Drawing.Size(305, 59)
        Me.EmployeeSelect.TabIndex = 6
        Me.EmployeeSelect.Text = "Employee"
        Me.EmployeeSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeSelect.Textcolor = System.Drawing.Color.Black
        Me.EmployeeSelect.TextFont = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SelfServiceSelect
        '
        Me.SelfServiceSelect.Active = False
        Me.SelfServiceSelect.Activecolor = System.Drawing.Color.DarkViolet
        Me.SelfServiceSelect.BackColor = System.Drawing.Color.DarkOrchid
        Me.SelfServiceSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SelfServiceSelect.BorderRadius = 0
        Me.SelfServiceSelect.ButtonText = "Self Service"
        Me.SelfServiceSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SelfServiceSelect.DisabledColor = System.Drawing.Color.Gray
        Me.SelfServiceSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SelfServiceSelect.Iconcolor = System.Drawing.Color.Transparent
        Me.SelfServiceSelect.Iconimage = Nothing
        Me.SelfServiceSelect.Iconimage_right = Nothing
        Me.SelfServiceSelect.Iconimage_right_Selected = Nothing
        Me.SelfServiceSelect.Iconimage_Selected = Nothing
        Me.SelfServiceSelect.IconMarginLeft = 0
        Me.SelfServiceSelect.IconMarginRight = 0
        Me.SelfServiceSelect.IconRightVisible = False
        Me.SelfServiceSelect.IconRightZoom = 0R
        Me.SelfServiceSelect.IconVisible = True
        Me.SelfServiceSelect.IconZoom = 90.0R
        Me.SelfServiceSelect.IsTab = False
        Me.SelfServiceSelect.Location = New System.Drawing.Point(0, 65)
        Me.SelfServiceSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.SelfServiceSelect.Name = "SelfServiceSelect"
        Me.SelfServiceSelect.Normalcolor = System.Drawing.Color.DarkOrchid
        Me.SelfServiceSelect.OnHovercolor = System.Drawing.Color.DarkViolet
        Me.SelfServiceSelect.OnHoverTextColor = System.Drawing.Color.White
        Me.SelfServiceSelect.selected = False
        Me.SelfServiceSelect.Size = New System.Drawing.Size(305, 59)
        Me.SelfServiceSelect.TabIndex = 5
        Me.SelfServiceSelect.Text = "Self Service"
        Me.SelfServiceSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SelfServiceSelect.Textcolor = System.Drawing.Color.Black
        Me.SelfServiceSelect.TextFont = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CustomerServiceSelect
        '
        Me.CustomerServiceSelect.Active = False
        Me.CustomerServiceSelect.Activecolor = System.Drawing.Color.DarkViolet
        Me.CustomerServiceSelect.BackColor = System.Drawing.Color.DarkOrchid
        Me.CustomerServiceSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CustomerServiceSelect.BorderRadius = 0
        Me.CustomerServiceSelect.ButtonText = "Customer Service"
        Me.CustomerServiceSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CustomerServiceSelect.DisabledColor = System.Drawing.Color.Gray
        Me.CustomerServiceSelect.ForeColor = System.Drawing.Color.Black
        Me.CustomerServiceSelect.Iconcolor = System.Drawing.Color.Transparent
        Me.CustomerServiceSelect.Iconimage = Nothing
        Me.CustomerServiceSelect.Iconimage_right = Nothing
        Me.CustomerServiceSelect.Iconimage_right_Selected = Nothing
        Me.CustomerServiceSelect.Iconimage_Selected = Nothing
        Me.CustomerServiceSelect.IconMarginLeft = 0
        Me.CustomerServiceSelect.IconMarginRight = 0
        Me.CustomerServiceSelect.IconRightVisible = False
        Me.CustomerServiceSelect.IconRightZoom = 0R
        Me.CustomerServiceSelect.IconVisible = True
        Me.CustomerServiceSelect.IconZoom = 90.0R
        Me.CustomerServiceSelect.IsTab = False
        Me.CustomerServiceSelect.Location = New System.Drawing.Point(2, 119)
        Me.CustomerServiceSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerServiceSelect.Name = "CustomerServiceSelect"
        Me.CustomerServiceSelect.Normalcolor = System.Drawing.Color.DarkOrchid
        Me.CustomerServiceSelect.OnHovercolor = System.Drawing.Color.DarkViolet
        Me.CustomerServiceSelect.OnHoverTextColor = System.Drawing.Color.White
        Me.CustomerServiceSelect.selected = False
        Me.CustomerServiceSelect.Size = New System.Drawing.Size(304, 59)
        Me.CustomerServiceSelect.TabIndex = 4
        Me.CustomerServiceSelect.Text = "Customer Service"
        Me.CustomerServiceSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustomerServiceSelect.Textcolor = System.Drawing.Color.Black
        Me.CustomerServiceSelect.TextFont = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'AdminSelect_btn
        '
        Me.AdminSelect_btn.Active = False
        Me.AdminSelect_btn.Activecolor = System.Drawing.Color.DarkViolet
        Me.AdminSelect_btn.BackColor = System.Drawing.Color.DarkOrchid
        Me.AdminSelect_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AdminSelect_btn.BorderRadius = 0
        Me.AdminSelect_btn.ButtonText = "Admin"
        Me.AdminSelect_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdminSelect_btn.DisabledColor = System.Drawing.Color.Gray
        Me.AdminSelect_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AdminSelect_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.AdminSelect_btn.Iconimage = Nothing
        Me.AdminSelect_btn.Iconimage_right = Nothing
        Me.AdminSelect_btn.Iconimage_right_Selected = Nothing
        Me.AdminSelect_btn.Iconimage_Selected = Nothing
        Me.AdminSelect_btn.IconMarginLeft = 0
        Me.AdminSelect_btn.IconMarginRight = 0
        Me.AdminSelect_btn.IconRightVisible = False
        Me.AdminSelect_btn.IconRightZoom = 0R
        Me.AdminSelect_btn.IconVisible = True
        Me.AdminSelect_btn.IconZoom = 90.0R
        Me.AdminSelect_btn.IsTab = False
        Me.AdminSelect_btn.Location = New System.Drawing.Point(0, 234)
        Me.AdminSelect_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.AdminSelect_btn.Name = "AdminSelect_btn"
        Me.AdminSelect_btn.Normalcolor = System.Drawing.Color.DarkOrchid
        Me.AdminSelect_btn.OnHovercolor = System.Drawing.Color.DarkViolet
        Me.AdminSelect_btn.OnHoverTextColor = System.Drawing.Color.White
        Me.AdminSelect_btn.selected = False
        Me.AdminSelect_btn.Size = New System.Drawing.Size(305, 59)
        Me.AdminSelect_btn.TabIndex = 7
        Me.AdminSelect_btn.Text = "Admin"
        Me.AdminSelect_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AdminSelect_btn.Textcolor = System.Drawing.Color.Black
        Me.AdminSelect_btn.TextFont = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Hub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 381)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Hub"
        Me.Text = "Hub"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents EmployeeSelect As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents SelfServiceSelect As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents CustomerServiceSelect As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents AdminSelect_btn As Bunifu.Framework.UI.BunifuFlatButton
End Class
