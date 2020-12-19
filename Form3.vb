Public Class Form3

    Dim link As String = "https://cdn.discordapp.com/attachments/757592939387027586/772976517553848320/Among_us_v2020.10.22s.rar"

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        With FolderBrowserDialog1
            .RootFolder = Environment.SpecialFolder.Desktop

            .Description = "Selecciona la carpeta donde desea guardar su archivo"

            .ShowNewFolderButton = True

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBox1.Text = .SelectedPath


            End If

        End With

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MsgBox("Estás a punto de descargar tu archivo. Presiona aceptar para comenzar la descarga.", MsgBoxStyle.Information, "Esperando confirmación...")

        Dim ruta As String = TextBox1.Text

        If My.Computer.Network.IsAvailable = False Then
            MsgBox("No estas conectado a internet! Conectate y vuelve a intentarlo.", MsgBoxStyle.Critical, "Error de conexión")
            Return
        End If

        If TextBox1.Text = Nothing Then
            MsgBox("Debes seleccionar una ruta de descarga para tu archivo!", MsgBoxStyle.Information, "Ruta de descarga vacía")
            Return
        End If

        My.Computer.Network.DownloadFile((link), (ruta & "\AmongUS-OSSAHUBapp.rar"), "", "", True, 2000, True)

        MsgBox("Tu archivo ha sido descargado correctamente!", MsgBoxStyle.Information, "Operación completada!")

    End Sub

End Class