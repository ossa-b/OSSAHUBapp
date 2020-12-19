Public Class Form1



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form3.Show()
        MsgBox("Le recomendamos que cada día presione el botón de buscar actualizaciónes para que no se quede en una versión anterior.", MsgBoxStyle.Exclamation, "Recomendación importante")
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Form4.Show()
        MsgBox("Le recomendamos que cada día presione el botón de buscar actualizaciónes para que no se quede en una versión anterior.", MsgBoxStyle.Exclamation, "Recomendación importante")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form5.Show()
        MsgBox("Le recomendamos que cada día presione el botón de buscar actualizaciónes para que no se quede en una versión anterior.", MsgBoxStyle.Exclamation, "Recomendación importante")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim linkversion As String = "https://pastebin.com/raw/3ChgP3Wq"
        Dim linkdescarga As String = "https://pastebin.com/raw/BcazYAPL"
        Dim ruta As String = TextBox1.Text
        Dim versionactual As String = My.Application.Info.Version.ToString

        My.Computer.Network.DownloadFile((linkversion), (ruta & "\version.txt"), "", "", False, 2000, True)
        My.Computer.Network.DownloadFile((linkdescarga), (ruta & "\link.txt"), "", "", False, 2000, True)

        Dim leerversion As String
        leerversion = My.Computer.FileSystem.ReadAllText(ruta & "\version.txt")

        Dim leerenlace As String
        leerenlace = My.Computer.FileSystem.ReadAllText(ruta & "\link.txt")

        If (leerversion > versionactual) Then
            Dim alerta As String
            alerta = MsgBox("Nueva versión disponible. Descargar ahora?", vbOKCancel)

            If (alerta = vbOK) Then
                Dim URL As String = (leerenlace)
                Process.Start(URL)

                Form7.Show()

            End If
        Else

            If (leerversion = versionactual) Then
                Dim alerta1 As String
                alerta1 = MsgBox("Actualmente estás en la versión más reciente! Versión actual: Beta 2 (Build 4)", MsgBoxStyle.Information, "Versión más reciente")

            End If

        End If

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Form6.Show()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Form2.Show()
        MsgBox("Le recomendamos que cada día presione el botón de buscar actualizaciónes para que no se quede en una versión anterior.", MsgBoxStyle.Exclamation, "Recomendación importante")
    End Sub

End Class
