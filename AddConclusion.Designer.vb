<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddConclusion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.ComboBoxResults = New System.Windows.Forms.ComboBox()
        Me.TbloutcomesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrganisDS = New FinalCabSec.OrganisDS()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxDocType = New System.Windows.Forms.ComboBox()
        Me.DocCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdAddSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxComment = New System.Windows.Forms.TextBox()
        Me.Labelresults = New System.Windows.Forms.Label()
        Me.TextBoxSubject = New System.Windows.Forms.TextBox()
        Me.Labelsubject = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelMinistry = New System.Windows.Forms.Label()
        Me.LabelYear = New System.Windows.Forms.Label()
        Me.TextBoxYear = New System.Windows.Forms.TextBox()
        Me.RecordIDTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxMinistry = New System.Windows.Forms.ComboBox()
        Me.ListMinistryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RecordIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinistryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YEARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SysIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MainTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CabCon = New FinalCabSec.CabCon()
        Me.ListMinistryTableAdapter = New FinalCabSec.OrganisDSTableAdapters.ListMinistryTableAdapter()
        Me.DocCategoryTableAdapter = New FinalCabSec.OrganisDSTableAdapters.docCategoryTableAdapter()
        Me.TbloutcomesTableAdapter = New FinalCabSec.OrganisDSTableAdapters.tbloutcomesTableAdapter()
        Me.MainTableTableAdapter = New FinalCabSec.CabConTableAdapters.MainTableTableAdapter()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TbloutcomesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrganisDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListMinistryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CabCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBoxDate)
        Me.GroupBox1.Controls.Add(Me.ComboBoxResults)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDocType)
        Me.GroupBox1.Controls.Add(Me.cmdAddSave)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxComment)
        Me.GroupBox1.Controls.Add(Me.Labelresults)
        Me.GroupBox1.Controls.Add(Me.TextBoxSubject)
        Me.GroupBox1.Controls.Add(Me.Labelsubject)
        Me.GroupBox1.Controls.Add(Me.LabelDate)
        Me.GroupBox1.Controls.Add(Me.LabelMinistry)
        Me.GroupBox1.Controls.Add(Me.LabelYear)
        Me.GroupBox1.Controls.Add(Me.TextBoxYear)
        Me.GroupBox1.Controls.Add(Me.RecordIDTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxMinistry)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1038, 258)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Box"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(826, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxDate
        '
        Me.TextBoxDate.Location = New System.Drawing.Point(7, 194)
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.Size = New System.Drawing.Size(196, 20)
        Me.TextBoxDate.TabIndex = 18
        '
        'ComboBoxResults
        '
        Me.ComboBoxResults.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxResults.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxResults.DataSource = Me.TbloutcomesBindingSource
        Me.ComboBoxResults.DisplayMember = "Decision"
        Me.ComboBoxResults.FormattingEnabled = True
        Me.ComboBoxResults.Location = New System.Drawing.Point(590, 35)
        Me.ComboBoxResults.Name = "ComboBoxResults"
        Me.ComboBoxResults.Size = New System.Drawing.Size(205, 21)
        Me.ComboBoxResults.TabIndex = 17
        Me.ComboBoxResults.ValueMember = "Decision"
        '
        'TbloutcomesBindingSource
        '
        Me.TbloutcomesBindingSource.DataMember = "tbloutcomes"
        Me.TbloutcomesBindingSource.DataSource = Me.OrganisDS
        '
        'OrganisDS
        '
        Me.OrganisDS.DataSetName = "OrganisDS"
        Me.OrganisDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Type of Document"
        '
        'ComboBoxDocType
        '
        Me.ComboBoxDocType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxDocType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxDocType.DataSource = Me.DocCategoryBindingSource
        Me.ComboBoxDocType.DisplayMember = "CatName"
        Me.ComboBoxDocType.FormattingEnabled = True
        Me.ComboBoxDocType.Location = New System.Drawing.Point(6, 134)
        Me.ComboBoxDocType.Name = "ComboBoxDocType"
        Me.ComboBoxDocType.Size = New System.Drawing.Size(197, 21)
        Me.ComboBoxDocType.TabIndex = 15
        Me.ComboBoxDocType.ValueMember = "CatName"
        '
        'DocCategoryBindingSource
        '
        Me.DocCategoryBindingSource.DataMember = "docCategory"
        Me.DocCategoryBindingSource.DataSource = Me.OrganisDS
        '
        'cmdAddSave
        '
        Me.cmdAddSave.Location = New System.Drawing.Point(826, 34)
        Me.cmdAddSave.Name = "cmdAddSave"
        Me.cmdAddSave.Size = New System.Drawing.Size(82, 132)
        Me.cmdAddSave.TabIndex = 14
        Me.cmdAddSave.Text = "Save"
        Me.cmdAddSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(584, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "comment"
        '
        'TextBoxComment
        '
        Me.TextBoxComment.Location = New System.Drawing.Point(587, 134)
        Me.TextBoxComment.Multiline = True
        Me.TextBoxComment.Name = "TextBoxComment"
        Me.TextBoxComment.Size = New System.Drawing.Size(221, 81)
        Me.TextBoxComment.TabIndex = 12
        '
        'Labelresults
        '
        Me.Labelresults.AutoSize = True
        Me.Labelresults.Location = New System.Drawing.Point(587, 7)
        Me.Labelresults.Name = "Labelresults"
        Me.Labelresults.Size = New System.Drawing.Size(37, 13)
        Me.Labelresults.TabIndex = 10
        Me.Labelresults.Text = "results"
        '
        'TextBoxSubject
        '
        Me.TextBoxSubject.Location = New System.Drawing.Point(233, 20)
        Me.TextBoxSubject.Multiline = True
        Me.TextBoxSubject.Name = "TextBoxSubject"
        Me.TextBoxSubject.Size = New System.Drawing.Size(315, 195)
        Me.TextBoxSubject.TabIndex = 9
        '
        'Labelsubject
        '
        Me.Labelsubject.AutoSize = True
        Me.Labelsubject.Location = New System.Drawing.Point(230, 4)
        Me.Labelsubject.Name = "Labelsubject"
        Me.Labelsubject.Size = New System.Drawing.Size(41, 13)
        Me.Labelsubject.TabIndex = 8
        Me.Labelsubject.Text = "subject"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(0, 171)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(30, 13)
        Me.LabelDate.TabIndex = 6
        Me.LabelDate.Text = "Date"
        '
        'LabelMinistry
        '
        Me.LabelMinistry.AutoSize = True
        Me.LabelMinistry.Location = New System.Drawing.Point(6, 75)
        Me.LabelMinistry.Name = "LabelMinistry"
        Me.LabelMinistry.Size = New System.Drawing.Size(42, 13)
        Me.LabelMinistry.TabIndex = 5
        Me.LabelMinistry.Text = "Ministry"
        '
        'LabelYear
        '
        Me.LabelYear.AutoSize = True
        Me.LabelYear.Location = New System.Drawing.Point(87, 20)
        Me.LabelYear.Name = "LabelYear"
        Me.LabelYear.Size = New System.Drawing.Size(29, 13)
        Me.LabelYear.TabIndex = 4
        Me.LabelYear.Text = "Year"
        '
        'TextBoxYear
        '
        Me.TextBoxYear.Location = New System.Drawing.Point(86, 35)
        Me.TextBoxYear.Name = "TextBoxYear"
        Me.TextBoxYear.Size = New System.Drawing.Size(53, 20)
        Me.TextBoxYear.TabIndex = 3
        '
        'RecordIDTxt
        '
        Me.RecordIDTxt.Location = New System.Drawing.Point(6, 36)
        Me.RecordIDTxt.Name = "RecordIDTxt"
        Me.RecordIDTxt.Size = New System.Drawing.Size(56, 20)
        Me.RecordIDTxt.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Record.ID"
        '
        'ComboBoxMinistry
        '
        Me.ComboBoxMinistry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxMinistry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxMinistry.DataSource = Me.ListMinistryBindingSource
        Me.ComboBoxMinistry.DisplayMember = "MinistryName"
        Me.ComboBoxMinistry.FormattingEnabled = True
        Me.ComboBoxMinistry.Location = New System.Drawing.Point(6, 91)
        Me.ComboBoxMinistry.Name = "ComboBoxMinistry"
        Me.ComboBoxMinistry.Size = New System.Drawing.Size(197, 21)
        Me.ComboBoxMinistry.TabIndex = 0
        Me.ComboBoxMinistry.ValueMember = "MinistryName"
        '
        'ListMinistryBindingSource
        '
        Me.ListMinistryBindingSource.DataMember = "ListMinistry"
        Me.ListMinistryBindingSource.DataSource = Me.OrganisDS
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordIDDataGridViewTextBoxColumn, Me.MinistryDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.ResultsDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn, Me.YEARDataGridViewTextBoxColumn, Me.SysIDDataGridViewTextBoxColumn, Me.DocCategoryDataGridViewTextBoxColumn, Me.Delete})
        Me.DataGridView1.DataSource = Me.MainTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(4, 238)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1037, 219)
        Me.DataGridView1.TabIndex = 1
        '
        'RecordIDDataGridViewTextBoxColumn
        '
        Me.RecordIDDataGridViewTextBoxColumn.DataPropertyName = "Record ID"
        Me.RecordIDDataGridViewTextBoxColumn.HeaderText = "Record ID"
        Me.RecordIDDataGridViewTextBoxColumn.Name = "RecordIDDataGridViewTextBoxColumn"
        '
        'MinistryDataGridViewTextBoxColumn
        '
        Me.MinistryDataGridViewTextBoxColumn.DataPropertyName = "Ministry"
        Me.MinistryDataGridViewTextBoxColumn.HeaderText = "Ministry"
        Me.MinistryDataGridViewTextBoxColumn.Name = "MinistryDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'ResultsDataGridViewTextBoxColumn
        '
        Me.ResultsDataGridViewTextBoxColumn.DataPropertyName = "results"
        Me.ResultsDataGridViewTextBoxColumn.HeaderText = "results"
        Me.ResultsDataGridViewTextBoxColumn.Name = "ResultsDataGridViewTextBoxColumn"
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        '
        'CommentsDataGridViewTextBoxColumn
        '
        Me.CommentsDataGridViewTextBoxColumn.DataPropertyName = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.HeaderText = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.Name = "CommentsDataGridViewTextBoxColumn"
        '
        'YEARDataGridViewTextBoxColumn
        '
        Me.YEARDataGridViewTextBoxColumn.DataPropertyName = "YEAR"
        Me.YEARDataGridViewTextBoxColumn.HeaderText = "YEAR"
        Me.YEARDataGridViewTextBoxColumn.Name = "YEARDataGridViewTextBoxColumn"
        '
        'SysIDDataGridViewTextBoxColumn
        '
        Me.SysIDDataGridViewTextBoxColumn.DataPropertyName = "SysID"
        Me.SysIDDataGridViewTextBoxColumn.HeaderText = "SysID"
        Me.SysIDDataGridViewTextBoxColumn.Name = "SysIDDataGridViewTextBoxColumn"
        Me.SysIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocCategoryDataGridViewTextBoxColumn
        '
        Me.DocCategoryDataGridViewTextBoxColumn.DataPropertyName = "DocCategory"
        Me.DocCategoryDataGridViewTextBoxColumn.HeaderText = "DocCategory"
        Me.DocCategoryDataGridViewTextBoxColumn.Name = "DocCategoryDataGridViewTextBoxColumn"
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        Me.Delete.Text = "Remove"
        '
        'MainTableBindingSource
        '
        Me.MainTableBindingSource.DataMember = "MainTable"
        Me.MainTableBindingSource.DataSource = Me.CabCon
        '
        'CabCon
        '
        Me.CabCon.DataSetName = "CabCon"
        Me.CabCon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListMinistryTableAdapter
        '
        Me.ListMinistryTableAdapter.ClearBeforeFill = True
        '
        'DocCategoryTableAdapter
        '
        Me.DocCategoryTableAdapter.ClearBeforeFill = True
        '
        'TbloutcomesTableAdapter
        '
        Me.TbloutcomesTableAdapter.ClearBeforeFill = True
        '
        'MainTableTableAdapter
        '
        Me.MainTableTableAdapter.ClearBeforeFill = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(13, 464)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 2
        '
        'AddConclusion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 549)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AddConclusion"
        Me.Text = "AddConclusion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TbloutcomesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrganisDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListMinistryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CabCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxMinistry As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RecordIDTxt As System.Windows.Forms.TextBox
    Friend WithEvents LabelMinistry As System.Windows.Forms.Label
    Friend WithEvents LabelYear As System.Windows.Forms.Label
    Friend WithEvents TextBoxYear As System.Windows.Forms.TextBox
    Friend WithEvents LabelDate As System.Windows.Forms.Label
    Friend WithEvents TextBoxSubject As System.Windows.Forms.TextBox
    Friend WithEvents Labelsubject As System.Windows.Forms.Label
    Friend WithEvents Labelresults As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxComment As System.Windows.Forms.TextBox
    Friend WithEvents cmdAddSave As System.Windows.Forms.Button
    Friend WithEvents ComboBoxDocType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OrganisDS As FinalCabSec.OrganisDS
    Friend WithEvents ListMinistryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListMinistryTableAdapter As FinalCabSec.OrganisDSTableAdapters.ListMinistryTableAdapter
    Friend WithEvents DocCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DocCategoryTableAdapter As FinalCabSec.OrganisDSTableAdapters.docCategoryTableAdapter
    Friend WithEvents ComboBoxResults As System.Windows.Forms.ComboBox
    Friend WithEvents TbloutcomesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbloutcomesTableAdapter As FinalCabSec.OrganisDSTableAdapters.tbloutcomesTableAdapter
    Friend WithEvents TextBoxDate As System.Windows.Forms.TextBox
    Friend WithEvents MainTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CabCon As FinalCabSec.CabCon
    Friend WithEvents MainTableTableAdapter As FinalCabSec.CabConTableAdapters.MainTableTableAdapter
    Friend WithEvents RecordIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MinistryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResultsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YEARDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SysIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocCategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
