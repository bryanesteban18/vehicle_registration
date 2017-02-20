Imports RegistrationData

Public Class VehicleBO

    ' Private member variables
    Private intVehicleIdNumber As Integer    ' VIN
    Private strMake As String    ' Make
    Private strModel As String   ' Model
    Private strColor As String   ' Color   

    ' Function for vehicle types
    Public Function Types() As String()
        Dim objData As New VehicleDO
        Return objData.Types
    End Function

    ' Function to determine if stolen
    Public Function Stolen() As Boolean
        Dim blnStolen As Boolean
        Dim intTest As Integer = intVehicleIdNumber Mod 2

        ' Logic to determine if stolen
        If intTest = 0 Then
            ' Even is not stolen
            blnStolen = False
        Else
            ' Odd is stolen
            blnStolen = True
        End If
        Return blnStolen
    End Function


    ' Passengers property
    Public Overridable Property ID() As Integer
        Get
            Return intVehicleIdNumber
        End Get
        Set(ByVal value As Integer)
            intVehicleIdNumber = value
        End Set
    End Property

    ' Description property
    Public Overridable Property Make() As String
        Get
            Return strMake
        End Get
        Set(ByVal value As String)
            strMake = value
        End Set
    End Property

    ' MaxSpeed property
    Public Property Model() As String
        Get
            Return strModel
        End Get
        Set(ByVal value As String)
            strModel = value
        End Set
    End Property

    ' Color property
    Public Overridable Property Color() As String
        Get
            Return strColor
        End Get
        Set(ByVal value As String)
            strColor = value
        End Set
    End Property

    ' Overriden ToString method
    Public Overrides Function ToString() As String
        ' Return a string representation of a vehicle.
        Dim str As String
        str = "VIN: " & intVehicleIdNumber.ToString() & " Make: " & strMake &
            " Model: " & strModel & " Color: " & strColor

        Return str
    End Function
End Class
