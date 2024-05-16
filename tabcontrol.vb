Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add tabs to the TabControl
        TabControl1.TabPages.Add("Tab 1")
        TabControl1.TabPages.Add("Tab 2")
        TabControl1.TabPages.Add("Tab 3")

        ' Add controls to each tab
        Dim label1 As New Label()
        label1.Text = "This is Tab 1"
        TabControl1.TabPages(0).Controls.Add(label1)

        Dim label2 As New Label()
        label2.Text = "This is Tab 2"
        TabControl1.TabPages(1).Controls.Add(label2)

        Dim label3 As New Label()
        label3.Text = "This is Tab 3"
        TabControl1.TabPages(2).Controls.Add(label3)
    End Sub
End Class
