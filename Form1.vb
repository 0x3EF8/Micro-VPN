Imports System.IO

Public Class vpn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles connect.Click
        Try


            If Not Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\vpnconnector") Then
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\vpnconnector")
            End If
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\vpnconnector\connection.pbk", "[VPN]" & vbCrLf & "MEDIA=rastapi" & vbCrLf & "Port=VPN2-0" & vbCrLf & "Device=WAN Miniport (IKEv2)" & vbCrLf & "DEVICE=vpn" & vbCrLf & "PhoneNumber=" + Me.Host.Text)
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\vpnconnector\connection.bat", String.Concat(New String() {"rasdial ""VPN"" ", Me.Name.Text, " ", Me.Pass.Text, " /phonebook:""", Environment.GetFolderPath(Environment.SpecialFolder.Personal), "\vpnconnector\connection.pbk"""}))
            Dim process As Process = New Process()
            process.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\vpnconnector\connection.bat"
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            process.Start()
            process.WaitForExit()
            Me.connect.Enabled = False
            Me.Diconnect.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Diconnect.Click
        File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\vpnconnector\disconnect.bat", "rasdial/d")
        Dim process As Process = New Process()
        process.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\vpnconnector\disconnect.bat"
        process.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        process.Start()
        process.WaitForExit()
        Me.connect.Enabled = True
        Me.Diconnect.Enabled = False
    End Sub

    Private Sub Pass_TextChanged(sender As Object, e As EventArgs) Handles Pass.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Host_TextChanged(sender As Object, e As EventArgs) Handles Host.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Name_TextChanged(sender As Object, e As EventArgs) Handles Name.TextChanged

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("https://tempail.com/")
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://ipjetable.net/register.php")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://www.hidebux.com/")
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("https://www.proxysite.com/")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("https://www.youtube.com/watch?v=BBYREsZ2TRw")
    End Sub
End Class
