Imports System

Public Class VehicleException
    'Custom Exception class 
    Inherits System.ApplicationException

    Public Property ExceptionNumber As Integer
    Public Sub New()
    End Sub
    ' Creates a Sub New for the exception that allows you to set the
    ' message property when thrown.
    Public Sub New(Message As String, Number As Integer)
        MyBase.New(Message)
        ExceptionNumber = Number
    End Sub
    ' Creates a Sub New that can be used when you also want to include
    ' the inner exception.
    Public Sub New(Message As String, Inner As Exception)
        MyBase.New(Message)
    End Sub

End Class
