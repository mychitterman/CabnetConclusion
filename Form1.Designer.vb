<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim SubjectLabel As System.Windows.Forms.Label
        Dim Record_IDLabel As System.Windows.Forms.Label
        Dim YEARLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Buttonlogoutclose = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdFilter = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.ComboBoxFilterMinistry = New System.Windows.Forms.ComboBox()
        Me.ListMinistryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrganisDS = New FinalCabSec.OrganisDS()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.CheckSubmission = New System.Windows.Forms.CheckBox()
        Me.KeyWordsBTN = New System.Windows.Forms.Button()
        Me.TextBoxKeyWords = New System.Windows.Forms.TextBox()
        Me.Welcome = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MainTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MainTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CabCon = New FinalCabSec.CabCon()
        Me.YEARLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Record_IDLabel1 = New System.Windows.Forms.Label()
        Me.SubjectLabel1 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.MainTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MainTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MainTableTableAdapter = New FinalCabSec.CabConTableAdapters.MainTableTableAdapter()
        Me.TableAdapterManager = New FinalCabSec.CabConTableAdapters.TableAdapterManager()
        Me.ListMinistryTableAdapter = New FinalCabSec.OrganisDSTableAdapters.ListMinistryTableAdapter()
        Me.cmdTrackConclusion = New System.Windows.Forms.Button()
        SubjectLabel = New System.Windows.Forms.Label()
        Record_IDLabel = New System.Windows.Forms.Label()
        YEARLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ListMinistryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrganisDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CabCon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainTableBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubjectLabel
        '
        SubjectLabel.AutoSize = True
        SubjectLabel.Location = New System.Drawing.Point(829, 3)
        SubjectLabel.Name = "SubjectLabel"
        SubjectLabel.Size = New System.Drawing.Size(44, 13)
        SubjectLabel.TabIndex = 0
        SubjectLabel.Text = "subject:"
        '
        'Record_IDLabel
        '
        Record_IDLabel.AutoSize = True
        Record_IDLabel.Location = New System.Drawing.Point(3, 66)
        Record_IDLabel.Name = "Record_IDLabel"
        Record_IDLabel.Size = New System.Drawing.Size(59, 13)
        Record_IDLabel.TabIndex = 4
        Record_IDLabel.Text = "Record ID:"
        '
        'YEARLabel
        '
        YEARLabel.AutoSize = True
        YEARLabel.Location = New System.Drawing.Point(115, 66)
        YEARLabel.Name = "YEARLabel"
        YEARLabel.Size = New System.Drawing.Size(39, 13)
        YEARLabel.TabIndex = 6
        YEARLabel.Text = "YEAR:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdTrackConclusion)
        Me.SplitContainer1.Panel1.Controls.Add(SubjectLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Buttonlogoutclose)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonAdd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckSubmission)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KeyWordsBTN)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxKeyWords)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Welcome)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MainTableDataGridView)
        Me.SplitContainer1.Panel1.Controls.Add(YEARLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.YEARLinkLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Record_IDLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Record_IDLabel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer1.Panel2.Controls.Add(Me.SubjectLabel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.WebBrowser1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1276, 494)
        Me.SplitContainer1.SplitterDistance = 872
        Me.SplitContainer1.TabIndex = 0
        '
        'Buttonlogoutclose
        '
        Me.Buttonlogoutclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonlogoutclose.ForeColor = System.Drawing.Color.Red
        Me.Buttonlogoutclose.Location = New System.Drawing.Point(683, 3)
        Me.Buttonlogoutclose.Name = "Buttonlogoutclose"
        Me.Buttonlogoutclose.Size = New System.Drawing.Size(114, 24)
        Me.Buttonlogoutclose.TabIndex = 4
        Me.Buttonlogoutclose.Text = "Log out, Close"
        Me.Buttonlogoutclose.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(501, 61)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdd.TabIndex = 15
        Me.ButtonAdd.Text = "Add new"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdFilter)
        Me.GroupBox1.Controls.Add(Me.cmdReset)
        Me.GroupBox1.Controls.Add(Me.ComboBoxFilterMinistry)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(794, 50)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filters"
        '
        'cmdFilter
        '
        Me.cmdFilter.Location = New System.Drawing.Point(573, 19)
        Me.cmdFilter.Name = "cmdFilter"
        Me.cmdFilter.Size = New System.Drawing.Size(75, 23)
        Me.cmdFilter.TabIndex = 16
        Me.cmdFilter.Text = "Filter"
        Me.cmdFilter.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(713, 19)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 15
        Me.cmdReset.Text = "Reset Filters"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'ComboBoxFilterMinistry
        '
        Me.ComboBoxFilterMinistry.DataSource = Me.ListMinistryBindingSource
        Me.ComboBoxFilterMinistry.DisplayMember = "MinistryName"
        Me.ComboBoxFilterMinistry.FormattingEnabled = True
        Me.ComboBoxFilterMinistry.Location = New System.Drawing.Point(237, 24)
        Me.ComboBoxFilterMinistry.Name = "ComboBoxFilterMinistry"
        Me.ComboBoxFilterMinistry.Size = New System.Drawing.Size(103, 21)
        Me.ComboBoxFilterMinistry.TabIndex = 14
        Me.ComboBoxFilterMinistry.ValueMember = "MinistryName"
        '
        'ListMinistryBindingSource
        '
        Me.ListMinistryBindingSource.DataMember = "ListMinistry"
        Me.ListMinistryBindingSource.DataSource = Me.OrganisDS
        '
        'OrganisDS
        '
        Me.OrganisDS.DataSetName = "OrganisDS"
        Me.OrganisDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(139, 25)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(79, 20)
        Me.TextBox2.TabIndex = 13
        '
        'CheckSubmission
        '
        Me.CheckSubmission.AutoSize = True
        Me.CheckSubmission.Location = New System.Drawing.Point(501, 10)
        Me.CheckSubmission.Name = "CheckSubmission"
        Me.CheckSubmission.Size = New System.Drawing.Size(164, 17)
        Me.CheckSubmission.TabIndex = 12
        Me.CheckSubmission.Text = "Show Conclusion Submission"
        Me.CheckSubmission.UseVisualStyleBackColor = True
        '
        'KeyWordsBTN
        '
        Me.KeyWordsBTN.Location = New System.Drawing.Point(142, 60)
        Me.KeyWordsBTN.Name = "KeyWordsBTN"
        Me.KeyWordsBTN.Size = New System.Drawing.Size(118, 19)
        Me.KeyWordsBTN.TabIndex = 11
        Me.KeyWordsBTN.Text = "Search Key Words"
        Me.KeyWordsBTN.UseVisualStyleBackColor = True
        '
        'TextBoxKeyWords
        '
        Me.TextBoxKeyWords.Location = New System.Drawing.Point(3, 59)
        Me.TextBoxKeyWords.Multiline = True
        Me.TextBoxKeyWords.Name = "TextBoxKeyWords"
        Me.TextBoxKeyWords.Size = New System.Drawing.Size(139, 20)
        Me.TextBoxKeyWords.TabIndex = 10
        '
        'Welcome
        '
        Me.Welcome.AutoSize = True
        Me.Welcome.Location = New System.Drawing.Point(282, 0)
        Me.Welcome.Name = "Welcome"
        Me.Welcome.Size = New System.Drawing.Size(52, 13)
        Me.Welcome.TabIndex = 9
        Me.Welcome.Text = "Welcome"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(683, 33)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Email to someone"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MainTableDataGridView
        '
        Me.MainTableDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainTableDataGridView.AutoGenerateColumns = False
        Me.MainTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MainTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DocCategory, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn8})
        Me.MainTableDataGridView.DataSource = Me.MainTableBindingSource
        Me.MainTableDataGridView.Location = New System.Drawing.Point(0, 162)
        Me.MainTableDataGridView.Name = "MainTableDataGridView"
        Me.MainTableDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MainTableDataGridView.Size = New System.Drawing.Size(1169, 243)
        Me.MainTableDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Record ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Record ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "YEAR"
        Me.DataGridViewTextBoxColumn7.HeaderText = "YEAR"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ministry"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ministry"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "subject"
        Me.DataGridViewTextBoxColumn5.HeaderText = "subject"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DocCategory
        '
        Me.DocCategory.DataPropertyName = "DocCategory"
        Me.DocCategory.HeaderText = "DocCategory"
        Me.DocCategory.Name = "DocCategory"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "results"
        Me.DataGridViewTextBoxColumn4.HeaderText = "results"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Comments"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Comments"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SysID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "SysID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
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
        'YEARLinkLabel
        '
        Me.YEARLinkLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainTableBindingSource, "YEAR", True))
        Me.YEARLinkLabel.Location = New System.Drawing.Point(160, 66)
        Me.YEARLinkLabel.Name = "YEARLinkLabel"
        Me.YEARLinkLabel.Size = New System.Drawing.Size(100, 23)
        Me.YEARLinkLabel.TabIndex = 7
        Me.YEARLinkLabel.TabStop = True
        Me.YEARLinkLabel.Text = "LinkLabel1"
        '
        'Record_IDLabel1
        '
        Me.Record_IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainTableBindingSource, "Record ID", True))
        Me.Record_IDLabel1.Location = New System.Drawing.Point(68, 66)
        Me.Record_IDLabel1.Name = "Record_IDLabel1"
        Me.Record_IDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Record_IDLabel1.TabIndex = 5
        Me.Record_IDLabel1.Text = "Label1"
        '
        'SubjectLabel1
        '
        Me.SubjectLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubjectLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SubjectLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainTableBindingSource, "subject", True))
        Me.SubjectLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.SubjectLabel1.Location = New System.Drawing.Point(3, 3)
        Me.SubjectLabel1.Name = "SubjectLabel1"
        Me.SubjectLabel1.Size = New System.Drawing.Size(381, 86)
        Me.SubjectLabel1.TabIndex = 1
        Me.SubjectLabel1.Text = "Label1"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(396, 490)
        Me.WebBrowser1.TabIndex = 0
        '
        'MainTableBindingNavigator
        '
        Me.MainTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MainTableBindingNavigator.BindingSource = Me.MainTableBindingSource
        Me.MainTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MainTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MainTableBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.MainTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MainTableBindingNavigatorSaveItem})
        Me.MainTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MainTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MainTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MainTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MainTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MainTableBindingNavigator.Name = "MainTableBindingNavigator"
        Me.MainTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MainTableBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.MainTableBindingNavigator.TabIndex = 1
        Me.MainTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MainTableBindingNavigatorSaveItem
        '
        Me.MainTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MainTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("MainTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MainTableBindingNavigatorSaveItem.Name = "MainTableBindingNavigatorSaveItem"
        Me.MainTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MainTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MainTableTableAdapter
        '
        Me.MainTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MainTableTableAdapter = Me.MainTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalCabSec.CabConTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ListMinistryTableAdapter
        '
        Me.ListMinistryTableAdapter.ClearBeforeFill = True
        '
        'cmdTrackConclusion
        '
        Me.cmdTrackConclusion.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.cmdTrackConclusion.FlatAppearance.BorderSize = 2
        Me.cmdTrackConclusion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.cmdTrackConclusion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdTrackConclusion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdTrackConclusion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdTrackConclusion.Location = New System.Drawing.Point(673, 66)
        Me.cmdTrackConclusion.Name = "cmdTrackConclusion"
        Me.cmdTrackConclusion.Size = New System.Drawing.Size(124, 34)
        Me.cmdTrackConclusion.TabIndex = 16
        Me.cmdTrackConclusion.Text = "Track this conclusion"
        Me.cmdTrackConclusion.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 494)
        Me.Controls.Add(Me.MainTableBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ListMinistryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrganisDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CabCon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainTableBindingNavigator.ResumeLayout(False)
        Me.MainTableBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents CabCon As FinalCabSec.CabCon
    Friend WithEvents MainTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MainTableTableAdapter As FinalCabSec.CabConTableAdapters.MainTableTableAdapter
    Friend WithEvents TableAdapterManager As FinalCabSec.CabConTableAdapters.TableAdapterManager
    Friend WithEvents MainTableBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MainTableBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MainTableDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SubjectLabel1 As System.Windows.Forms.Label
    Friend WithEvents Buttonlogoutclose As System.Windows.Forms.Button
    Friend WithEvents YEARLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Record_IDLabel1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Welcome As System.Windows.Forms.Label
    Friend WithEvents KeyWordsBTN As System.Windows.Forms.Button
    Friend WithEvents TextBoxKeyWords As System.Windows.Forms.TextBox
    Friend WithEvents CheckSubmission As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxFilterMinistry As System.Windows.Forms.ComboBox
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents OrganisDS As FinalCabSec.OrganisDS
    Friend WithEvents ListMinistryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListMinistryTableAdapter As FinalCabSec.OrganisDSTableAdapters.ListMinistryTableAdapter
    Friend WithEvents cmdFilter As System.Windows.Forms.Button
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocCategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdTrackConclusion As System.Windows.Forms.Button

End Class
