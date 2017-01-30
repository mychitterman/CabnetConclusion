Imports System.Net.Mail

Public Class Form1
    Public filename As String
    Public ServerLocation As String = "http://cabconclusion.hrd.gd/"
    Private Sub MainTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MainTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MainTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CabCon)

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FormLogIn.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set 3d to the splitcontainer as border style

        'TODO: This line of code loads data into the 'OrganisDS.ListMinistry' table. You can move, or remove it, as needed.
        Me.ListMinistryTableAdapter.Fill(Me.OrganisDS.ListMinistry)
        'TODO: This line of code loads data into the 'CabCon.MainTable' table. You can move, or remove it, as needed.
        Me.MainTableTableAdapter.Fill(Me.CabCon.MainTable, Date.Today.Year)
        Welcome.Text = "Welcome " + FormLogIn.TextBoxUser.Text
        ComboBoxFilterMinistry.SelectedIndex = -1
    End Sub

    

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Buttonlogoutclose.Click
        FormLogIn.Close()
        Me.Close()

    End Sub

    Private Sub Record_IDLabel1_TextChanged(sender As Object, e As EventArgs) Handles Record_IDLabel1.TextChanged

    End Sub

   

    Private Sub MainTableDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MainTableDataGridView.RowHeaderMouseClick
        Try
            If (CheckSubmission.CheckState = CheckState.Unchecked) Then
                'we create the file linkage to the index by using the filenumber and Year eg. 149 of 2010 
                filename = Record_IDLabel1.Text + "-" + YEARLinkLabel.Text + ".pdf"
                'browse to the file by going to the yearfolder thenn file the filemby it's name.

                WebBrowser1.Navigate(ServerLocation + YEARLinkLabel.Text + "/" + filename)

            ElseIf (CheckSubmission.CheckState = CheckState.Checked) Then
                filename = Record_IDLabel1.Text + "A" + "-" + YEARLinkLabel.Text + ".pdf"
                WebBrowser1.Navigate(ServerLocation + YEARLinkLabel.Text + "/" + filename)
            End If
        Catch ex As Exception
            MessageBox.Show("No file found")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmEmailOut.ShowDialog()
       

    End Sub

    Private Sub KeyWordsBTN_Click(sender As Object, e As EventArgs) Handles KeyWordsBTN.Click
        cmdReset.PerformClick()
        Me.MainTableTableAdapter.FillBy(Me.CabCon.MainTable, TextBoxKeyWords.Text)
    End Sub

    Private Sub MainTableDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MainTableDataGridView.CellClick
        Try
            If (CheckSubmission.CheckState = CheckState.Unchecked) Then
                filename = Record_IDLabel1.Text + "-" + YEARLinkLabel.Text + ".pdf"
                WebBrowser1.Navigate(ServerLocation + YEARLinkLabel.Text + "/" + filename)
            ElseIf (CheckSubmission.CheckState = CheckState.Unchecked) Then
                filename = Record_IDLabel1.Text + "A" + "-" + YEARLinkLabel.Text + ".pdf"
                WebBrowser1.Navigate(ServerLocation + YEARLinkLabel.Text + "/" + filename)
            End If
        Catch ex As Exception
            ' MessageBox.Show("No file found")
        End Try
    End Sub

    Private Sub CheckSubmission_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckSubmission.CheckStateChanged

    End Sub

 

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If (String.IsNullOrWhiteSpace(TextBox2.Text) = False) Then
            MainTableBindingSource.Filter = String.Format("Year = '{0}'", Convert.ToDouble(TextBox2.Text))
        Else
            MainTableBindingSource.RemoveFilter()
        End If

    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        MainTableBindingSource.RemoveFilter()
        'clear all textboxes
        TextBox2.Text = String.Empty
        ComboBoxFilterMinistry.Text = String.Empty
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFilterMinistry.SelectedIndexChanged
        '' MessageBox.Show(ComboBox1.SelectedValue.ToString)
        '  MainTableBindingSource.Filter = String.Format("Ministry LIKE '{0}'", ComboBox1.SelectedValue.ToString)

    End Sub

    Private Sub cmdFilter_Click(sender As Object, e As EventArgs) Handles cmdFilter.Click
        FilterResults()

      
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        AddConclusion.ShowDialog()
    End Sub

    Private Sub ComboBoxFilterMinistry_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxFilterMinistry.TextChanged
        FilterResults()
    End Sub

    Private Sub FilterResults()
        Dim yearvalueFilter = TextBox2.Text
        Dim MinistrySelected = ComboBoxFilterMinistry.Text
        If yearvalueFilter = "" Then
            yearvalueFilter = Date.Today.Year

        End If
        If MinistrySelected = "" Then
            MinistrySelected = "%"
        End If
        Dim rowFilter = String.Format("[{0}] <= '{1}'", "Year", yearvalueFilter)
        rowFilter += String.Format(" AND [{0}] = '{1}'", "Ministry", MinistrySelected)
        MainTableBindingSource.Filter = rowFilter
    End Sub
End Class
