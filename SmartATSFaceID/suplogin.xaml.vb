Public Class suplogin
    Private Sub loginButton_Copy_Click(sender As Object, e As RoutedEventArgs) Handles loginButton_Copy.Click
        Dim adm As New loginScreen
        Me.Close()
        adm.Show()
    End Sub

    Private Sub loginButton_Click(sender As Object, e As RoutedEventArgs) Handles loginButton.Click
        Dim connect As New Window1
        Me.Close()
        connect.Show()
    End Sub
End Class
