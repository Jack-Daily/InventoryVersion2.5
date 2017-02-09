Public Class Form1

    Private Sub Part_ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.InventorySheet1' table. You can move, or remove it, as needed.
        Me.InventorySheet1TableAdapter.Fill(Me.Database1DataSet.InventorySheet1)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        InventorySheet1BindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        InventorySheet1BindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        InventorySheet1BindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        On Error GoTo SaveErr
        InventorySheet1BindingSource.EndEdit()
        '   Table1TableAdapter.Update(Database1DataSet.Table1)
        MessageBox.Show("OK BOSS")
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        InventorySheet1BindingSource.RemoveCurrent()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnSelfDestruct.Click
        Timer1.Enabled = True
        lblTimer.Visible = True
        lblTimer.BringToFront()
       
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimer.Text = lblTimer.Text - 1
        If lblTimer.Text = 0 Then
            Timer1.Enabled = False
            MessageBox.Show("YOU FOOL NOW WE'RE ALL GOING TO DIE!!!! ")
        End If
        If lblTimer.Text = 0 Then
            picBoom.BringToFront()
            picBoom.Visible = True
        End If

    End Sub
End Class
