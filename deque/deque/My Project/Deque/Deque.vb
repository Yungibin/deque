Public Class Deque

    Private front As DequeNode
    Private rear As DequeNode

    Public Sub New()
        front = Nothing
        rear = Nothing
    End Sub

    Public Function isEmpty() As Boolean
        Return front Is Nothing
    End Function

    Public Sub inserFront(item As Object)
        Dim node As DequeNode = New DequeNode(item)
        If isEmpty() Then
            front = node
            rear = node
            node.right = Nothing
            node.left = Nothing
            Console.WriteLine("node " + node.data + " / front " + front.data)
        Else
            node.right = front
            node.left = Nothing
            front.left = node
            front = node
            Console.WriteLine("node " + node.data + " / front " + front.data)
        End If
    End Sub

    Public Function deleteFront() As Object
        If isEmpty() Then
            Console.WriteLine("nothing")
            Return 0
        Else
            Dim data As Object = front.data
            If front.right Is Nothing Then
                front = Nothing
                rear = Nothing
            Else
                front = front.right
                front.left = Nothing
            End If
            Return data
        End If
    End Function

    Public Sub insertRear(item As Object)
        Dim node As DequeNode = New DequeNode(item)
        If isEmpty() Then
            front = node
            rear = node
            node.right = Nothing
            node.left = Nothing
        Else
            node.left = rear
            node.right = Nothing
            rear.right = node
            rear = node
        End If
    End Sub

    Public Function deleteRear() As Object
        If isEmpty() Then
            Console.WriteLine("nothing")
            Return 0
        Else
            Dim data As Object = rear.data
            If rear.left Is Nothing Then
                front = Nothing
                rear = Nothing
            Else
                rear = rear.left
                rear.right = Nothing
            End If
            Return data
        End If
    End Function

    Public Sub removeFront()
        If isEmpty() Then
            Console.WriteLine("nothing")
        Else
            If front.right Is Nothing Then
                front = Nothing
                rear = Nothing
            Else
                front = front.right
                front.left = Nothing
            End If
        End If
    End Sub

    Public Sub removeRear()
        If isEmpty() Then
            Console.WriteLine("nothing")
        Else
            If rear.left Is Nothing Then
                front = Nothing
                rear = Nothing
            Else
                rear = rear.left
                rear.right = Nothing
            End If
        End If
    End Sub

    Public Function peekRear()
        If isEmpty() Then
            Console.WriteLine("nothing")
            Return 0
        Else
            Return rear.data
        End If
    End Function

    Public Function peekFront()
        If isEmpty() Then
            Console.WriteLine("nothing")
            Return 0
        Else
            Return front.data
        End If
    End Function

    Public Sub print()
        If isEmpty() Then
            Console.WriteLine("nothing")
        Else
            Console.WriteLine("***** You have *****")
            Dim node As DequeNode = front
            While node IsNot Nothing
                Console.WriteLine(node.data)
                node = node.right
            End While
        End If
    End Sub

End Class
