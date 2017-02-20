Imports RegistrationBusiness

Public Class frmDetails

    ' Dimension private class variable for vehicle type
    Private strVehicleType As String

    ' TODO: Dimension public class variable objCar as New instance of CarBO
    Dim objCar As New CarBO

    ' TODO: Dimension public class variable objTruck as New instance of TruckBO
    Dim objTruck As New TruckBO

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Try
            ' Call PopulateValues() method
            Call PopulateValues()

            ' Based on the specific vehicle type selected on MainForm,
            Select Case strVehicleType
                Case "Car"
                    ' TODO: Populate MainForm public objVehicle from DetailForm objCar
                    frmMain.objVehicle = objCar
                    ' TODO: and MainForm lblDetails from DetailForm objCar .ToString()
                    frmMain.lblDetails.Text = objCar.ToString()
                Case "Truck"
                    ' TODO: Populate MainForm public objVehicle from DetailForm objTruck
                    frmMain.objVehicle = objTruck
                    ' TODO: and MainForm lblDetails from DetailForm objTruck .ToString()
                    frmMain.lblDetails.Text = objTruck.ToString()
            End Select

        Catch vx As VehicleException

            ' Display message and exception number if VehicleException occurs
            MessageBox.Show(vx.Message + " - Code=" + vx.ExceptionNumber.ToString)

        Catch ex As Exception

            ' Display message if Exception occurs
            MessageBox.Show("Please check all input fields. " + ex.Message)

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Hide the details form
        Me.Hide()
    End Sub

    Private Sub DetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set class variable for strVehicleType from MainForm cboVehicleType
        strVehicleType = frmMain.cboVehicleType.Text

        ' Based on the specific vehicle type selected on MainForm,
        ' show appropriate groupbox and hide all other grouboxes
        Select Case strVehicleType
            Case "Car"
                gbCar.Show()
                gbTruck.Hide()
            Case "Truck"
                gbCar.Hide()
                gbTruck.Show()
        End Select

    End Sub

    Private Sub PopulateValues()

        ' Based on the specific vehicle type selected on MainForm,
        ' populate properties in CarBO or TruckBO
        Select Case strVehicleType
            Case "Car"
                ' Populate objCar properties from DetailsForm screen values
                ' TODO: objCar.ID
                objCar.ID = txtID.Text
                ' TODO: objCar.Make
                objCar.Make = txtMake.Text
                ' TODO: objCar.Model
                objCar.Model = txtModel.Text
                ' TODO: objCar.Color
                objCar.Color = txtColor.Text
                ' TODO: objCar.MaxSpeed
                objCar.MaxSpeed = txtMaxSpeed.Text
                ' TODO: objCar.Hybrid
                objCar.Hybrid = chkHybrid.Checked
            Case "Truck"
                ' Populate objTruck properties from DetailsForm screen values
                ' TODO: objTruck.ID
                objTruck.ID = txtID.Text
                ' TODO: objTruck.Make
                objTruck.Make = txtMake.Text
                ' TODO: objTruck.Model
                objTruck.Model = txtModel.Text
                ' TODO: objTruck.Color
                objTruck.Color = txtColor.Text
                ' TODO: objTruck.MaxCargoWeight
                objTruck.MaxCargoWeight = txtMaxCargo.Text
                ' TODO: objTruck.FourWheelDrive
                objTruck.FourWheelDrive = chk4x4.Checked
        End Select
    End Sub


End Class