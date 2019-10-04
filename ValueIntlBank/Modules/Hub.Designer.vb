<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hub
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hub))
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton2 = New Bunifu.UI.WinForms.BunifuImageButton()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuImageButton2)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Silver
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Black
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Navy
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DeepPink
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(800, 450)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.ActiveImage = Nothing
        Me.BunifuImageButton2.AllowAnimations = True
        Me.BunifuImageButton2.AllowBuffering = False
        Me.BunifuImageButton2.AllowZooming = True
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.ErrorImage = CType(resources.GetObject("BunifuImageButton2.ErrorImage"), System.Drawing.Image)
        Me.BunifuImageButton2.FadeWhenInactive = False
        Me.BunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageLocation = Nothing
        Me.BunifuImageButton2.ImageMargin = 40
        Me.BunifuImageButton2.ImageSize = New System.Drawing.Size(185, 155)
        Me.BunifuImageButton2.ImageZoomSize = New System.Drawing.Size(225, 195)
        Me.BunifuImageButton2.InitialImage = CType(resources.GetObject("BunifuImageButton2.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton2.Location = New System.Drawing.Point(12, 12)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Rotation = 0
        Me.BunifuImageButton2.ShowActiveImage = True
        Me.BunifuImageButton2.ShowCursorChanges = True
        Me.BunifuImageButton2.ShowImageBorders = True
        Me.BunifuImageButton2.ShowSizeMarkers = False
        Me.BunifuImageButton2.Size = New System.Drawing.Size(225, 195)
        Me.BunifuImageButton2.TabIndex = 1
        Me.BunifuImageButton2.ToolTipText = ""
        Me.BunifuImageButton2.WaitOnLoad = False
        Me.BunifuImageButton2.ZoomSpeed = 10
        '
        'Hub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Hub"
        Me.Text = "Hub"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuImageButton2 As Bunifu.UI.WinForms.BunifuImageButton
End Class
