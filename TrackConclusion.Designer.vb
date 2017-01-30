<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrackConclusion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrackConclusion))
        Dim SysIDLabel As System.Windows.Forms.Label
        Dim MainTableRecordIDLabel As System.Windows.Forms.Label
        Dim RecordIDLabel As System.Windows.Forms.Label
        Dim YearLabel As System.Windows.Forms.Label
        Dim StatusCommentLabel As System.Windows.Forms.Label
        Dim SubjectiveImpStatusValueLabel As System.Windows.Forms.Label
        Dim ReportTimeLabel As System.Windows.Forms.Label
        Dim FrameworkIssuePrimary1Label As System.Windows.Forms.Label
        Dim FrameworkIssuePrimary2Label As System.Windows.Forms.Label
        Dim FrameworkIssueSecondaryLabel As System.Windows.Forms.Label
        Dim AdviceActionProvidedLabel As System.Windows.Forms.Label
        Dim DateRecordedLabel As System.Windows.Forms.Label
        Dim SubjectLabel As System.Windows.Forms.Label
        Me.TblPolicyMonitoringBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TblPolicyMonitoringBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrackDS = New FinalCabSec.TrackDS()
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
        Me.TblPolicyMonitoringBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblPolicyMonitoringTableAdapter = New FinalCabSec.TrackDSTableAdapters.tblPolicyMonitoringTableAdapter()
        Me.TableAdapterManager = New FinalCabSec.TrackDSTableAdapters.TableAdapterManager()
        Me.SysIDLabel1 = New System.Windows.Forms.Label()
        Me.MainTableRecordIDLabel1 = New System.Windows.Forms.Label()
        Me.RecordIDLabel1 = New System.Windows.Forms.Label()
        Me.YearLabel1 = New System.Windows.Forms.Label()
        Me.StatusCommentTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectiveImpStatusValueTextBox = New System.Windows.Forms.TextBox()
        Me.ReportTimeComboBox = New System.Windows.Forms.ComboBox()
        Me.FrameworkIssuePrimary1ComboBox = New System.Windows.Forms.ComboBox()
        Me.FrameworkIssuePrimary2ComboBox = New System.Windows.Forms.ComboBox()
        Me.FrameworkIssueSecondaryComboBox = New System.Windows.Forms.ComboBox()
        Me.AdviceActionProvidedTextBox = New System.Windows.Forms.TextBox()
        Me.DateRecordedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CabCon = New FinalCabSec.CabCon()
        Me.MainTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainTableTableAdapter = New FinalCabSec.CabConTableAdapters.MainTableTableAdapter()
        Me.TableAdapterManager1 = New FinalCabSec.CabConTableAdapters.TableAdapterManager()
        Me.SubjectLabel1 = New System.Windows.Forms.Label()
        Me.FillBy2ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.UserInputValueToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.UserInputValueToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy2ToolStripButton = New System.Windows.Forms.ToolStripButton()
        SysIDLabel = New System.Windows.Forms.Label()
        MainTableRecordIDLabel = New System.Windows.Forms.Label()
        RecordIDLabel = New System.Windows.Forms.Label()
        YearLabel = New System.Windows.Forms.Label()
        StatusCommentLabel = New System.Windows.Forms.Label()
        SubjectiveImpStatusValueLabel = New System.Windows.Forms.Label()
        ReportTimeLabel = New System.Windows.Forms.Label()
        FrameworkIssuePrimary1Label = New System.Windows.Forms.Label()
        FrameworkIssuePrimary2Label = New System.Windows.Forms.Label()
        FrameworkIssueSecondaryLabel = New System.Windows.Forms.Label()
        AdviceActionProvidedLabel = New System.Windows.Forms.Label()
        DateRecordedLabel = New System.Windows.Forms.Label()
        SubjectLabel = New System.Windows.Forms.Label()
        CType(Me.TblPolicyMonitoringBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblPolicyMonitoringBindingNavigator.SuspendLayout()
        CType(Me.TblPolicyMonitoringBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CabCon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy2ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TblPolicyMonitoringBindingNavigator
        '
        Me.TblPolicyMonitoringBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblPolicyMonitoringBindingNavigator.BindingSource = Me.TblPolicyMonitoringBindingSource
        Me.TblPolicyMonitoringBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblPolicyMonitoringBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblPolicyMonitoringBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblPolicyMonitoringBindingNavigatorSaveItem})
        Me.TblPolicyMonitoringBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblPolicyMonitoringBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblPolicyMonitoringBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblPolicyMonitoringBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblPolicyMonitoringBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblPolicyMonitoringBindingNavigator.Name = "TblPolicyMonitoringBindingNavigator"
        Me.TblPolicyMonitoringBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblPolicyMonitoringBindingNavigator.Size = New System.Drawing.Size(928, 25)
        Me.TblPolicyMonitoringBindingNavigator.TabIndex = 0
        Me.TblPolicyMonitoringBindingNavigator.Text = "BindingNavigator1"
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
        'TblPolicyMonitoringBindingSource
        '
        Me.TblPolicyMonitoringBindingSource.DataMember = "tblPolicyMonitoring"
        Me.TblPolicyMonitoringBindingSource.DataSource = Me.TrackDS
        '
        'TrackDS
        '
        Me.TrackDS.DataSetName = "TrackDS"
        Me.TrackDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TblPolicyMonitoringBindingNavigatorSaveItem
        '
        Me.TblPolicyMonitoringBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblPolicyMonitoringBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblPolicyMonitoringBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblPolicyMonitoringBindingNavigatorSaveItem.Name = "TblPolicyMonitoringBindingNavigatorSaveItem"
        Me.TblPolicyMonitoringBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblPolicyMonitoringBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblPolicyMonitoringTableAdapter
        '
        Me.TblPolicyMonitoringTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblPolicyMonitoringTableAdapter = Me.TblPolicyMonitoringTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalCabSec.TrackDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SysIDLabel
        '
        SysIDLabel.AutoSize = True
        SysIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SysIDLabel.Location = New System.Drawing.Point(10, 43)
        SysIDLabel.Name = "SysIDLabel"
        SysIDLabel.Size = New System.Drawing.Size(60, 20)
        SysIDLabel.TabIndex = 1
        SysIDLabel.Text = "Sys ID:"
        '
        'SysIDLabel1
        '
        Me.SysIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPolicyMonitoringBindingSource, "SysID", True))
        Me.SysIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SysIDLabel1.Location = New System.Drawing.Point(76, 40)
        Me.SysIDLabel1.Name = "SysIDLabel1"
        Me.SysIDLabel1.Size = New System.Drawing.Size(69, 23)
        Me.SysIDLabel1.TabIndex = 2
        Me.SysIDLabel1.Text = "Label1"
        '
        'MainTableRecordIDLabel
        '
        MainTableRecordIDLabel.AutoSize = True
        MainTableRecordIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MainTableRecordIDLabel.Location = New System.Drawing.Point(150, 40)
        MainTableRecordIDLabel.Name = "MainTableRecordIDLabel"
        MainTableRecordIDLabel.Size = New System.Drawing.Size(167, 20)
        MainTableRecordIDLabel.TabIndex = 3
        MainTableRecordIDLabel.Text = "Main Table Record ID:"
        '
        'MainTableRecordIDLabel1
        '
        Me.MainTableRecordIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPolicyMonitoringBindingSource, "MainTableRecordID", True))
        Me.MainTableRecordIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainTableRecordIDLabel1.Location = New System.Drawing.Point(332, 40)
        Me.MainTableRecordIDLabel1.Name = "MainTableRecordIDLabel1"
        Me.MainTableRecordIDLabel1.Size = New System.Drawing.Size(79, 23)
        Me.MainTableRecordIDLabel1.TabIndex = 4
        Me.MainTableRecordIDLabel1.Text = "Label1"
        '
        'RecordIDLabel
        '
        RecordIDLabel.AutoSize = True
        RecordIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecordIDLabel.Location = New System.Drawing.Point(435, 40)
        RecordIDLabel.Name = "RecordIDLabel"
        RecordIDLabel.Size = New System.Drawing.Size(86, 20)
        RecordIDLabel.TabIndex = 5
        RecordIDLabel.Text = "Record ID:"
        '
        'RecordIDLabel1
        '
        Me.RecordIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPolicyMonitoringBindingSource, "RecordID", True))
        Me.RecordIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordIDLabel1.Location = New System.Drawing.Point(527, 37)
        Me.RecordIDLabel1.Name = "RecordIDLabel1"
        Me.RecordIDLabel1.Size = New System.Drawing.Size(84, 23)
        Me.RecordIDLabel1.TabIndex = 6
        Me.RecordIDLabel1.Text = "Label1"
        '
        'YearLabel
        '
        YearLabel.AutoSize = True
        YearLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        YearLabel.Location = New System.Drawing.Point(617, 37)
        YearLabel.Name = "YearLabel"
        YearLabel.Size = New System.Drawing.Size(47, 20)
        YearLabel.TabIndex = 7
        YearLabel.Text = "Year:"
        '
        'YearLabel1
        '
        Me.YearLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPolicyMonitoringBindingSource, "Year", True))
        Me.YearLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearLabel1.Location = New System.Drawing.Point(687, 37)
        Me.YearLabel1.Name = "YearLabel1"
        Me.YearLabel1.Size = New System.Drawing.Size(83, 23)
        Me.YearLabel1.TabIndex = 8
        Me.YearLabel1.Text = "Label1"
        '
        'StatusCommentLabel
        '
        StatusCommentLabel.AutoSize = True
        StatusCommentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusCommentLabel.Location = New System.Drawing.Point(12, 254)
        StatusCommentLabel.Name = "StatusCommentLabel"
        StatusCommentLabel.Size = New System.Drawing.Size(133, 20)
        StatusCommentLabel.TabIndex = 9
        StatusCommentLabel.Text = "Status Comment:"
        '
        'StatusCommentTextBox
        '
        Me.StatusCommentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPolicyMonitoringBindingSource, "StatusComment", True))
        Me.StatusCommentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusCommentTextBox.Location = New System.Drawing.Point(231, 248)
        Me.StatusCommentTextBox.Name = "StatusCommentTextBox"
        Me.StatusCommentTextBox.Size = New System.Drawing.Size(200, 26)
        Me.StatusCommentTextBox.TabIndex = 10
        '
        'SubjectiveImpStatusValueLabel
        '
        SubjectiveImpStatusValueLabel.AutoSize = True
        SubjectiveImpStatusValueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SubjectiveImpStatusValueLabel.Location = New System.Drawing.Point(12, 291)
        SubjectiveImpStatusValueLabel.Name = "SubjectiveImpStatusValueLabel"
        SubjectiveImpStatusValueLabel.Size = New System.Drawing.Size(213, 20)
        SubjectiveImpStatusValueLabel.TabIndex = 11
        SubjectiveImpStatusValueLabel.Text = "Subjective Imp Status Value:"
        '
        'SubjectiveImpStatusValueTextBox
        '
        Me.SubjectiveImpStatusValueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPolicyMonitoringBindingSource, "SubjectiveImpStatusValue", True))
        Me.SubjectiveImpStatusValueTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectiveImpStatusValueTextBox.Location = New System.Drawing.Point(231, 291)
        Me.SubjectiveImpStatusValueTextBox.Name = "SubjectiveImpStatusValueTextBox"
        Me.SubjectiveImpStatusValueTextBox.Size = New System.Drawing.Size(200, 26)
        Me.SubjectiveImpStatusValueTextBox.TabIndex = 12
        '
        'ReportTimeLabel
        '
        ReportTimeLabel.AutoSize = True
        ReportTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReportTimeLabel.Location = New System.Drawing.Point(12, 344)
        ReportTimeLabel.Name = "ReportTimeLabel"
        ReportTimeLabel.Size = New System.Drawing.Size(100, 20)
        ReportTimeLabel.TabIndex = 13
        ReportTimeLabel.Text = "Report Time:"
        '
        'ReportTimeComboBox
        '
        Me.ReportTimeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPolicyMonitoringBindingSource, "ReportTime", True))
        Me.ReportTimeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportTimeComboBox.FormattingEnabled = True
        Me.ReportTimeComboBox.Location = New System.Drawing.Point(229, 344)
        Me.ReportTimeComboBox.Name = "ReportTimeComboBox"
        Me.ReportTimeComboBox.Size = New System.Drawing.Size(200, 28)
        Me.ReportTimeComboBox.TabIndex = 14
        '
        'FrameworkIssuePrimary1Label
        '
        FrameworkIssuePrimary1Label.AutoSize = True
        FrameworkIssuePrimary1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FrameworkIssuePrimary1Label.Location = New System.Drawing.Point(10, 412)
        FrameworkIssuePrimary1Label.Name = "FrameworkIssuePrimary1Label"
        FrameworkIssuePrimary1Label.Size = New System.Drawing.Size(200, 20)
        FrameworkIssuePrimary1Label.TabIndex = 15
        FrameworkIssuePrimary1Label.Text = "Framework Issue Primary1:"
        '
        'FrameworkIssuePrimary1ComboBox
        '
        Me.FrameworkIssuePrimary1ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPolicyMonitoringBindingSource, "FrameworkIssuePrimary1", True))
        Me.FrameworkIssuePrimary1ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameworkIssuePrimary1ComboBox.FormattingEnabled = True
        Me.FrameworkIssuePrimary1ComboBox.Location = New System.Drawing.Point(229, 409)
        Me.FrameworkIssuePrimary1ComboBox.Name = "FrameworkIssuePrimary1ComboBox"
        Me.FrameworkIssuePrimary1ComboBox.Size = New System.Drawing.Size(200, 28)
        Me.FrameworkIssuePrimary1ComboBox.TabIndex = 16
        '
        'FrameworkIssuePrimary2Label
        '
        FrameworkIssuePrimary2Label.AutoSize = True
        FrameworkIssuePrimary2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FrameworkIssuePrimary2Label.Location = New System.Drawing.Point(12, 457)
        FrameworkIssuePrimary2Label.Name = "FrameworkIssuePrimary2Label"
        FrameworkIssuePrimary2Label.Size = New System.Drawing.Size(200, 20)
        FrameworkIssuePrimary2Label.TabIndex = 17
        FrameworkIssuePrimary2Label.Text = "Framework Issue Primary2:"
        '
        'FrameworkIssuePrimary2ComboBox
        '
        Me.FrameworkIssuePrimary2ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPolicyMonitoringBindingSource, "FrameworkIssuePrimary2", True))
        Me.FrameworkIssuePrimary2ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameworkIssuePrimary2ComboBox.FormattingEnabled = True
        Me.FrameworkIssuePrimary2ComboBox.Location = New System.Drawing.Point(229, 457)
        Me.FrameworkIssuePrimary2ComboBox.Name = "FrameworkIssuePrimary2ComboBox"
        Me.FrameworkIssuePrimary2ComboBox.Size = New System.Drawing.Size(200, 28)
        Me.FrameworkIssuePrimary2ComboBox.TabIndex = 18
        '
        'FrameworkIssueSecondaryLabel
        '
        FrameworkIssueSecondaryLabel.AutoSize = True
        FrameworkIssueSecondaryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FrameworkIssueSecondaryLabel.Location = New System.Drawing.Point(8, 505)
        FrameworkIssueSecondaryLabel.Name = "FrameworkIssueSecondaryLabel"
        FrameworkIssueSecondaryLabel.Size = New System.Drawing.Size(215, 20)
        FrameworkIssueSecondaryLabel.TabIndex = 19
        FrameworkIssueSecondaryLabel.Text = "Framework Issue Secondary:"
        '
        'FrameworkIssueSecondaryComboBox
        '
        Me.FrameworkIssueSecondaryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPolicyMonitoringBindingSource, "FrameworkIssueSecondary", True))
        Me.FrameworkIssueSecondaryComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameworkIssueSecondaryComboBox.FormattingEnabled = True
        Me.FrameworkIssueSecondaryComboBox.Location = New System.Drawing.Point(229, 502)
        Me.FrameworkIssueSecondaryComboBox.Name = "FrameworkIssueSecondaryComboBox"
        Me.FrameworkIssueSecondaryComboBox.Size = New System.Drawing.Size(200, 28)
        Me.FrameworkIssueSecondaryComboBox.TabIndex = 20
        '
        'AdviceActionProvidedLabel
        '
        AdviceActionProvidedLabel.AutoSize = True
        AdviceActionProvidedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AdviceActionProvidedLabel.Location = New System.Drawing.Point(12, 558)
        AdviceActionProvidedLabel.Name = "AdviceActionProvidedLabel"
        AdviceActionProvidedLabel.Size = New System.Drawing.Size(174, 20)
        AdviceActionProvidedLabel.TabIndex = 21
        AdviceActionProvidedLabel.Text = "Advice Action Provided:"
        '
        'AdviceActionProvidedTextBox
        '
        Me.AdviceActionProvidedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPolicyMonitoringBindingSource, "AdviceActionProvided", True))
        Me.AdviceActionProvidedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdviceActionProvidedTextBox.Location = New System.Drawing.Point(229, 555)
        Me.AdviceActionProvidedTextBox.Name = "AdviceActionProvidedTextBox"
        Me.AdviceActionProvidedTextBox.Size = New System.Drawing.Size(200, 26)
        Me.AdviceActionProvidedTextBox.TabIndex = 22
        '
        'DateRecordedLabel
        '
        DateRecordedLabel.AutoSize = True
        DateRecordedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateRecordedLabel.Location = New System.Drawing.Point(12, 618)
        DateRecordedLabel.Name = "DateRecordedLabel"
        DateRecordedLabel.Size = New System.Drawing.Size(122, 20)
        DateRecordedLabel.TabIndex = 23
        DateRecordedLabel.Text = "Date Recorded:"
        '
        'DateRecordedDateTimePicker
        '
        Me.DateRecordedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblPolicyMonitoringBindingSource, "DateRecorded", True))
        Me.DateRecordedDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateRecordedDateTimePicker.Location = New System.Drawing.Point(229, 612)
        Me.DateRecordedDateTimePicker.Name = "DateRecordedDateTimePicker"
        Me.DateRecordedDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.DateRecordedDateTimePicker.TabIndex = 24
        '
        'CabCon
        '
        Me.CabCon.DataSetName = "CabCon"
        Me.CabCon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MainTableBindingSource
        '
        Me.MainTableBindingSource.DataMember = "MainTable"
        Me.MainTableBindingSource.DataSource = Me.CabCon
        '
        'MainTableTableAdapter
        '
        Me.MainTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.MainTableTableAdapter = Me.MainTableTableAdapter
        Me.TableAdapterManager1.UpdateOrder = FinalCabSec.CabConTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SubjectLabel
        '
        SubjectLabel.AutoSize = True
        SubjectLabel.Location = New System.Drawing.Point(60, 121)
        SubjectLabel.Name = "SubjectLabel"
        SubjectLabel.Size = New System.Drawing.Size(44, 13)
        SubjectLabel.TabIndex = 26
        SubjectLabel.Text = "subject:"
        '
        'SubjectLabel1
        '
        Me.SubjectLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainTableBindingSource, "subject", True))
        Me.SubjectLabel1.Location = New System.Drawing.Point(110, 121)
        Me.SubjectLabel1.Name = "SubjectLabel1"
        Me.SubjectLabel1.Size = New System.Drawing.Size(521, 23)
        Me.SubjectLabel1.TabIndex = 27
        Me.SubjectLabel1.Text = "Label1"
        '
        'FillBy2ToolStrip
        '
        Me.FillBy2ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserInputValueToolStripLabel, Me.UserInputValueToolStripTextBox, Me.FillBy2ToolStripButton})
        Me.FillBy2ToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillBy2ToolStrip.Name = "FillBy2ToolStrip"
        Me.FillBy2ToolStrip.Size = New System.Drawing.Size(928, 25)
        Me.FillBy2ToolStrip.TabIndex = 28
        Me.FillBy2ToolStrip.Text = "FillBy2ToolStrip"
        '
        'UserInputValueToolStripLabel
        '
        Me.UserInputValueToolStripLabel.Name = "UserInputValueToolStripLabel"
        Me.UserInputValueToolStripLabel.Size = New System.Drawing.Size(89, 15)
        Me.UserInputValueToolStripLabel.Text = "UserInputValue:"
        '
        'UserInputValueToolStripTextBox
        '
        Me.UserInputValueToolStripTextBox.Name = "UserInputValueToolStripTextBox"
        Me.UserInputValueToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'FillBy2ToolStripButton
        '
        Me.FillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy2ToolStripButton.Name = "FillBy2ToolStripButton"
        Me.FillBy2ToolStripButton.Size = New System.Drawing.Size(45, 19)
        Me.FillBy2ToolStripButton.Text = "FillBy2"
        '
        'TrackConclusion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 712)
        Me.Controls.Add(Me.FillBy2ToolStrip)
        Me.Controls.Add(SubjectLabel)
        Me.Controls.Add(Me.SubjectLabel1)
        Me.Controls.Add(SysIDLabel)
        Me.Controls.Add(Me.SysIDLabel1)
        Me.Controls.Add(MainTableRecordIDLabel)
        Me.Controls.Add(Me.MainTableRecordIDLabel1)
        Me.Controls.Add(RecordIDLabel)
        Me.Controls.Add(Me.RecordIDLabel1)
        Me.Controls.Add(YearLabel)
        Me.Controls.Add(Me.YearLabel1)
        Me.Controls.Add(StatusCommentLabel)
        Me.Controls.Add(Me.StatusCommentTextBox)
        Me.Controls.Add(SubjectiveImpStatusValueLabel)
        Me.Controls.Add(Me.SubjectiveImpStatusValueTextBox)
        Me.Controls.Add(ReportTimeLabel)
        Me.Controls.Add(Me.ReportTimeComboBox)
        Me.Controls.Add(FrameworkIssuePrimary1Label)
        Me.Controls.Add(Me.FrameworkIssuePrimary1ComboBox)
        Me.Controls.Add(FrameworkIssuePrimary2Label)
        Me.Controls.Add(Me.FrameworkIssuePrimary2ComboBox)
        Me.Controls.Add(FrameworkIssueSecondaryLabel)
        Me.Controls.Add(Me.FrameworkIssueSecondaryComboBox)
        Me.Controls.Add(AdviceActionProvidedLabel)
        Me.Controls.Add(Me.AdviceActionProvidedTextBox)
        Me.Controls.Add(DateRecordedLabel)
        Me.Controls.Add(Me.DateRecordedDateTimePicker)
        Me.Controls.Add(Me.TblPolicyMonitoringBindingNavigator)
        Me.Name = "TrackConclusion"
        Me.Text = "TrackConclusion"
        CType(Me.TblPolicyMonitoringBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblPolicyMonitoringBindingNavigator.ResumeLayout(False)
        Me.TblPolicyMonitoringBindingNavigator.PerformLayout()
        CType(Me.TblPolicyMonitoringBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CabCon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy2ToolStrip.ResumeLayout(False)
        Me.FillBy2ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrackDS As FinalCabSec.TrackDS
    Friend WithEvents TblPolicyMonitoringBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPolicyMonitoringTableAdapter As FinalCabSec.TrackDSTableAdapters.tblPolicyMonitoringTableAdapter
    Friend WithEvents TableAdapterManager As FinalCabSec.TrackDSTableAdapters.TableAdapterManager
    Friend WithEvents TblPolicyMonitoringBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblPolicyMonitoringBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SysIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents MainTableRecordIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents RecordIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents YearLabel1 As System.Windows.Forms.Label
    Friend WithEvents StatusCommentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubjectiveImpStatusValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReportTimeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FrameworkIssuePrimary1ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FrameworkIssuePrimary2ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FrameworkIssueSecondaryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AdviceActionProvidedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateRecordedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CabCon As FinalCabSec.CabCon
    Friend WithEvents MainTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MainTableTableAdapter As FinalCabSec.CabConTableAdapters.MainTableTableAdapter
    Friend WithEvents TableAdapterManager1 As FinalCabSec.CabConTableAdapters.TableAdapterManager
    Friend WithEvents SubjectLabel1 As System.Windows.Forms.Label
    Friend WithEvents FillBy2ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents UserInputValueToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents UserInputValueToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillBy2ToolStripButton As System.Windows.Forms.ToolStripButton
End Class
