Imports System.Data.OleDb

Public Class frmLogin
    Dim da As OleDbDataAdapter
    Dim dset As New DataSet
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        da = New OleDbDataAdapter("Select * from tblAdmin where Username='" & txtUname.Text & "' and Password='" & txtPassword.Text & "'", conn)

        dset = New DataSet
        da.Fill(dset, "tblAdmin")
        If dset.Tables("tblAdmin").Rows.Count = 1 Then
            frmDashboard.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub roundCorners(obj As Form)
        obj.FormBorderStyle = FormBorderStyle.None

        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()

        Dim radius As Integer = 8

        ' Top Left
        DGP.AddArc(New Rectangle(0, 0, 2 * radius, 2 * radius), 180, 90)
        DGP.AddLine(radius, 0, obj.Width - radius, 0)

        ' Top Right
        DGP.AddArc(New Rectangle(obj.Width - 2 * radius, 0, 2 * radius, 2 * radius), -90, 90)
        DGP.AddLine(obj.Width, radius, obj.Width, obj.Height - radius)

        ' Bottom Right
        DGP.AddArc(New Rectangle(obj.Width - 2 * radius, obj.Height - 2 * radius, 2 * radius, 2 * radius), 0, 90)
        DGP.AddLine(obj.Width - radius, obj.Height, radius, obj.Height)

        ' Bottom Left
        DGP.AddArc(New Rectangle(0, obj.Height - 2 * radius, 2 * radius, 2 * radius), 90, 90)
        DGP.CloseAllFigures()

        obj.Region = New Region(DGP)
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click

    End Sub
End Class
