<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDevice
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
        Dim RecordIDLabel As System.Windows.Forms.Label
        Dim ComputerLocationLabel As System.Windows.Forms.Label
        Dim MACIDLabel As System.Windows.Forms.Label
        Dim AuthorizedLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddDevice))
        Dim RecordIDLabel1 As System.Windows.Forms.Label
        Me.DeviceAccessDS = New FinalCabSec.DeviceAccessDS()
        Me.TblDevices1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDevices1TableAdapter = New FinalCabSec.DeviceAccessDSTableAdapters.tblDevices1TableAdapter()
        Me.TableAdapterManager = New FinalCabSec.DeviceAccessDSTableAdapters.TableAdapterManager()
        Me.TblDevices1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblDevices1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComputerLocationTextBox = New System.Windows.Forms.TextBox()
        Me.MACIDTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorizedTextBox = New System.Windows.Forms.TextBox()
        Me.save = New System.Windows.Forms.Button()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.TblDevices1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RecordIDLabel2 = New System.Windows.Forms.Label()
        RecordIDLabel = New System.Windows.Forms.Label()
        ComputerLocationLabel = New System.Windows.Forms.Label()
        MACIDLabel = New System.Windows.Forms.Label()
        AuthorizedLabel = New System.Windows.Forms.Label()
        RecordIDLabel1 = New System.Windows.Forms.Label()
        CType(Me.DeviceAccessDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDevices1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDevices1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblDevices1BindingNavigator.SuspendLayout()
        CType(Me.TblDevices1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeviceAccessDS
        '
        Me.DeviceAccessDS.DataSetName = "DeviceAccessDS"
        Me.DeviceAccessDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblDevices1BindingSource
        '
        Me.TblDevices1BindingSource.DataMember = "tblDevices1"
        Me.TblDevices1BindingSource.DataSource = Me.DeviceAccessDS
        '
        'TblDevices1TableAdapter
        '
        Me.TblDevices1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblDevices1TableAdapter = Me.TblDevices1TableAdapter
        Me.TableAdapterManager.tblDevicesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FinalCabSec.DeviceAccessDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblDevices1BindingNavigator
        '
        Me.TblDevices1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblDevices1BindingNavigator.BindingSource = Me.TblDevices1BindingSource
        Me.TblDevices1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblDevices1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblDevices1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblDevices1BindingNavigatorSaveItem})
        Me.TblDevices1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblDevices1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblDevices1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblDevices1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblDevices1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblDevices1BindingNavigator.Name = "TblDevices1BindingNavigator"
        Me.TblDevices1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblDevices1BindingNavigator.Size = New System.Drawing.Size(871, 25)
        Me.TblDevices1BindingNavigator.TabIndex = 0
        Me.TblDevices1BindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblDevices1DataGridView
        '
        Me.TblDevices1DataGridView.AutoGenerateColumns = False
        Me.TblDevices1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblDevices1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblDevices1DataGridView.DataSource = Me.TblDevices1BindingSource
        Me.TblDevices1DataGridView.Location = New System.Drawing.Point(12, 44)
        Me.TblDevices1DataGridView.Name = "TblDevices1DataGridView"
        Me.TblDevices1DataGridView.ReadOnly = True
        Me.TblDevices1DataGridView.Size = New System.Drawing.Size(445, 258)
        Me.TblDevices1DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RecordID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RecordID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ComputerLocation"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ComputerLocation"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MACID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MACID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Authorized"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Authorized"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'RecordIDLabel
        '
        RecordIDLabel.AutoSize = True
        RecordIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecordIDLabel.Location = New System.Drawing.Point(558, 67)
        RecordIDLabel.Name = "RecordIDLabel"
        RecordIDLabel.Size = New System.Drawing.Size(0, 18)
        RecordIDLabel.TabIndex = 2
        '
        'ComputerLocationLabel
        '
        ComputerLocationLabel.AutoSize = True
        ComputerLocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComputerLocationLabel.Location = New System.Drawing.Point(531, 67)
        ComputerLocationLabel.Name = "ComputerLocationLabel"
        ComputerLocationLabel.Size = New System.Drawing.Size(139, 18)
        ComputerLocationLabel.TabIndex = 4
        ComputerLocationLabel.Text = "Computer Location:"
        '
        'ComputerLocationTextBox
        '
        Me.ComputerLocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDevices1BindingSource, "ComputerLocation", True))
        Me.ComputerLocationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComputerLocationTextBox.Location = New System.Drawing.Point(676, 61)
        Me.ComputerLocationTextBox.Name = "ComputerLocationTextBox"
        Me.ComputerLocationTextBox.Size = New System.Drawing.Size(100, 24)
        Me.ComputerLocationTextBox.TabIndex = 0
        '
        'MACIDLabel
        '
        MACIDLabel.AutoSize = True
        MACIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MACIDLabel.Location = New System.Drawing.Point(546, 103)
        MACIDLabel.Name = "MACIDLabel"
        MACIDLabel.Size = New System.Drawing.Size(59, 18)
        MACIDLabel.TabIndex = 6
        MACIDLabel.Text = "MACID:"
        '
        'MACIDTextBox
        '
        Me.MACIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDevices1BindingSource, "MACID", True))
        Me.MACIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MACIDTextBox.Location = New System.Drawing.Point(676, 91)
        Me.MACIDTextBox.Name = "MACIDTextBox"
        Me.MACIDTextBox.Size = New System.Drawing.Size(100, 24)
        Me.MACIDTextBox.TabIndex = 1
        '
        'AuthorizedLabel
        '
        AuthorizedLabel.AutoSize = True
        AuthorizedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AuthorizedLabel.Location = New System.Drawing.Point(583, 127)
        AuthorizedLabel.Name = "AuthorizedLabel"
        AuthorizedLabel.Size = New System.Drawing.Size(82, 18)
        AuthorizedLabel.TabIndex = 8
        AuthorizedLabel.Text = "Authorized:"
        '
        'AuthorizedTextBox
        '
        Me.AuthorizedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDevices1BindingSource, "Authorized", True))
        Me.AuthorizedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorizedTextBox.Location = New System.Drawing.Point(676, 127)
        Me.AuthorizedTextBox.Name = "AuthorizedTextBox"
        Me.AuthorizedTextBox.Size = New System.Drawing.Size(100, 24)
        Me.AuthorizedTextBox.TabIndex = 9
        '
        'save
        '
        Me.save.BackgroundImage = Global.FinalCabSec.My.Resources.Resources.Save_Button_PNG_Photos1
        Me.save.Location = New System.Drawing.Point(654, 168)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(150, 56)
        Me.save.TabIndex = 10
        Me.save.UseVisualStyleBackColor = True
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
        'TblDevices1BindingNavigatorSaveItem
        '
        Me.TblDevices1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblDevices1BindingNavigatorSaveItem.Image = CType(resources.GetObject("TblDevices1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblDevices1BindingNavigatorSaveItem.Name = "TblDevices1BindingNavigatorSaveItem"
        Me.TblDevices1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblDevices1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'RecordIDLabel1
        '
        RecordIDLabel1.AutoSize = True
        RecordIDLabel1.Location = New System.Drawing.Point(675, 31)
        RecordIDLabel1.Name = "RecordIDLabel1"
        RecordIDLabel1.Size = New System.Drawing.Size(59, 13)
        RecordIDLabel1.TabIndex = 10
        RecordIDLabel1.Text = "Record ID:"
        RecordIDLabel1.Visible = False
        '
        'RecordIDLabel2
        '
        Me.RecordIDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDevices1BindingSource, "RecordID", True))
        Me.RecordIDLabel2.Location = New System.Drawing.Point(740, 31)
        Me.RecordIDLabel2.Name = "RecordIDLabel2"
        Me.RecordIDLabel2.Size = New System.Drawing.Size(100, 23)
        Me.RecordIDLabel2.TabIndex = 11
        Me.RecordIDLabel2.Text = "Label1"
        Me.RecordIDLabel2.Visible = False
        '
        'AddDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 322)
        Me.Controls.Add(RecordIDLabel1)
        Me.Controls.Add(Me.RecordIDLabel2)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(RecordIDLabel)
        Me.Controls.Add(ComputerLocationLabel)
        Me.Controls.Add(Me.ComputerLocationTextBox)
        Me.Controls.Add(MACIDLabel)
        Me.Controls.Add(Me.MACIDTextBox)
        Me.Controls.Add(AuthorizedLabel)
        Me.Controls.Add(Me.AuthorizedTextBox)
        Me.Controls.Add(Me.TblDevices1DataGridView)
        Me.Controls.Add(Me.TblDevices1BindingNavigator)
        Me.Name = "AddDevice"
        Me.Text = "AddDevice"
        CType(Me.DeviceAccessDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDevices1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDevices1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblDevices1BindingNavigator.ResumeLayout(False)
        Me.TblDevices1BindingNavigator.PerformLayout()
        CType(Me.TblDevices1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DeviceAccessDS As FinalCabSec.DeviceAccessDS
    Friend WithEvents TblDevices1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblDevices1TableAdapter As FinalCabSec.DeviceAccessDSTableAdapters.tblDevices1TableAdapter
    Friend WithEvents TableAdapterManager As FinalCabSec.DeviceAccessDSTableAdapters.TableAdapterManager
    Friend WithEvents TblDevices1BindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblDevices1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblDevices1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComputerLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MACIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorizedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents RecordIDLabel2 As System.Windows.Forms.Label
End Class
