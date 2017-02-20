Public Class VehicleDO

    Public Shared ReadOnly VehicleTypes() As String =
     {"Car", "Truck"}

    Function Types() As String()
        Return VehicleTypes
    End Function
End Class
