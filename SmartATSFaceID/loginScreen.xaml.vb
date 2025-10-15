Public Class loginScreen
    Private Sub loginButton_Click(sender As Object, e As RoutedEventArgs) Handles loginButton.Click
        Dim connect As New Window1
        Me.Close()
        connect.Show()
    End Sub

    Private Sub loginButton_Copy_Click(sender As Object, e As RoutedEventArgs) Handles loginButton_Copy.Click
        Dim sup As New suplogin
        Me.Close()
        sup.Show()
    End Sub
End Class
