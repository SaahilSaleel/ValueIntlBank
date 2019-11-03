<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageHub
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiverNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReadStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MessagehubBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VibDataSet = New ValueIntlBank.vibDataSet()
        Me.MessagehubTableAdapter = New ValueIntlBank.vibDataSetTableAdapters.messagehubTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MessagehubBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateTimeDataGridViewTextBoxColumn, Me.ReceiverNameDataGridViewTextBoxColumn, Me.Subject, Me.ReadStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MessagehubBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(687, 271)
        Me.DataGridView1.TabIndex = 0
        '
        'DateTimeDataGridViewTextBoxColumn
        '
        Me.DateTimeDataGridViewTextBoxColumn.DataPropertyName = "Date_Time"
        Me.DateTimeDataGridViewTextBoxColumn.HeaderText = "Date_Time"
        Me.DateTimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateTimeDataGridViewTextBoxColumn.Name = "DateTimeDataGridViewTextBoxColumn"
        Me.DateTimeDataGridViewTextBoxColumn.Width = 125
        '
        'ReceiverNameDataGridViewTextBoxColumn
        '
        Me.ReceiverNameDataGridViewTextBoxColumn.DataPropertyName = "Receiver_Name"
        Me.ReceiverNameDataGridViewTextBoxColumn.HeaderText = "Receiver"
        Me.ReceiverNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ReceiverNameDataGridViewTextBoxColumn.Name = "ReceiverNameDataGridViewTextBoxColumn"
        Me.ReceiverNameDataGridViewTextBoxColumn.Width = 125
        '
        'Subject
        '
        Me.Subject.DataPropertyName = "Subject"
        Me.Subject.HeaderText = "Subject"
        Me.Subject.MinimumWidth = 6
        Me.Subject.Name = "Subject"
        Me.Subject.Width = 125
        '
        'ReadStatusDataGridViewTextBoxColumn
        '
        Me.ReadStatusDataGridViewTextBoxColumn.DataPropertyName = "Read_Status"
        Me.ReadStatusDataGridViewTextBoxColumn.HeaderText = "Read_Status"
        Me.ReadStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ReadStatusDataGridViewTextBoxColumn.Name = "ReadStatusDataGridViewTextBoxColumn"
        Me.ReadStatusDataGridViewTextBoxColumn.Width = 125
        '
        'MessagehubBindingSource
        '
        Me.MessagehubBindingSource.DataMember = "messagehub"
        Me.MessagehubBindingSource.DataSource = Me.VibDataSet
        '
        'VibDataSet
        '
        Me.VibDataSet.DataSetName = "vibDataSet"
        Me.VibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MessagehubTableAdapter
        '
        Me.MessagehubTableAdapter.ClearBeforeFill = True
        '
        'MessageHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 417)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MessageHub"
        Me.Text = "MessageHub"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MessagehubBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VibDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VibDataSet As vibDataSet
    Friend WithEvents MessagehubBindingSource As BindingSource
    Friend WithEvents MessagehubTableAdapter As vibDataSetTableAdapters.messagehubTableAdapter
    Friend WithEvents DateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReceiverNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Subject As DataGridViewTextBoxColumn
    Friend WithEvents ReadStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
