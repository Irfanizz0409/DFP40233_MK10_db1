<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtIdPelajar = New TextBox()
        txtNamaPelajar = New TextBox()
        txtNoMatrik = New TextBox()
        cmbKelas = New ComboBox()
        btnAdd = New Button()
        dataGridView1 = New DataGridView()
        Timer1 = New Timer(components)
        CType(dataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtIdPelajar
        ' 
        txtIdPelajar.Location = New Point(20, 30)
        txtIdPelajar.Name = "txtIdPelajar"
        txtIdPelajar.PlaceholderText = "Enter ID Pelajar"
        txtIdPelajar.Size = New Size(542, 27)
        txtIdPelajar.TabIndex = 0
        ' 
        ' txtNamaPelajar
        ' 
        txtNamaPelajar.Location = New Point(20, 70)
        txtNamaPelajar.Name = "txtNamaPelajar"
        txtNamaPelajar.PlaceholderText = "Enter Nama Pelajar"
        txtNamaPelajar.Size = New Size(542, 27)
        txtNamaPelajar.TabIndex = 1
        ' 
        ' txtNoMatrik
        ' 
        txtNoMatrik.Location = New Point(20, 110)
        txtNoMatrik.Name = "txtNoMatrik"
        txtNoMatrik.PlaceholderText = "Enter No Matrik"
        txtNoMatrik.Size = New Size(542, 27)
        txtNoMatrik.TabIndex = 2
        ' 
        ' cmbKelas
        ' 
        cmbKelas.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKelas.FormattingEnabled = True
        cmbKelas.Location = New Point(20, 150)
        cmbKelas.Name = "cmbKelas"
        cmbKelas.Size = New Size(542, 28)
        cmbKelas.TabIndex = 3
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(575, 30)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(146, 27)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' dataGridView1
        ' 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridView1.Location = New Point(20, 190)
        dataGridView1.Name = "dataGridView1"
        dataGridView1.RowHeadersWidth = 51
        dataGridView1.Size = New Size(701, 150)
        dataGridView1.TabIndex = 7
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Form1
        ' 
        ClientSize = New Size(743, 356)
        Controls.Add(dataGridView1)
        Controls.Add(btnAdd)
        Controls.Add(cmbKelas)
        Controls.Add(txtNoMatrik)
        Controls.Add(txtNamaPelajar)
        Controls.Add(txtIdPelajar)
        Name = "Form1"
        Text = "Pelajar Management"
        CType(dataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIdPelajar As TextBox
    Friend WithEvents txtNamaPelajar As TextBox
    Friend WithEvents txtNoMatrik As TextBox
    Friend WithEvents cmbKelas As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents dataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
End Class
