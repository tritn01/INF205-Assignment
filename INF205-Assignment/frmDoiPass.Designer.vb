<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoiPass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDoiPass))
        Me.lblid = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.lbloldpass = New System.Windows.Forms.Label()
        Me.txtoldpass = New System.Windows.Forms.TextBox()
        Me.lblnewpass = New System.Windows.Forms.Label()
        Me.txtnewpass = New System.Windows.Forms.TextBox()
        Me.lblnewpass2 = New System.Windows.Forms.Label()
        Me.txtnewpass2 = New System.Windows.Forms.TextBox()
        Me.btnxacnhan = New System.Windows.Forms.Button()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblid
        '
        Me.lblid.BackColor = System.Drawing.Color.Transparent
        Me.lblid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblid.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblid.Location = New System.Drawing.Point(63, 28)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(103, 17)
        Me.lblid.TabIndex = 0
        Me.lblid.Text = "Tên đăng nhập:"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(177, 25)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(206, 25)
        Me.txtid.TabIndex = 1
        '
        'lbloldpass
        '
        Me.lbloldpass.BackColor = System.Drawing.Color.Transparent
        Me.lbloldpass.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbloldpass.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lbloldpass.Location = New System.Drawing.Point(78, 66)
        Me.lbloldpass.Name = "lbloldpass"
        Me.lbloldpass.Size = New System.Drawing.Size(87, 17)
        Me.lbloldpass.TabIndex = 0
        Me.lbloldpass.Text = "Mật khẩu cũ:"
        '
        'txtoldpass
        '
        Me.txtoldpass.Location = New System.Drawing.Point(177, 61)
        Me.txtoldpass.Name = "txtoldpass"
        Me.txtoldpass.Size = New System.Drawing.Size(206, 25)
        Me.txtoldpass.TabIndex = 1
        '
        'lblnewpass
        '
        Me.lblnewpass.BackColor = System.Drawing.Color.Transparent
        Me.lblnewpass.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblnewpass.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblnewpass.Location = New System.Drawing.Point(70, 102)
        Me.lblnewpass.Name = "lblnewpass"
        Me.lblnewpass.Size = New System.Drawing.Size(96, 17)
        Me.lblnewpass.TabIndex = 0
        Me.lblnewpass.Text = "Mật khẩu mới:"
        '
        'txtnewpass
        '
        Me.txtnewpass.Location = New System.Drawing.Point(177, 97)
        Me.txtnewpass.Name = "txtnewpass"
        Me.txtnewpass.Size = New System.Drawing.Size(206, 25)
        Me.txtnewpass.TabIndex = 1
        '
        'lblnewpass2
        '
        Me.lblnewpass2.BackColor = System.Drawing.Color.Transparent
        Me.lblnewpass2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblnewpass2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblnewpass2.Location = New System.Drawing.Point(16, 137)
        Me.lblnewpass2.Name = "lblnewpass2"
        Me.lblnewpass2.Size = New System.Drawing.Size(150, 17)
        Me.lblnewpass2.TabIndex = 0
        Me.lblnewpass2.Text = "Nhập lại mật khẩu mới:"
        '
        'txtnewpass2
        '
        Me.txtnewpass2.Location = New System.Drawing.Point(177, 134)
        Me.txtnewpass2.Name = "txtnewpass2"
        Me.txtnewpass2.Size = New System.Drawing.Size(206, 25)
        Me.txtnewpass2.TabIndex = 1
        '
        'btnxacnhan
        '
        Me.btnxacnhan.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnxacnhan.Location = New System.Drawing.Point(177, 178)
        Me.btnxacnhan.Name = "btnxacnhan"
        Me.btnxacnhan.Size = New System.Drawing.Size(99, 48)
        Me.btnxacnhan.TabIndex = 2
        Me.btnxacnhan.Text = "Xác nhận"
        Me.btnxacnhan.UseVisualStyleBackColor = True
        '
        'btnHuy
        '
        Me.btnHuy.ForeColor = System.Drawing.Color.DarkRed
        Me.btnHuy.Location = New System.Drawing.Point(286, 178)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(99, 48)
        Me.btnHuy.TabIndex = 2
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'frmDoiPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(438, 240)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnxacnhan)
        Me.Controls.Add(Me.txtnewpass2)
        Me.Controls.Add(Me.txtnewpass)
        Me.Controls.Add(Me.txtoldpass)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lblnewpass2)
        Me.Controls.Add(Me.lblnewpass)
        Me.Controls.Add(Me.lbloldpass)
        Me.Controls.Add(Me.lblid)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Name = "frmDoiPass"
        Me.Text = "Đổi Mật Khẩu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents lbloldpass As System.Windows.Forms.Label
    Friend WithEvents txtoldpass As System.Windows.Forms.TextBox
    Friend WithEvents lblnewpass As System.Windows.Forms.Label
    Friend WithEvents txtnewpass As System.Windows.Forms.TextBox
    Friend WithEvents lblnewpass2 As System.Windows.Forms.Label
    Friend WithEvents txtnewpass2 As System.Windows.Forms.TextBox
    Friend WithEvents btnxacnhan As System.Windows.Forms.Button
    Friend WithEvents btnHuy As System.Windows.Forms.Button
End Class
