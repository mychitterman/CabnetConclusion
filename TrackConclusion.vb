Public Class TrackConclusion

    Private Sub TblPolicyMonitoringBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblPolicyMonitoringBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblPolicyMonitoringBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TrackDS)

    End Sub

    Private Sub TrackConclusion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TrackDS.tblPolicyMonitoring' table. You can move, or remove it, as needed.
        Me.TblPolicyMonitoringTableAdapter.Fill(Me.TrackDS.tblPolicyMonitoring)

    End Sub



    Private Sub FillBy2ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy2ToolStripButton.Click
        Try
            Me.MainTableTableAdapter.FillBy2(Me.CabCon.MainTable, CType(UserInputValueToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class