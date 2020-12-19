Public Class Form2

    Dim link1 As String = "https://www.dropbox.com/pri/get/PH0T05H0P%202021%20-ZT-.part1.rar?_download_id=707363812546461964124072262478832161784350953552830067287363555084&amp;_notify_domain=www.dropbox.com&amp;_subject_uid=580714725&amp;dl=1&amp;revision_id=BieMg1upbT4-L_bZ-JYji1hT_HQCXEiRmTAqx4J-Wo03QShqsRW259khtX0iwKhIsw_g8TvzbD4syC_MxX5mmAMMGcmBuyC-zKLa43kfYGGkZYgg30R9SbPfeqRHWFYKLciYFoeUSyc4t_-7MT9aNONP&amp;source=_private_jsinfo_helper&amp;w=AABg4ti05RyFCNfkfj2QtOwtCPgCtYR4kYuy_o02iRzm6Q"
    Dim link2 As String = "https://www.dropbox.com/pri/get/PH0T05H0P%202021%20-ZT-.part2.rar?_download_id=16508784622564976691082489088477222029455136463463099179006411723&amp;_notify_domain=www.dropbox.com&amp;_subject_uid=580714725&amp;dl=1&amp;revision_id=Bidx-0v42va7I2r8ex2oiYbDSZOjB1efy3KPNcfNMq1F3FAj0FhCoSBosUaYBwebI8czUySasiE6UPWMFpjEe2DjEY_uwMdkUShrGwUlSGFpQgEdrvgICDDVftXmaQoiV8JN30MKhsilbFnN7zde-PnZ&amp;source=_private_jsinfo_helper&amp;w=AACCSppAL4qfkrZj85VnlHda02Ry8XbBDeEsUN8y1njI7g"

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

        My.Computer.Network.DownloadFile((link1), (ruta & "\Photoshop-PARTE_1.rar"), "", "", True, 2000, True)

        MsgBox("Tu archivo ha sido descargado correctamente!", MsgBoxStyle.Information, "Operación completada!")

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
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

        My.Computer.Network.DownloadFile((link2), (ruta & "\Photoshop-PARTE_2.rar"), "", "", True, 2000, True)

        MsgBox("Tu archivo ha sido descargado correctamente!", MsgBoxStyle.Information, "Operación completada!")

    End Sub

End Class