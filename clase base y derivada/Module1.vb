Module Module1
    Sub Main()
        Dim figura1 As figura = New figura()
        Dim rectangulo1 As rectangulo = New rectangulo()
        figura1.Ancho = 5
        figura1.Altura = 10
        Dim areaFigura1 As Double = figura1.CalcularArea()
        Console.WriteLine("Área de figura1: " & areaFigura1)
        rectangulo1.Ancho = 5
        rectangulo1.Altura = 10
        Dim areaRectangulo1 As Double = rectangulo1.CalcularArea()
        Console.WriteLine("Área de rectangulo1: " & areaRectangulo1)
        Console.ReadKey()
    End Sub
End Module
