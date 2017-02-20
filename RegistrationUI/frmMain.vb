'Affirmation of Authorship: 
'Name:Bryan Esteban
'Date: 7/27/15
'I affirm that this program was created by me. It is solely my work and does not include any work done by anyone else.

Imports RegistrationBusiness

Public Class frmMain
    ' TODO: Create Public class variable objVehicle as New instance of VehicleBO
    Public objVehicle As New VehicleBO

    ' TODO: Create Private class variable frmDetails as New instance of frmDetails
    Private frmDetails As New frmDetails
    ' Check to determine if the vehicle is stolen
    Private Sub btnCheck_Click() Handles btnCheck.Click
        Try
            ' Dimension blnStolen variable
            Dim blnStolen As Boolean

            ' TODO: Populate blnStolen by calling objVehicle Stolen() function
            blnStolen = objVehicle.Stolen()

            ' Display message
            If blnStolen Then
                ' TODO: Populate lblResult to indicate vehicle is stolen
                lblResult.Text = "Vehicle is Stolen"
            Else
                ' TODO: Populate lblResult to indicate vehicle is not stolen
                lblResult.Text = "Vehicle is not Stolen"
            End If

        Catch ex As Exception

            ' TODO: Populate lblResult with error message
            lblResult.Text = "Error has accured please try your input again"

        End Try
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' TODO: Clear lblDetails and lblResults
        lblDetails.ResetText()
        lblResult.ResetText()

        ' TODO: Populate the cboVehicleType combobox using objVehicle .Types()
        cboVehicleType.DataSource = objVehicle.Types()
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click

        ' Edit to ensure a vehicle type is selected
        If Me.cboVehicleType.Text <> "" Then

            ' TODO: Clear lblResults
            lblResult.ResetText()

            ' TODO: Show the frmDetails details form as modal dialog
            frmDetails.ShowDialog()
        Else

            ' Display messagebox for user to select a vehicle type
            MessageBox.Show("Please select a vehicle type.")
        End If

    End Sub


End Class
