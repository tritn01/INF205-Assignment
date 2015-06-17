Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmKhachHang
    Dim database As New DataTable ' Tạo đối tượng database để lưu trữ dữ liệu từ Database Online
    'Tạo chuỗi kết nối để kết nối tới Database Online
    Dim chuoiconnect As String = "workstation id=tritnps02687.mssql.somee.com;packet size=4096;user id=tritnps02687_SQLLogin_2;pwd=a264wzcmg7;data source=tritnps02687.mssql.somee.com;persist security info=False;initial catalog=tritnps02687"
    Dim connect As SqlConnection = New SqlConnection(chuoiconnect)

    'Sự kiện Load form KhachHang'
    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để get dữ liệu
        Dim Query2 As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database
        Query2.Fill(database)
        'Hiển thị dữ liệu ra Datagridview
        dgvKH.DataSource = database.DefaultView
    End Sub

    'Sự kiện Click ô dữ liệu trong DataGridView'
    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellContentClick
        Dim index As Integer = dgvKH.CurrentCell.RowIndex
        txtMaKH.Text = dgvKH.Item(0, index).Value
        txtTenKH.Text = dgvKH.Item(1, index).Value
        txtSDT.Text = dgvKH.Item(2, index).Value
        txtEmail.Text = dgvKH.Item(3, index).Value
        txtDiaChi.Text = dgvKH.Item(4, index).Value
    End Sub

    'Sự kiện Click Thêm khách hàng'
    Private Sub btnThemKH_Click(sender As Object, e As EventArgs) Handles btnThemKH.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Tạo query câu truy vấn Insert into
        Dim TaoKH As String = "insert into KhachHang values (@MaKH,@TenKH,@SDT,@Email,@DiaChi)"
        'Tạo đối tượng để thực thi câu truy vấn với DB ONline
        Dim AddKH As New SqlCommand(TaoKH, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng
            AddKH.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            AddKH.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
            AddKH.Parameters.AddWithValue("@SDT", txtSDT.Text)
            AddKH.Parameters.AddWithValue("@Email", txtEmail.Text)
            AddKH.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
            'Exucute là ghi dữ liệu vào Database
            MessageBox.Show("Thêm thành công khách hàng")
            AddKH.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Không thành công!")
        End Try
        'Cập nhật dữ liệu'
        Loaddata()
    End Sub

    'Định nghĩa hàm Loaddata để cập nhật lại dữ liệu'
    Private Sub Loaddata()
        database.Clear()
        dgvKH.DataSource = database
        dgvKH.DataSource = Nothing
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query2 As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)

        connect.Open()
        Query2.Fill(database)
        dgvKH.DataSource = database.DefaultView
    End Sub

    'Sự kiện Click Sửa khách hàng'
    Private Sub btnSuaKH_Click(sender As Object, e As EventArgs) Handles btnSuaKH.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        connect.Open()
        Dim SuaKH As String = "Update KhachHang set TenKH= @TenKH, SDT= @SDT, Email= @Email, DiaChi= @DiaChi where MaKH= @MaKH"
        Dim EditKH As New SqlCommand(SuaKH, connect)

        Try
            EditKH.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            EditKH.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
            EditKH.Parameters.AddWithValue("@SDT", txtSDT.Text)
            EditKH.Parameters.AddWithValue("@Email", txtEmail.Text)
            EditKH.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
            EditKH.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Sửa Thành Công")
        Catch ex As Exception
            MessageBox.Show("Sửa Không Thành Công")
        End Try
        'Cập nhật dữ liệu'
        Loaddata()
    End Sub

    'Sự kiện Click Xóa khách hàng'
    Private Sub btnXoaKH_Click(sender As Object, e As EventArgs) Handles btnXoaKH.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        connect.Open()
        Dim XoaKH As String = "Delete from KhachHang where MaKH=@MaKH"
        Dim DelKH As New SqlCommand(XoaKH, connect)
        Try
            DelKH.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            DelKH.ExecuteNonQuery()
            MessageBox.Show("Xóa Thành Công")
        Catch ex As Exception
            MessageBox.Show("Xóa Không Thành Công")
        End Try
        Loaddata()
    End Sub

    'Sự kiện Click Tìm khách hàng'
    Private Sub btnTimKH_Click(sender As Object, e As EventArgs) Handles btnTimKH.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'kết nối mở'
        connect.Open()
        Dim database As New DataTable
        database.Clear()
        dgvKH.DataSource = database
        dgvKH.DataSource = Nothing
        Dim connectnone As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang where MaKH like '" & txtMaKH.Text & "'", connectnone)
        connectnone.Open()
        Query.Fill(database)
        dgvKH.DataSource = database.DefaultView
    End Sub
End Class