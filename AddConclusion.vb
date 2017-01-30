Public Class AddConclusion

    Private Sub cmdAddSave_Click(sender As Object, e As EventArgs) Handles cmdAddSave.Click
        ' save a new record.
        'First check all the value.
        Try
            Dim InsertNewCabCon As New CabConTableAdapters.MainTableTableAdapter
            Dim results = InsertNewCabCon.Insert(RecordIDTxt.Text, ComboBoxMinistry.SelectedValue, TextBoxDate.Text, ComboBoxResults.SelectedValue, TextBoxSubject.Text, TextBoxComment.Text, TextBoxYear.Text, ComboBoxDocType.SelectedValue)
            If (results = 1) Then
                Try
                    Me.MainTableTableAdapter.FillBy1(Me.CabCon.MainTable, New System.Nullable(Of Double)(CType(TextBoxYear.Text, Double)))
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub RecordIDTxt_TextChanged(sender As Object, e As EventArgs) Handles RecordIDTxt.TextChanged
        ' check for empty cell then fire if empty
        If String.IsNullOrWhiteSpace(RecordIDTxt.Text) Then
            MessageBox.Show("Please enter the record ID")
        End If
    End Sub

    Private Sub RecordIDTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RecordIDTxt.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub AddConclusion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OrganisDS.tbloutcomes' table. You can move, or remove it, as needed.
        Me.TbloutcomesTableAdapter.Fill(Me.OrganisDS.tbloutcomes)

        'TODO: This line of code loads data into the 'OrganisDS.docCategory' table. You can move, or remove it, as needed.
        Me.DocCategoryTableAdapter.Fill(Me.OrganisDS.docCategory)
       
        'TODO: This line of code loads data into the 'OrganisDS.ListMinistry' table. You can move, or remove it, as needed.
        Me.ListMinistryTableAdapter.Fill(Me.OrganisDS.ListMinistry)
        TextBoxYear.Text = Date.Today.Year
        'find the last number for the year enterd.
        ComboBoxDocType.SelectedIndex = -1
        ComboBoxMinistry.SelectedIndex = -1
        ComboBoxResults.SelectedIndex = -1
        Dim ConclusionEndedAt As New CabConTableAdapters.MainTableTableAdapter
        Dim myRecord As New CabCon.MainTableDataTable
        myRecord = ConclusionEndedAt.GetData(TextBoxYear.Text)

        'If ( myRecord[0].)
    End Sub

   

 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FileName = TwainLib.ScanImages()
        'For Each itm In FileName
        '    ListBox1.Items.Add(itm)
        'Next

    End Sub
End Class