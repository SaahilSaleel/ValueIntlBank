<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ColdataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VibDataSet = New ValueIntlBank.vibDataSet()
        Me.ColdataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColdataTableAdapter = New ValueIntlBank.vibDataSetTableAdapters.coldataTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.ColdataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColdataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(169, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Okay"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ColdataBindingSource1
        '
        Me.ColdataBindingSource1.DataMember = "coldata"
        Me.ColdataBindingSource1.DataSource = Me.VibDataSet
        '
        'VibDataSet
        '
        Me.VibDataSet.DataSetName = "vibDataSet"
        Me.VibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ColdataBindingSource
        '
        Me.ColdataBindingSource.DataMember = "coldata"
        Me.ColdataBindingSource.DataSource = Me.VibDataSet
        '
        'ColdataTableAdapter
        '
        Me.ColdataTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(139, 139)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(157, 22)
        Me.TextBox1.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(41, 93)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(125, 24)
        Me.ComboBox1.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.ColdataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VibDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColdataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = str
        Dim arr As String() = GetColNames("cusdetails")
        If str IsNot "" Then
            Me.Button1.PerformClick()
            Me.Button1.Visible() = False
            ComboBox1.Items.AddRange(arr)
        End If
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents VibDataSet As vibDataSet
    Friend WithEvents ColdataBindingSource As BindingSource
    Friend WithEvents ColdataTableAdapter As vibDataSetTableAdapters.coldataTableAdapter
    Friend WithEvents ColdataBindingSource1 As BindingSource
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
