Imports System.Data.SqlClient
'Sự kiện Load form Login'
Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTenDangNhap.Clear()
        txtMatKhau.Clear()
    End Sub

    'Sự kiện Click Login'
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim chuoiketnoi As String = "workstation id=tritnps02687.mssql.somee.com;packet size=4096;user id=tritnps02687_SQLLogin_2;pwd=a264wzcmg7;data source=tritnps02687.mssql.somee.com;persist security info=False;initial catalog=tritnps02687"
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("Select * from NhanVien where MaNV='" & txtTenDangNhap.Text & "' And Pass='" & txtMatKhau.Text & "' ", ketnoi)
        Dim tb As New DataTable

        Try
            ketnoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Đăng nhập thành công")
                Me.Close()
                frmMain.Show()
            Else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu")
                txtTenDangNhap.Clear()
                txtMatKhau.Clear()
                txtTenDangNhap.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Sự kiện Click Exit'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    
End Class
