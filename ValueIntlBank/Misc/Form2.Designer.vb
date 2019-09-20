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
        Me.BankdetailsTableAdapter1 = New ValueIntlBank.vibDataSetTableAdapters.bankdetailsTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CusdetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CusdetailsTableAdapter = New ValueIntlBank.vibDataSetTableAdapters.cusdetailsTableAdapter()
        Me.CusIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MidNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PincodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ColdataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColdataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CusdetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'BankdetailsTableAdapter1
        '
        Me.BankdetailsTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CusIDDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MidNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PincodeDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DoBDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.BranchnoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CusdetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(41, 139)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(674, 180)
        Me.DataGridView1.TabIndex = 3
        '
        'CusdetailsBindingSource
        '
        Me.CusdetailsBindingSource.DataMember = "cusdetails"
        Me.CusdetailsBindingSource.DataSource = Me.VibDataSet
        '
        'CusdetailsTableAdapter
        '
        Me.CusdetailsTableAdapter.ClearBeforeFill = True
        '
        'CusIDDataGridViewTextBoxColumn
        '
        Me.CusIDDataGridViewTextBoxColumn.DataPropertyName = "Cus_ID"
        Me.CusIDDataGridViewTextBoxColumn.HeaderText = "Cus_ID"
        Me.CusIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CusIDDataGridViewTextBoxColumn.Name = "CusIDDataGridViewTextBoxColumn"
        Me.CusIDDataGridViewTextBoxColumn.Width = 125
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.Width = 125
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.Width = 125
        '
        'MidNameDataGridViewTextBoxColumn
        '
        Me.MidNameDataGridViewTextBoxColumn.DataPropertyName = "Mid_Name"
        Me.MidNameDataGridViewTextBoxColumn.HeaderText = "Mid_Name"
        Me.MidNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MidNameDataGridViewTextBoxColumn.Name = "MidNameDataGridViewTextBoxColumn"
        Me.MidNameDataGridViewTextBoxColumn.Width = 125
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'PincodeDataGridViewTextBoxColumn
        '
        Me.PincodeDataGridViewTextBoxColumn.DataPropertyName = "Pincode"
        Me.PincodeDataGridViewTextBoxColumn.HeaderText = "Pincode"
        Me.PincodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PincodeDataGridViewTextBoxColumn.Name = "PincodeDataGridViewTextBoxColumn"
        Me.PincodeDataGridViewTextBoxColumn.Width = 125
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.Width = 125
        '
        'DoBDataGridViewTextBoxColumn
        '
        Me.DoBDataGridViewTextBoxColumn.DataPropertyName = "DoB"
        Me.DoBDataGridViewTextBoxColumn.HeaderText = "DoB"
        Me.DoBDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DoBDataGridViewTextBoxColumn.Name = "DoBDataGridViewTextBoxColumn"
        Me.DoBDataGridViewTextBoxColumn.Width = 125
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        Me.SexDataGridViewTextBoxColumn.Width = 125
        '
        'BranchnoDataGridViewTextBoxColumn
        '
        Me.BranchnoDataGridViewTextBoxColumn.DataPropertyName = "Branchno"
        Me.BranchnoDataGridViewTextBoxColumn.HeaderText = "Branchno"
        Me.BranchnoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BranchnoDataGridViewTextBoxColumn.Name = "BranchnoDataGridViewTextBoxColumn"
        Me.BranchnoDataGridViewTextBoxColumn.Width = 125
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.ColdataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VibDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColdataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CusdetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents BankdetailsTableAdapter1 As vibDataSetTableAdapters.bankdetailsTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CusdetailsBindingSource As BindingSource
    Friend WithEvents CusdetailsTableAdapter As vibDataSetTableAdapters.cusdetailsTableAdapter
    Friend WithEvents CusIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MidNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PincodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DoBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BranchnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
