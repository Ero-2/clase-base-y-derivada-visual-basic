Public Class figura

    Public Property Ancho As Double
        Public Property Altura As Double

        Public Overridable Function CalcularArea() As Double
            Return Ancho * Altura
        End Function
    End Class
