Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmDoiPass
    Dim database As New DataTable ' Tạo đối tượng database để lưu trữ dữ liệu từ Database Online
    'Tạo chuỗi kết nối để kết nối tới Database Online
    Dim chuoiconnect As String = "workstation id=tritnps02687.mssql.somee.com;packet size=4096;user id=tritnps02687_SQLLogin_2;pwd=a264wzcmg7;data source=tritnps02687.mssql.somee.com;persist security info=False;initial catalog=tritnps02687"
    Dim connect As SqlConnection = New SqlConnection(chuoiconnect)

    Private Sub btnxacnhan_Click(sender As Object, e As EventArgs) Handles btnxacnhan.Click
        Dim chuoiketnoi As String = "workstation id=tritnps02687.mssql.somee.com;packet size=4096;user id=tritnps02687_SQLLogin_2;pwd=a264wzcmg7;data source=tritnps02687.mssql.somee.com;persist security info=False;initial catalog=tritnps02687"
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("Select * from NhanVien where MaNV='" & txtid.Text & "' And Pass='" & txtoldpass.Text & "' ", ketnoi)
        Dim tb As New DataTable
            ketnoi.Open()
            sqlAdapter.Fill(tb)
        If tb.Rows.Count > 0 And txtnewpass.Text = txtnewpass2.Text Then
            Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online
            ' Câu truy vấn để get dữ liệu
            Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", connect)
            'Kết nối mở ra
            connect.Open()
            'Đổ dữ liệu vào đối tượng database
            Query1.Fill(database)
            Dim editpw As String = "Update NhanVien set Pass= @newPass where MaNV= @MaNV and Pass=@oldPass"
            Dim suapw As New SqlCommand(editpw, connect)

            suapw.Parameters.AddWithValue("@MaNV", txtid.Text)
            suapw.Parameters.AddWithValue("@oldPass", txtoldpass.Text)
            suapw.Parameters.AddWithValue("@newPass", txtnewpass2.Text)
            suapw.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Sửa Mật Khẩu Thành Công")
            Me.Close()
        Else
            MessageBox.Show("Sửa Không Thành Công")
            txtid.Clear()
            txtnewpass.Clear()
            txtnewpass2.Clear()
            txtoldpass.Clear()
        End If
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        txtid.Clear()
        txtnewpass.Clear()
        txtnewpass2.Clear()
        txtoldpass.Clear()
    End Sub
End Class