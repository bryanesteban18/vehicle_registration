Public Class TruckBO
    Inherits VehicleBO

    ' Private member variables
    Private dblCargoWeight As Double        ' Maximum cargo weight in pounds  
    Private blnFourWheelDrive As Boolean    ' Four wheel drive

    ' MaxCargoWeight property
    Public Property MaxCargoWeight() As Double
        Get
            Return dblCargoWeight
        End Get
        Set(ByVal value As Double)
            dblCargoWeight = value
        End Set
    End Property

    ' FourWheelDrive property
    Public Property FourWheelDrive() As Boolean
        Get
            Return blnFourWheelDrive
        End Get
        Set(ByVal value As Boolean)
            blnFourWheelDrive = value
        End Set
    End Property


    ' ToString() Function
    Public Overrides Function ToString() As String
        ' Return a string representation
        ' of a truck.
        Dim str As String
        str = MyBase.ToString() &
            " Max. Cargo: " & dblCargoWeight.ToString() &
            " 4WD: " & blnFourWheelDrive.ToString()
        Return str
    End Function
End Class
