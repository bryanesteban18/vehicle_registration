Public Class CarBO
    Inherits VehicleBO

    ' Private member variables
    Private intMaxSpeed As Double        ' Maximum Speed
    Private blnHybrid As Boolean    ' Electric Hybrid

    ' MaxSpeed property
    Public Property MaxSpeed() As Integer
        Get
            Return intMaxSpeed
        End Get
        Set(ByVal value As Integer)
            intMaxSpeed = value
        End Set
    End Property

    ' FourWheelDrive property
    Public Property Hybrid() As Boolean
        Get
            Return blnHybrid
        End Get
        Set(ByVal value As Boolean)
            blnHybrid = value
        End Set
    End Property

    ' ToString() Function
    Public Overrides Function ToString() As String
        ' Return a string representation of a car.
        Dim str As String
        str = MyBase.ToString() &
            " Max. Speed: " & intMaxSpeed.ToString() &
            " Hybrid: " & blnHybrid.ToString()
        Return str
    End Function
End Class
