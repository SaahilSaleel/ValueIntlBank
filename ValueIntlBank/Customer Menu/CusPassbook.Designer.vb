<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CusPassbook
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
        Me.TransIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitCusIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitAccNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditCusIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditAccnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VibDataSet = New ValueIntlBank.vibDataSet()
        Me.ReceiptsTableAdapter = New ValueIntlBank.vibDataSetTableAdapters.receiptsTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransIDDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.DateTimeDataGridViewTextBoxColumn, Me.DebitCusIDDataGridViewTextBoxColumn, Me.DebitAccNoDataGridViewTextBoxColumn, Me.CreditCusIDDataGridViewTextBoxColumn, Me.CreditAccnoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReceiptsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1059, 402)
        Me.DataGridView1.TabIndex = 0
        '
        'TransIDDataGridViewTextBoxColumn
        '
        Me.TransIDDataGridViewTextBoxColumn.DataPropertyName = "Trans_ID"
        Me.TransIDDataGridViewTextBoxColumn.HeaderText = "Trans_ID"
        Me.TransIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TransIDDataGridViewTextBoxColumn.Name = "TransIDDataGridViewTextBoxColumn"
        Me.TransIDDataGridViewTextBoxColumn.Width = 125
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.Width = 125
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.Width = 125
        '
        'DateTimeDataGridViewTextBoxColumn
        '
        Me.DateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime"
        Me.DateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime"
        Me.DateTimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateTimeDataGridViewTextBoxColumn.Name = "DateTimeDataGridViewTextBoxColumn"
        Me.DateTimeDataGridViewTextBoxColumn.Width = 125
        '
        'DebitCusIDDataGridViewTextBoxColumn
        '
        Me.DebitCusIDDataGridViewTextBoxColumn.DataPropertyName = "Debit_Cus_ID"
        Me.DebitCusIDDataGridViewTextBoxColumn.HeaderText = "Debit_Cus_ID"
        Me.DebitCusIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DebitCusIDDataGridViewTextBoxColumn.Name = "DebitCusIDDataGridViewTextBoxColumn"
        Me.DebitCusIDDataGridViewTextBoxColumn.Width = 125
        '
        'DebitAccNoDataGridViewTextBoxColumn
        '
        Me.DebitAccNoDataGridViewTextBoxColumn.DataPropertyName = "Debit_AccNo"
        Me.DebitAccNoDataGridViewTextBoxColumn.HeaderText = "Debit_AccNo"
        Me.DebitAccNoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DebitAccNoDataGridViewTextBoxColumn.Name = "DebitAccNoDataGridViewTextBoxColumn"
        Me.DebitAccNoDataGridViewTextBoxColumn.Width = 125
        '
        'CreditCusIDDataGridViewTextBoxColumn
        '
        Me.CreditCusIDDataGridViewTextBoxColumn.DataPropertyName = "Credit_Cus_ID"
        Me.CreditCusIDDataGridViewTextBoxColumn.HeaderText = "Credit_Cus_ID"
        Me.CreditCusIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CreditCusIDDataGridViewTextBoxColumn.Name = "CreditCusIDDataGridViewTextBoxColumn"
        Me.CreditCusIDDataGridViewTextBoxColumn.Width = 125
        '
        'CreditAccnoDataGridViewTextBoxColumn
        '
        Me.CreditAccnoDataGridViewTextBoxColumn.DataPropertyName = "Credit_Accno"
        Me.CreditAccnoDataGridViewTextBoxColumn.HeaderText = "Credit_Accno"
        Me.CreditAccnoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CreditAccnoDataGridViewTextBoxColumn.Name = "CreditAccnoDataGridViewTextBoxColumn"
        Me.CreditAccnoDataGridViewTextBoxColumn.Width = 125
        '
        'ReceiptsBindingSource
        '
        Me.ReceiptsBindingSource.DataMember = "receipts"
        Me.ReceiptsBindingSource.DataSource = Me.VibDataSet
        '
        'VibDataSet
        '
        Me.VibDataSet.DataSetName = "vibDataSet"
        Me.VibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceiptsTableAdapter
        '
        Me.ReceiptsTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(311, 433)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(503, 433)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 33)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(96, 493)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(470, 78)
        Me.TextBox1.TabIndex = 3
        '
        'Passbook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 583)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Passbook"
        Me.Text = "Passbook"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VibDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VibDataSet As vibDataSet
    Friend WithEvents ReceiptsBindingSource As BindingSource
    Friend WithEvents ReceiptsTableAdapter As vibDataSetTableAdapters.receiptsTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TransIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DebitCusIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DebitAccNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreditCusIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreditAccnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
End Class
