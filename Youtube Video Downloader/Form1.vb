Imports VideoLibrary
Imports YoutubeExtractor
Imports System.IO
Public Class Form1

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            MsgBox("Aguarde, Por favor...", MsgBoxStyle.Information, "Download iniciado!")
            Dim video = YouTube.Default.GetVideo(txtUrl.Text)
            File.WriteAllBytes(FolderBrowserDialog1.SelectedPath & "/" & video.FullName, video.GetBytes())
            MsgBox("Download feito com sucesso!", MsgBoxStyle.Information, "Sucesso!")
        End If
    End Sub
End Class
