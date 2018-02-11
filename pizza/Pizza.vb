Public Class Pizza

    Private nomValue As String
    Private tailleValue As String
    Private cuissonValue As String
    Private patevalue As String


    Public Sub CreatePizza(nom As String, taille As String, cuisson As String, pate As String)
        Me.nomValue = nom
        Me.tailleValue = taille
        Me.cuissonValue = cuisson
        Me.patevalue = pate
    End Sub

    Public Property Nom As String
        Get
            Return nomValue
        End Get
        Set(ByVal value As String)
            nomValue = value
        End Set
    End Property


    Public Property Taille As String
        Get
            Return tailleValue
        End Get
        Set(ByVal value As String)
            tailleValue = value
        End Set
    End Property

    Public Property Cuisson As String
        Get
            Return cuissonValue
        End Get
        Set(ByVal value As String)
            cuissonValue = value
        End Set
    End Property


    Public Property Pate As String
        Get
            Return patevalue
        End Get
        Set(ByVal value As String)
            patevalue = value
        End Set
    End Property

End Class
