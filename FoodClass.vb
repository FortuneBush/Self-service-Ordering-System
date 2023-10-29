Public Class FoodClass
    Private mname As String
    Private mspecification As String
    Private mkind As String
    Private mprice As Double
    Private mtime As Double
    Public Sub New(ByVal Name As String, ByVal Specification As String, ByVal Kind As String, ByVal Price As Double, ByVal Time As Double)
        Me.mname = Name
        Me.mspecification = Specification
        Me.mkind = Kind
        Me.mprice = Price
        Me.mtime = Time
    End Sub
    Property Name() As String
        Get
            Return Me.mname
        End Get
        Set(value As String)
            Me.mname = value
        End Set
    End Property
    Property Specification() As String
        Get
            Return Me.mspecification
        End Get
        Set(value As String)
            Me.mspecification = value
        End Set
    End Property
    Property Kind() As String
        Get
            Return Me.mkind
        End Get
        Set(value As String)
            Me.mkind = value
        End Set
    End Property
    Property Price() As Double
        Get
            Return Me.mprice
        End Get
        Set(value As Double)
            Me.mprice = value
        End Set
    End Property
    Property Time() As Double
        Get
            Return Me.mtime
        End Get
        Set(value As Double)
            Me.mprice = value
        End Set
    End Property

End Class
