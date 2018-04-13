Public Class DequeNode

    Private mdata As Object
    Private rightlink As DequeNode
    Private leftlink As DequeNode

    Public Sub New()
        rightlink = Nothing
        leftlink = Nothing
    End Sub

    Public Sub New(data As Object)
        mdata = data
        rightlink = Nothing
        leftlink = Nothing
    End Sub

    Public Property data() As Object
        Get
            Return mdata
        End Get
        Set(value As Object)
            mdata = value
        End Set
    End Property

    Public Property right() As DequeNode
        Get
            Return rightlink
        End Get
        Set(value As DequeNode)
            rightlink = value
        End Set
    End Property

    Public Property left() As DequeNode
        Get
            Return leftlink
        End Get
        Set(value As DequeNode)
            leftlink = value
        End Set
    End Property
End Class
