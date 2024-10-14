Imports MySql.Data.MySqlClient

Public Class Form1
    Private conn As MySqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("Server=172.20.10.3;Database=mk9;Uid=username;Pwd=password;")
        LoadKelas() ' Load classes into ComboBox
        LoadData()
    End Sub

    Private Sub LoadKelas()
        Dim query As String = "SELECT idkelas, namakelas FROM kelas"
        Dim cmd As MySqlCommand = New MySqlCommand(query, conn)

        Try
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            cmbKelas.Items.Clear() ' Clear existing items
            While reader.Read()
                cmbKelas.Items.Add(New KeyValuePair(Of Integer, String)(reader("idkelas"), reader("namakelas")))
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadData()
        ' Use a JOIN query to retrieve both pelajar and kelas details
        Dim query As String = "SELECT p.idpelajar, p.namapelajar, p.nomatrik, k.namakelas " &
                          "FROM pelajar p " &
                          "INNER JOIN kelas k ON p.idkelas = k.idkelas"

        Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()

        Try
            conn.Open()
            adapter.Fill(table)
            dataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbKelas.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a class.")
            Return
        End If

        Dim selectedKelas = CType(cmbKelas.SelectedItem, KeyValuePair(Of Integer, String)).Key

        Dim query As String = "INSERT INTO pelajar (idpelajar, namapelajar, nomatrik, idkelas) VALUES (@idpelajar, @namapelajar, @nomatrik, @idkelas)"
        Dim cmd As MySqlCommand = New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@idpelajar", txtIdPelajar.Text)
        cmd.Parameters.AddWithValue("@namapelajar", txtNamaPelajar.Text)
        cmd.Parameters.AddWithValue("@nomatrik", txtNoMatrik.Text) ' Change this as needed
        cmd.Parameters.AddWithValue("@idkelas", selectedKelas)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Pelajar added successfully.")
            LoadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub dataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dataGridView1.Rows(e.RowIndex)
            txtIdPelajar.Text = row.Cells("idpelajar").Value.ToString()
            txtNamaPelajar.Text = row.Cells("namapelajar").Value.ToString()
            cmbKelas.SelectedItem = cmbKelas.Items.Cast(Of KeyValuePair(Of Integer, String))().FirstOrDefault(Function(c) c.Key = CInt(row.Cells("idkelas").Value))
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadData()

    End Sub
End Class
