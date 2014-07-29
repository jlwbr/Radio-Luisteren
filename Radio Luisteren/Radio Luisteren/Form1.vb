Imports System.Net
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer1.URL = "http://icecast.omroep.nl/radio1-bb-mp3"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.URL = "http://icecast.omroep.nl/radio2-bb-mp3"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.URL = "http://icecast.omroep.nl/3fm-bb-mp3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.URL = "http://icecast.omroep.nl/radio4-bb-mp3"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AxWindowsMediaPlayer1.URL = "http://icecast.omroep.nl/radio5-bb-mp3"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AxWindowsMediaPlayer1.URL = "http://icecast.omroep.nl/radio6-bb-mp3"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AxWindowsMediaPlayer1.URL = "http://icecast.omroep.nl/funx-bb-mp3"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AxWindowsMediaPlayer1.URL = "http://stream.100p.nl/100pctnl.mp3"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AxWindowsMediaPlayer1.URL = "http://82.201.100.9:8000/radio538.m3u"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AxWindowsMediaPlayer1.URL = "http://vip2.str.reasonnet.com/qmusic.mp3.96.m3u"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        AxWindowsMediaPlayer1.URL = "http://8543.live.streamtheworld.com/VERONICACMP3"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        AxWindowsMediaPlayer1.URL = "http://8623.live.streamtheworld.com:80/SKYRADIOAAC_SC"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        AxWindowsMediaPlayer1.URL = "http://82.201.100.10:8000/SLAMFM_MP3_HQ"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim web As New WebClient 'To be able to download the content from the latest version file you have stored.
        Dim LatestVersion As String = web.DownloadString("https://www.dropbox.com/s/wd8qf5k4p2o9yn8/version.txt?dl=1") 'To download the Lastest Version from a specified URL.
        Dim CurrentApp As String = My.Application.Info.Version.ToString 'Gets the applications current version


        If CurrentApp < LatestVersion Then 'If the applications current version is less than the Latest version Then it will update, otherwise just do nothing or w/e you want.

            If MessageBox.Show("Er is een nieuwe update!" & vbNewLine & "Wil je updaten?", "Auto Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then 'Message box dialog asking the user if they wish to update or not.
                My.Computer.Network.DownloadFile("https://www.dropbox.com/s/41s57u17144q6u9/Radio%20Luisteren.exe?dl=1", Application.StartupPath & "\Updated\Auto Updater.exe") 'If they choose Yes, it will download the latest version exe
                MsgBox("The update is gedownload!" & vbNewLine & "De applicatie zal nu sluiten") 'telling the user the app will close
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Updated\Auto Updater.exe")
                End 'exits application
            Else
                'If they choose No
            End If

        Else

        End If
    End Sub
End Class