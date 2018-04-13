
Module Module1

    Sub Main()
        Dim dq As deque = New deque()

        dq.inserFront("A")
        dq.print()

        dq.inserFront("B")
        dq.print()

        dq.inserFront("C")
        dq.print()

        dq.insertRear("D")
        dq.print()

        dq.insertRear("E")
        dq.print()

        dq.insertRear("F")
        dq.print()

        Console.WriteLine("deledted :" + dq.deleteFront())
        dq.print()

        Console.WriteLine("deledted :" + dq.deleteRear())
        dq.print()

    End Sub

End Module

