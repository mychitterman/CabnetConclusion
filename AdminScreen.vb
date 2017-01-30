Public Class AdminScreen

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UsersDS)
        Me.ListMinistryBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.OrganisDS)
    End Sub

    Private Sub AdminScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OrganisDS.ListMinistry' table. You can move, or remove it, as needed.
        Me.ListMinistryTableAdapter.Fill(Me.OrganisDS.ListMinistry)
        'TODO: This line of code loads data into the 'UsersDS.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.UsersDS.Users)

    End Sub

    Private Sub AddDevice_Click(sender As Object, e As EventArgs) Handles CmdAddDevice.Click
        AddDevice.ShowDialog()



    End Sub
End Class
