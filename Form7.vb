Public Class Form7

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        My.Computer.FileSystem.DeleteFile(TextBox1.Text,
Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently,
Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
    End Sub
End Class

