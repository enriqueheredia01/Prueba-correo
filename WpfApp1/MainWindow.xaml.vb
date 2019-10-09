Imports System.Net.Mail

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        button.Visibility = Visibility.Hidden
        Try
            Dim SMTP As New SmtpClient
            'Configuración SMTP
            'SMTP.UseDefaultCredentials = False
            SMTP.Credentials = New Net.NetworkCredential("info@sos-food.com", "sosfood2019**escritorioseguro")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Host = "mail.sos-food.com"
            SMTP.Send("info@sos-food.com", "enriqueheredia.e@gmail.com", "Hola", "un saludo makina.......")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        button.Visibility = Visibility.Visible
    End Sub
End Class
