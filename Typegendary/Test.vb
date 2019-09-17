Imports Typegendary_Classes.MapPoint

Public Class Test
    Sub Main()
        Dim point As New Wall With {
            .PointType = Wall.Type.Wall_0
        }





    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorDialog1.ShowDialog()

    End Sub
End Class