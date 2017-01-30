Public Class AddDevice

  

    Private Sub TblDevices1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblDevices1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblDevices1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DeviceAccessDS)

    End Sub

    Private Sub AddDevice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DeviceAccessDS.tblDevices1' table. You can move, or remove it, as needed.
        Me.TblDevices1TableAdapter.Fill(Me.DeviceAccessDS.tblDevices1)

    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        TblDevices1BindingNavigatorSaveItem.PerformClick()
        MessageBox.Show("Device saved")

    End Sub
End Class