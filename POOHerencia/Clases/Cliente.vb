Public Class Cliente
    'heredando de la clase persona.
    Inherits Persona

    'atributos de esta clase.
    Private _categoria As String
    Private _codigo As String

    'Propiedades que encapsulan los atributos.
    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    'Operaciones.
    Public Sub generarCodigo()
        'se llama el valor que encapsula codigo y se concatena con 
        'los apellidos y se saca la subcadena que irá desde 0 a 3 
        'concatenado al numero 16
        Me.Codigo = "C" & Me.Apellidos.Substring(0, 3) & "16"

    End Sub



End Class
