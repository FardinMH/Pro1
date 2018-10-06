Public Class Database
    Public RollNo As Integer
    Public Name As String
    Public MobileNo As String
    Public Address As String

    Public Sub asd()
        RollNo = 1
        Name = " Name1"
        MobileNo = 10000000
        Address = "Address1"
    End Sub
    Public Function next1()
        RollNo = RollNo + 1
        Name = Name & Name
        MobileNo = MobileNo + 1
        Address = Address & Address
    End Function
End Class
