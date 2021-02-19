<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.iconList = New System.Windows.Forms.ImageList(Me.components)
        Me.OfdPath = New System.Windows.Forms.OpenFileDialog()
        Me.tabQuery = New System.Windows.Forms.TabPage()
        Me.tbpQuerie = New System.Windows.Forms.TabControl()
        Me.tabQuery1 = New System.Windows.Forms.TabPage()
        Me.btnCleanQuery1 = New System.Windows.Forms.Button()
        Me.gbSolutionQuery1 = New System.Windows.Forms.GroupBox()
        Me.lblTripsSolution = New System.Windows.Forms.Label()
        Me.txtNumberTripsQuery1 = New System.Windows.Forms.TextBox()
        Me.lblNumberTripsQuery1 = New System.Windows.Forms.Label()
        Me.gbLstViewQuery1 = New System.Windows.Forms.GroupBox()
        Me.lstViewQuery1 = New System.Windows.Forms.ListView()
        Me.tripDateQuery1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.trainQuery1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productQuery1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbSlectionQuery1 = New System.Windows.Forms.GroupBox()
        Me.dtpDateEndQuery1 = New System.Windows.Forms.DateTimePicker()
        Me.lblDateStartQuery = New System.Windows.Forms.Label()
        Me.lblDateEnd = New System.Windows.Forms.Label()
        Me.lblTrainIdQuery = New System.Windows.Forms.Label()
        Me.dtpDateStartQuery1 = New System.Windows.Forms.DateTimePicker()
        Me.cboxTrainIdQuery1 = New System.Windows.Forms.ComboBox()
        Me.btnExecuteQuery1 = New System.Windows.Forms.Button()
        Me.tabQuery2 = New System.Windows.Forms.TabPage()
        Me.btnCleanQuery2 = New System.Windows.Forms.Button()
        Me.btnExecuteQuery2 = New System.Windows.Forms.Button()
        Me.gbSelectionQuery2 = New System.Windows.Forms.GroupBox()
        Me.lblEndDateQuery2 = New System.Windows.Forms.Label()
        Me.lblStartDateQuery2 = New System.Windows.Forms.Label()
        Me.dtpEndDateQuery2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDateQuery2 = New System.Windows.Forms.DateTimePicker()
        Me.gbQuery2List = New System.Windows.Forms.GroupBox()
        Me.lstViewQuery2 = New System.Windows.Forms.ListView()
        Me.trainType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalTrips = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabQuery3 = New System.Windows.Forms.TabPage()
        Me.gbQuery3List = New System.Windows.Forms.GroupBox()
        Me.lstViewQuery3 = New System.Windows.Forms.ListView()
        Me.Product = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnCleanQuery3 = New System.Windows.Forms.Button()
        Me.btnExecuteQuery3 = New System.Windows.Forms.Button()
        Me.gbSelectionPanelQuery3 = New System.Windows.Forms.GroupBox()
        Me.lblEndDateQuery3 = New System.Windows.Forms.Label()
        Me.lblStartDateQuery3 = New System.Windows.Forms.Label()
        Me.dtpEndDateQuery3 = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDateQuery3 = New System.Windows.Forms.DateTimePicker()
        Me.tabQuery4 = New System.Windows.Forms.TabPage()
        Me.btnCleanQuery4 = New System.Windows.Forms.Button()
        Me.btnExecuteQuery4 = New System.Windows.Forms.Button()
        Me.gbListQuery4 = New System.Windows.Forms.GroupBox()
        Me.txtMaxProfitQuery4 = New System.Windows.Forms.TextBox()
        Me.txtTrainTypeQuery4 = New System.Windows.Forms.TextBox()
        Me.txtTrainIDQuery4 = New System.Windows.Forms.TextBox()
        Me.lblTrainTypeQuery4 = New System.Windows.Forms.Label()
        Me.lblMaxProfit = New System.Windows.Forms.Label()
        Me.lblTrainIDQuery4 = New System.Windows.Forms.Label()
        Me.lblTripDateQuery4 = New System.Windows.Forms.Label()
        Me.txtTripDateQuery4 = New System.Windows.Forms.TextBox()
        Me.lstViewQuery4 = New System.Windows.Forms.ListView()
        Me.productQuery4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tonsQuery4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productPriceQuery4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productPriceDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.profitProductQuery4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabTrips = New System.Windows.Forms.TabPage()
        Me.gbControlTrip = New System.Windows.Forms.GroupBox()
        Me.btnAddTrip = New System.Windows.Forms.Button()
        Me.btnCleanTrip = New System.Windows.Forms.Button()
        Me.btnDeleteTrip = New System.Windows.Forms.Button()
        Me.btnUpdateTrip = New System.Windows.Forms.Button()
        Me.gbSelectionTrip = New System.Windows.Forms.GroupBox()
        Me.lstboxProductTrip = New System.Windows.Forms.ListBox()
        Me.nudTonsTrip = New System.Windows.Forms.NumericUpDown()
        Me.cboxTrainTrip = New System.Windows.Forms.ComboBox()
        Me.lblTonsTrip = New System.Windows.Forms.Label()
        Me.lblTrainTrip = New System.Windows.Forms.Label()
        Me.lblProductTrip = New System.Windows.Forms.Label()
        Me.lblDateTrip = New System.Windows.Forms.Label()
        Me.dtpTrip = New System.Windows.Forms.DateTimePicker()
        Me.gbTripList = New System.Windows.Forms.GroupBox()
        Me.lstViewTrip = New System.Windows.Forms.ListView()
        Me.dateTrip = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.trainTrip = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productTrip = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tonsTrip = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabPrices = New System.Windows.Forms.TabPage()
        Me.gbPriceList = New System.Windows.Forms.GroupBox()
        Me.lstViewPrices = New System.Windows.Forms.ListView()
        Me.ProductID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PriceDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PricePerTon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbControlPrices = New System.Windows.Forms.GroupBox()
        Me.btnAddPrices = New System.Windows.Forms.Button()
        Me.btnCleanPrices = New System.Windows.Forms.Button()
        Me.btnDeletePrices = New System.Windows.Forms.Button()
        Me.btnUpdatePrices = New System.Windows.Forms.Button()
        Me.gbPrices = New System.Windows.Forms.GroupBox()
        Me.lblEuroSymbol = New System.Windows.Forms.Label()
        Me.txtEurosPrices = New System.Windows.Forms.TextBox()
        Me.lblProductPrices = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.dtpDatePrices = New System.Windows.Forms.DateTimePicker()
        Me.cboxProductPrices = New System.Windows.Forms.ComboBox()
        Me.lblPricesList = New System.Windows.Forms.Label()
        Me.tabTrainTypes = New System.Windows.Forms.TabPage()
        Me.gbTrainTypeList = New System.Windows.Forms.GroupBox()
        Me.lstViewTrainTypes = New System.Windows.Forms.ListView()
        Me.idTrainTypes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.descriptionTrainTypes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.capacityTrainTypes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbTrainTypeBoxes = New System.Windows.Forms.GroupBox()
        Me.lblTonsTrainType = New System.Windows.Forms.Label()
        Me.nudMaxCapacity = New System.Windows.Forms.NumericUpDown()
        Me.lblTrainType = New System.Windows.Forms.Label()
        Me.txtTrainTypeDescription = New System.Windows.Forms.TextBox()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.gbControlTrainType = New System.Windows.Forms.GroupBox()
        Me.btnAddTrainType = New System.Windows.Forms.Button()
        Me.btnCleanTrainType = New System.Windows.Forms.Button()
        Me.btnUpdateTrainType = New System.Windows.Forms.Button()
        Me.btnDeleteTrainType = New System.Windows.Forms.Button()
        Me.lblTrainTypeList = New System.Windows.Forms.Label()
        Me.tabTrains = New System.Windows.Forms.TabPage()
        Me.gbTrainsList = New System.Windows.Forms.GroupBox()
        Me.lstViewTrains = New System.Windows.Forms.ListView()
        Me.idTrains = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.trainTypeTrains = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbTrainsBoxes = New System.Windows.Forms.GroupBox()
        Me.lblTrainDescription = New System.Windows.Forms.Label()
        Me.txtTrainID = New System.Windows.Forms.TextBox()
        Me.cboxTrain = New System.Windows.Forms.ComboBox()
        Me.lblTypeTrain = New System.Windows.Forms.Label()
        Me.gbControlTrains = New System.Windows.Forms.GroupBox()
        Me.btnAddTrain = New System.Windows.Forms.Button()
        Me.btnUpdateTrain = New System.Windows.Forms.Button()
        Me.btnCleanTrain = New System.Windows.Forms.Button()
        Me.btnDeleteTrain = New System.Windows.Forms.Button()
        Me.tabProduct = New System.Windows.Forms.TabPage()
        Me.gbProductsList = New System.Windows.Forms.GroupBox()
        Me.lstViewProducts = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbProductsBoxes = New System.Windows.Forms.GroupBox()
        Me.txtProductDescription = New System.Windows.Forms.TextBox()
        Me.lblProductDescription = New System.Windows.Forms.Label()
        Me.gbControlProducts = New System.Windows.Forms.GroupBox()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnCleanProduct = New System.Windows.Forms.Button()
        Me.btnDeleteProduct = New System.Windows.Forms.Button()
        Me.btnUpdateProduct = New System.Windows.Forms.Button()
        Me.lblProductList = New System.Windows.Forms.Label()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.gbDatabase = New System.Windows.Forms.GroupBox()
        Me.esiLogo = New System.Windows.Forms.PictureBox()
        Me.tabQuery.SuspendLayout()
        Me.tbpQuerie.SuspendLayout()
        Me.tabQuery1.SuspendLayout()
        Me.gbSolutionQuery1.SuspendLayout()
        Me.gbLstViewQuery1.SuspendLayout()
        Me.gbSlectionQuery1.SuspendLayout()
        Me.tabQuery2.SuspendLayout()
        Me.gbSelectionQuery2.SuspendLayout()
        Me.gbQuery2List.SuspendLayout()
        Me.tabQuery3.SuspendLayout()
        Me.gbQuery3List.SuspendLayout()
        Me.gbSelectionPanelQuery3.SuspendLayout()
        Me.tabQuery4.SuspendLayout()
        Me.gbListQuery4.SuspendLayout()
        Me.tabTrips.SuspendLayout()
        Me.gbControlTrip.SuspendLayout()
        Me.gbSelectionTrip.SuspendLayout()
        CType(Me.nudTonsTrip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTripList.SuspendLayout()
        Me.tabPrices.SuspendLayout()
        Me.gbPriceList.SuspendLayout()
        Me.gbControlPrices.SuspendLayout()
        Me.gbPrices.SuspendLayout()
        Me.tabTrainTypes.SuspendLayout()
        Me.gbTrainTypeList.SuspendLayout()
        Me.gbTrainTypeBoxes.SuspendLayout()
        CType(Me.nudMaxCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbControlTrainType.SuspendLayout()
        Me.tabTrains.SuspendLayout()
        Me.gbTrainsList.SuspendLayout()
        Me.gbTrainsBoxes.SuspendLayout()
        Me.gbControlTrains.SuspendLayout()
        Me.tabProduct.SuspendLayout()
        Me.gbProductsList.SuspendLayout()
        Me.gbProductsBoxes.SuspendLayout()
        Me.gbControlProducts.SuspendLayout()
        Me.tabControl.SuspendLayout()
        Me.gbDatabase.SuspendLayout()
        CType(Me.esiLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iconList
        '
        Me.iconList.ImageStream = CType(resources.GetObject("iconList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iconList.TransparentColor = System.Drawing.Color.Transparent
        Me.iconList.Images.SetKeyName(0, "productTab.png")
        Me.iconList.Images.SetKeyName(1, "trainTab.png")
        Me.iconList.Images.SetKeyName(2, "trainTypeTab.png")
        Me.iconList.Images.SetKeyName(3, "priceTab.png")
        Me.iconList.Images.SetKeyName(4, "tripTab.png")
        Me.iconList.Images.SetKeyName(5, "queryTab.png")
        Me.iconList.Images.SetKeyName(6, "addButton.png")
        Me.iconList.Images.SetKeyName(7, "cleanButton.png")
        Me.iconList.Images.SetKeyName(8, "deleteButton.png")
        Me.iconList.Images.SetKeyName(9, "updateButton.png")
        Me.iconList.Images.SetKeyName(10, "selectButton.png")
        Me.iconList.Images.SetKeyName(11, "dbIcon.png")
        Me.iconList.Images.SetKeyName(12, "esi-logo.jpg")
        '
        'OfdPath
        '
        Me.OfdPath.FileName = "OfdPath"
        '
        'tabQuery
        '
        Me.tabQuery.Controls.Add(Me.tbpQuerie)
        resources.ApplyResources(Me.tabQuery, "tabQuery")
        Me.tabQuery.Name = "tabQuery"
        Me.tabQuery.UseVisualStyleBackColor = True
        '
        'tbpQuerie
        '
        resources.ApplyResources(Me.tbpQuerie, "tbpQuerie")
        Me.tbpQuerie.Controls.Add(Me.tabQuery1)
        Me.tbpQuerie.Controls.Add(Me.tabQuery2)
        Me.tbpQuerie.Controls.Add(Me.tabQuery3)
        Me.tbpQuerie.Controls.Add(Me.tabQuery4)
        Me.tbpQuerie.Multiline = True
        Me.tbpQuerie.Name = "tbpQuerie"
        Me.tbpQuerie.SelectedIndex = 0
        '
        'tabQuery1
        '
        Me.tabQuery1.BackColor = System.Drawing.Color.LightSlateGray
        Me.tabQuery1.Controls.Add(Me.btnCleanQuery1)
        Me.tabQuery1.Controls.Add(Me.gbSolutionQuery1)
        Me.tabQuery1.Controls.Add(Me.gbLstViewQuery1)
        Me.tabQuery1.Controls.Add(Me.gbSlectionQuery1)
        Me.tabQuery1.Controls.Add(Me.btnExecuteQuery1)
        resources.ApplyResources(Me.tabQuery1, "tabQuery1")
        Me.tabQuery1.Name = "tabQuery1"
        '
        'btnCleanQuery1
        '
        resources.ApplyResources(Me.btnCleanQuery1, "btnCleanQuery1")
        Me.btnCleanQuery1.Name = "btnCleanQuery1"
        Me.btnCleanQuery1.UseVisualStyleBackColor = True
        '
        'gbSolutionQuery1
        '
        Me.gbSolutionQuery1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbSolutionQuery1.Controls.Add(Me.lblTripsSolution)
        Me.gbSolutionQuery1.Controls.Add(Me.txtNumberTripsQuery1)
        Me.gbSolutionQuery1.Controls.Add(Me.lblNumberTripsQuery1)
        resources.ApplyResources(Me.gbSolutionQuery1, "gbSolutionQuery1")
        Me.gbSolutionQuery1.Name = "gbSolutionQuery1"
        Me.gbSolutionQuery1.TabStop = False
        '
        'lblTripsSolution
        '
        resources.ApplyResources(Me.lblTripsSolution, "lblTripsSolution")
        Me.lblTripsSolution.Name = "lblTripsSolution"
        '
        'txtNumberTripsQuery1
        '
        Me.txtNumberTripsQuery1.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txtNumberTripsQuery1, "txtNumberTripsQuery1")
        Me.txtNumberTripsQuery1.Name = "txtNumberTripsQuery1"
        '
        'lblNumberTripsQuery1
        '
        resources.ApplyResources(Me.lblNumberTripsQuery1, "lblNumberTripsQuery1")
        Me.lblNumberTripsQuery1.Name = "lblNumberTripsQuery1"
        '
        'gbLstViewQuery1
        '
        Me.gbLstViewQuery1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbLstViewQuery1.Controls.Add(Me.lstViewQuery1)
        resources.ApplyResources(Me.gbLstViewQuery1, "gbLstViewQuery1")
        Me.gbLstViewQuery1.Name = "gbLstViewQuery1"
        Me.gbLstViewQuery1.TabStop = False
        '
        'lstViewQuery1
        '
        Me.lstViewQuery1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.tripDateQuery1, Me.trainQuery1, Me.productQuery1})
        resources.ApplyResources(Me.lstViewQuery1, "lstViewQuery1")
        Me.lstViewQuery1.FullRowSelect = True
        Me.lstViewQuery1.HideSelection = False
        Me.lstViewQuery1.MultiSelect = False
        Me.lstViewQuery1.Name = "lstViewQuery1"
        Me.lstViewQuery1.UseCompatibleStateImageBehavior = False
        Me.lstViewQuery1.View = System.Windows.Forms.View.Details
        '
        'tripDateQuery1
        '
        resources.ApplyResources(Me.tripDateQuery1, "tripDateQuery1")
        '
        'trainQuery1
        '
        resources.ApplyResources(Me.trainQuery1, "trainQuery1")
        '
        'productQuery1
        '
        resources.ApplyResources(Me.productQuery1, "productQuery1")
        '
        'gbSlectionQuery1
        '
        Me.gbSlectionQuery1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbSlectionQuery1.Controls.Add(Me.dtpDateEndQuery1)
        Me.gbSlectionQuery1.Controls.Add(Me.lblDateStartQuery)
        Me.gbSlectionQuery1.Controls.Add(Me.lblDateEnd)
        Me.gbSlectionQuery1.Controls.Add(Me.lblTrainIdQuery)
        Me.gbSlectionQuery1.Controls.Add(Me.dtpDateStartQuery1)
        Me.gbSlectionQuery1.Controls.Add(Me.cboxTrainIdQuery1)
        resources.ApplyResources(Me.gbSlectionQuery1, "gbSlectionQuery1")
        Me.gbSlectionQuery1.Name = "gbSlectionQuery1"
        Me.gbSlectionQuery1.TabStop = False
        '
        'dtpDateEndQuery1
        '
        resources.ApplyResources(Me.dtpDateEndQuery1, "dtpDateEndQuery1")
        Me.dtpDateEndQuery1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateEndQuery1.Name = "dtpDateEndQuery1"
        '
        'lblDateStartQuery
        '
        resources.ApplyResources(Me.lblDateStartQuery, "lblDateStartQuery")
        Me.lblDateStartQuery.Name = "lblDateStartQuery"
        '
        'lblDateEnd
        '
        resources.ApplyResources(Me.lblDateEnd, "lblDateEnd")
        Me.lblDateEnd.Name = "lblDateEnd"
        '
        'lblTrainIdQuery
        '
        resources.ApplyResources(Me.lblTrainIdQuery, "lblTrainIdQuery")
        Me.lblTrainIdQuery.Name = "lblTrainIdQuery"
        '
        'dtpDateStartQuery1
        '
        resources.ApplyResources(Me.dtpDateStartQuery1, "dtpDateStartQuery1")
        Me.dtpDateStartQuery1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateStartQuery1.Name = "dtpDateStartQuery1"
        '
        'cboxTrainIdQuery1
        '
        Me.cboxTrainIdQuery1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboxTrainIdQuery1, "cboxTrainIdQuery1")
        Me.cboxTrainIdQuery1.FormattingEnabled = True
        Me.cboxTrainIdQuery1.Name = "cboxTrainIdQuery1"
        '
        'btnExecuteQuery1
        '
        Me.btnExecuteQuery1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.btnExecuteQuery1, "btnExecuteQuery1")
        Me.btnExecuteQuery1.Name = "btnExecuteQuery1"
        Me.btnExecuteQuery1.UseVisualStyleBackColor = False
        '
        'tabQuery2
        '
        Me.tabQuery2.BackColor = System.Drawing.Color.LightSlateGray
        Me.tabQuery2.Controls.Add(Me.btnCleanQuery2)
        Me.tabQuery2.Controls.Add(Me.btnExecuteQuery2)
        Me.tabQuery2.Controls.Add(Me.gbSelectionQuery2)
        Me.tabQuery2.Controls.Add(Me.gbQuery2List)
        resources.ApplyResources(Me.tabQuery2, "tabQuery2")
        Me.tabQuery2.Name = "tabQuery2"
        '
        'btnCleanQuery2
        '
        resources.ApplyResources(Me.btnCleanQuery2, "btnCleanQuery2")
        Me.btnCleanQuery2.Name = "btnCleanQuery2"
        Me.btnCleanQuery2.UseVisualStyleBackColor = True
        '
        'btnExecuteQuery2
        '
        resources.ApplyResources(Me.btnExecuteQuery2, "btnExecuteQuery2")
        Me.btnExecuteQuery2.Name = "btnExecuteQuery2"
        Me.btnExecuteQuery2.UseVisualStyleBackColor = True
        '
        'gbSelectionQuery2
        '
        Me.gbSelectionQuery2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbSelectionQuery2.Controls.Add(Me.lblEndDateQuery2)
        Me.gbSelectionQuery2.Controls.Add(Me.lblStartDateQuery2)
        Me.gbSelectionQuery2.Controls.Add(Me.dtpEndDateQuery2)
        Me.gbSelectionQuery2.Controls.Add(Me.dtpStartDateQuery2)
        resources.ApplyResources(Me.gbSelectionQuery2, "gbSelectionQuery2")
        Me.gbSelectionQuery2.Name = "gbSelectionQuery2"
        Me.gbSelectionQuery2.TabStop = False
        '
        'lblEndDateQuery2
        '
        resources.ApplyResources(Me.lblEndDateQuery2, "lblEndDateQuery2")
        Me.lblEndDateQuery2.Name = "lblEndDateQuery2"
        '
        'lblStartDateQuery2
        '
        resources.ApplyResources(Me.lblStartDateQuery2, "lblStartDateQuery2")
        Me.lblStartDateQuery2.Name = "lblStartDateQuery2"
        '
        'dtpEndDateQuery2
        '
        resources.ApplyResources(Me.dtpEndDateQuery2, "dtpEndDateQuery2")
        Me.dtpEndDateQuery2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDateQuery2.Name = "dtpEndDateQuery2"
        '
        'dtpStartDateQuery2
        '
        resources.ApplyResources(Me.dtpStartDateQuery2, "dtpStartDateQuery2")
        Me.dtpStartDateQuery2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDateQuery2.Name = "dtpStartDateQuery2"
        '
        'gbQuery2List
        '
        Me.gbQuery2List.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbQuery2List.Controls.Add(Me.lstViewQuery2)
        resources.ApplyResources(Me.gbQuery2List, "gbQuery2List")
        Me.gbQuery2List.Name = "gbQuery2List"
        Me.gbQuery2List.TabStop = False
        '
        'lstViewQuery2
        '
        Me.lstViewQuery2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.trainType, Me.totalTrips})
        resources.ApplyResources(Me.lstViewQuery2, "lstViewQuery2")
        Me.lstViewQuery2.FullRowSelect = True
        Me.lstViewQuery2.HideSelection = False
        Me.lstViewQuery2.MultiSelect = False
        Me.lstViewQuery2.Name = "lstViewQuery2"
        Me.lstViewQuery2.UseCompatibleStateImageBehavior = False
        Me.lstViewQuery2.View = System.Windows.Forms.View.Details
        '
        'trainType
        '
        resources.ApplyResources(Me.trainType, "trainType")
        '
        'totalTrips
        '
        resources.ApplyResources(Me.totalTrips, "totalTrips")
        '
        'tabQuery3
        '
        Me.tabQuery3.BackColor = System.Drawing.Color.LightSlateGray
        Me.tabQuery3.Controls.Add(Me.gbQuery3List)
        Me.tabQuery3.Controls.Add(Me.btnCleanQuery3)
        Me.tabQuery3.Controls.Add(Me.btnExecuteQuery3)
        Me.tabQuery3.Controls.Add(Me.gbSelectionPanelQuery3)
        resources.ApplyResources(Me.tabQuery3, "tabQuery3")
        Me.tabQuery3.Name = "tabQuery3"
        '
        'gbQuery3List
        '
        Me.gbQuery3List.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbQuery3List.Controls.Add(Me.lstViewQuery3)
        resources.ApplyResources(Me.gbQuery3List, "gbQuery3List")
        Me.gbQuery3List.Name = "gbQuery3List"
        Me.gbQuery3List.TabStop = False
        '
        'lstViewQuery3
        '
        Me.lstViewQuery3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Product, Me.total})
        resources.ApplyResources(Me.lstViewQuery3, "lstViewQuery3")
        Me.lstViewQuery3.FullRowSelect = True
        Me.lstViewQuery3.HideSelection = False
        Me.lstViewQuery3.MultiSelect = False
        Me.lstViewQuery3.Name = "lstViewQuery3"
        Me.lstViewQuery3.UseCompatibleStateImageBehavior = False
        Me.lstViewQuery3.View = System.Windows.Forms.View.Details
        '
        'Product
        '
        resources.ApplyResources(Me.Product, "Product")
        '
        'total
        '
        resources.ApplyResources(Me.total, "total")
        '
        'btnCleanQuery3
        '
        resources.ApplyResources(Me.btnCleanQuery3, "btnCleanQuery3")
        Me.btnCleanQuery3.Name = "btnCleanQuery3"
        Me.btnCleanQuery3.UseVisualStyleBackColor = True
        '
        'btnExecuteQuery3
        '
        resources.ApplyResources(Me.btnExecuteQuery3, "btnExecuteQuery3")
        Me.btnExecuteQuery3.Name = "btnExecuteQuery3"
        Me.btnExecuteQuery3.UseVisualStyleBackColor = True
        '
        'gbSelectionPanelQuery3
        '
        Me.gbSelectionPanelQuery3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbSelectionPanelQuery3.Controls.Add(Me.lblEndDateQuery3)
        Me.gbSelectionPanelQuery3.Controls.Add(Me.lblStartDateQuery3)
        Me.gbSelectionPanelQuery3.Controls.Add(Me.dtpEndDateQuery3)
        Me.gbSelectionPanelQuery3.Controls.Add(Me.dtpStartDateQuery3)
        resources.ApplyResources(Me.gbSelectionPanelQuery3, "gbSelectionPanelQuery3")
        Me.gbSelectionPanelQuery3.Name = "gbSelectionPanelQuery3"
        Me.gbSelectionPanelQuery3.TabStop = False
        '
        'lblEndDateQuery3
        '
        resources.ApplyResources(Me.lblEndDateQuery3, "lblEndDateQuery3")
        Me.lblEndDateQuery3.Name = "lblEndDateQuery3"
        '
        'lblStartDateQuery3
        '
        resources.ApplyResources(Me.lblStartDateQuery3, "lblStartDateQuery3")
        Me.lblStartDateQuery3.Name = "lblStartDateQuery3"
        '
        'dtpEndDateQuery3
        '
        resources.ApplyResources(Me.dtpEndDateQuery3, "dtpEndDateQuery3")
        Me.dtpEndDateQuery3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDateQuery3.Name = "dtpEndDateQuery3"
        '
        'dtpStartDateQuery3
        '
        resources.ApplyResources(Me.dtpStartDateQuery3, "dtpStartDateQuery3")
        Me.dtpStartDateQuery3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDateQuery3.Name = "dtpStartDateQuery3"
        '
        'tabQuery4
        '
        Me.tabQuery4.BackColor = System.Drawing.Color.LightSlateGray
        Me.tabQuery4.Controls.Add(Me.btnCleanQuery4)
        Me.tabQuery4.Controls.Add(Me.btnExecuteQuery4)
        Me.tabQuery4.Controls.Add(Me.gbListQuery4)
        resources.ApplyResources(Me.tabQuery4, "tabQuery4")
        Me.tabQuery4.Name = "tabQuery4"
        '
        'btnCleanQuery4
        '
        resources.ApplyResources(Me.btnCleanQuery4, "btnCleanQuery4")
        Me.btnCleanQuery4.Name = "btnCleanQuery4"
        Me.btnCleanQuery4.UseVisualStyleBackColor = True
        '
        'btnExecuteQuery4
        '
        resources.ApplyResources(Me.btnExecuteQuery4, "btnExecuteQuery4")
        Me.btnExecuteQuery4.Name = "btnExecuteQuery4"
        Me.btnExecuteQuery4.UseVisualStyleBackColor = True
        '
        'gbListQuery4
        '
        Me.gbListQuery4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbListQuery4.Controls.Add(Me.txtMaxProfitQuery4)
        Me.gbListQuery4.Controls.Add(Me.txtTrainTypeQuery4)
        Me.gbListQuery4.Controls.Add(Me.txtTrainIDQuery4)
        Me.gbListQuery4.Controls.Add(Me.lblTrainTypeQuery4)
        Me.gbListQuery4.Controls.Add(Me.lblMaxProfit)
        Me.gbListQuery4.Controls.Add(Me.lblTrainIDQuery4)
        Me.gbListQuery4.Controls.Add(Me.lblTripDateQuery4)
        Me.gbListQuery4.Controls.Add(Me.txtTripDateQuery4)
        Me.gbListQuery4.Controls.Add(Me.lstViewQuery4)
        resources.ApplyResources(Me.gbListQuery4, "gbListQuery4")
        Me.gbListQuery4.Name = "gbListQuery4"
        Me.gbListQuery4.TabStop = False
        '
        'txtMaxProfitQuery4
        '
        Me.txtMaxProfitQuery4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.txtMaxProfitQuery4, "txtMaxProfitQuery4")
        Me.txtMaxProfitQuery4.ForeColor = System.Drawing.Color.Black
        Me.txtMaxProfitQuery4.Name = "txtMaxProfitQuery4"
        '
        'txtTrainTypeQuery4
        '
        Me.txtTrainTypeQuery4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.txtTrainTypeQuery4, "txtTrainTypeQuery4")
        Me.txtTrainTypeQuery4.ForeColor = System.Drawing.Color.Black
        Me.txtTrainTypeQuery4.Name = "txtTrainTypeQuery4"
        '
        'txtTrainIDQuery4
        '
        Me.txtTrainIDQuery4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.txtTrainIDQuery4, "txtTrainIDQuery4")
        Me.txtTrainIDQuery4.ForeColor = System.Drawing.Color.Black
        Me.txtTrainIDQuery4.Name = "txtTrainIDQuery4"
        '
        'lblTrainTypeQuery4
        '
        resources.ApplyResources(Me.lblTrainTypeQuery4, "lblTrainTypeQuery4")
        Me.lblTrainTypeQuery4.Name = "lblTrainTypeQuery4"
        '
        'lblMaxProfit
        '
        resources.ApplyResources(Me.lblMaxProfit, "lblMaxProfit")
        Me.lblMaxProfit.Name = "lblMaxProfit"
        '
        'lblTrainIDQuery4
        '
        resources.ApplyResources(Me.lblTrainIDQuery4, "lblTrainIDQuery4")
        Me.lblTrainIDQuery4.Name = "lblTrainIDQuery4"
        '
        'lblTripDateQuery4
        '
        resources.ApplyResources(Me.lblTripDateQuery4, "lblTripDateQuery4")
        Me.lblTripDateQuery4.Name = "lblTripDateQuery4"
        '
        'txtTripDateQuery4
        '
        Me.txtTripDateQuery4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.txtTripDateQuery4, "txtTripDateQuery4")
        Me.txtTripDateQuery4.ForeColor = System.Drawing.Color.Black
        Me.txtTripDateQuery4.Name = "txtTripDateQuery4"
        '
        'lstViewQuery4
        '
        Me.lstViewQuery4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.productQuery4, Me.tonsQuery4, Me.productPriceQuery4, Me.productPriceDate, Me.profitProductQuery4})
        resources.ApplyResources(Me.lstViewQuery4, "lstViewQuery4")
        Me.lstViewQuery4.FullRowSelect = True
        Me.lstViewQuery4.HideSelection = False
        Me.lstViewQuery4.MultiSelect = False
        Me.lstViewQuery4.Name = "lstViewQuery4"
        Me.lstViewQuery4.UseCompatibleStateImageBehavior = False
        Me.lstViewQuery4.View = System.Windows.Forms.View.Details
        '
        'productQuery4
        '
        resources.ApplyResources(Me.productQuery4, "productQuery4")
        '
        'tonsQuery4
        '
        resources.ApplyResources(Me.tonsQuery4, "tonsQuery4")
        '
        'productPriceQuery4
        '
        resources.ApplyResources(Me.productPriceQuery4, "productPriceQuery4")
        '
        'productPriceDate
        '
        resources.ApplyResources(Me.productPriceDate, "productPriceDate")
        '
        'profitProductQuery4
        '
        resources.ApplyResources(Me.profitProductQuery4, "profitProductQuery4")
        '
        'tabTrips
        '
        Me.tabTrips.BackColor = System.Drawing.Color.LightSlateGray
        Me.tabTrips.Controls.Add(Me.gbControlTrip)
        Me.tabTrips.Controls.Add(Me.gbSelectionTrip)
        Me.tabTrips.Controls.Add(Me.gbTripList)
        resources.ApplyResources(Me.tabTrips, "tabTrips")
        Me.tabTrips.Name = "tabTrips"
        '
        'gbControlTrip
        '
        Me.gbControlTrip.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbControlTrip.Controls.Add(Me.btnAddTrip)
        Me.gbControlTrip.Controls.Add(Me.btnCleanTrip)
        Me.gbControlTrip.Controls.Add(Me.btnDeleteTrip)
        Me.gbControlTrip.Controls.Add(Me.btnUpdateTrip)
        resources.ApplyResources(Me.gbControlTrip, "gbControlTrip")
        Me.gbControlTrip.Name = "gbControlTrip"
        Me.gbControlTrip.TabStop = False
        '
        'btnAddTrip
        '
        Me.btnAddTrip.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnAddTrip, "btnAddTrip")
        Me.btnAddTrip.ImageList = Me.iconList
        Me.btnAddTrip.Name = "btnAddTrip"
        Me.btnAddTrip.UseVisualStyleBackColor = False
        '
        'btnCleanTrip
        '
        Me.btnCleanTrip.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnCleanTrip, "btnCleanTrip")
        Me.btnCleanTrip.ImageList = Me.iconList
        Me.btnCleanTrip.Name = "btnCleanTrip"
        Me.btnCleanTrip.UseVisualStyleBackColor = False
        '
        'btnDeleteTrip
        '
        Me.btnDeleteTrip.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnDeleteTrip, "btnDeleteTrip")
        Me.btnDeleteTrip.ImageList = Me.iconList
        Me.btnDeleteTrip.Name = "btnDeleteTrip"
        Me.btnDeleteTrip.UseVisualStyleBackColor = False
        '
        'btnUpdateTrip
        '
        Me.btnUpdateTrip.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnUpdateTrip, "btnUpdateTrip")
        Me.btnUpdateTrip.ImageList = Me.iconList
        Me.btnUpdateTrip.Name = "btnUpdateTrip"
        Me.btnUpdateTrip.UseVisualStyleBackColor = False
        '
        'gbSelectionTrip
        '
        Me.gbSelectionTrip.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbSelectionTrip.Controls.Add(Me.lstboxProductTrip)
        Me.gbSelectionTrip.Controls.Add(Me.nudTonsTrip)
        Me.gbSelectionTrip.Controls.Add(Me.cboxTrainTrip)
        Me.gbSelectionTrip.Controls.Add(Me.lblTonsTrip)
        Me.gbSelectionTrip.Controls.Add(Me.lblTrainTrip)
        Me.gbSelectionTrip.Controls.Add(Me.lblProductTrip)
        Me.gbSelectionTrip.Controls.Add(Me.lblDateTrip)
        Me.gbSelectionTrip.Controls.Add(Me.dtpTrip)
        resources.ApplyResources(Me.gbSelectionTrip, "gbSelectionTrip")
        Me.gbSelectionTrip.Name = "gbSelectionTrip"
        Me.gbSelectionTrip.TabStop = False
        '
        'lstboxProductTrip
        '
        Me.lstboxProductTrip.ForeColor = System.Drawing.Color.Black
        Me.lstboxProductTrip.FormattingEnabled = True
        resources.ApplyResources(Me.lstboxProductTrip, "lstboxProductTrip")
        Me.lstboxProductTrip.MultiColumn = True
        Me.lstboxProductTrip.Name = "lstboxProductTrip"
        Me.lstboxProductTrip.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        '
        'nudTonsTrip
        '
        Me.nudTonsTrip.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.nudTonsTrip, "nudTonsTrip")
        Me.nudTonsTrip.Name = "nudTonsTrip"
        '
        'cboxTrainTrip
        '
        Me.cboxTrainTrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboxTrainTrip, "cboxTrainTrip")
        Me.cboxTrainTrip.ForeColor = System.Drawing.Color.Black
        Me.cboxTrainTrip.FormattingEnabled = True
        Me.cboxTrainTrip.Name = "cboxTrainTrip"
        '
        'lblTonsTrip
        '
        resources.ApplyResources(Me.lblTonsTrip, "lblTonsTrip")
        Me.lblTonsTrip.Name = "lblTonsTrip"
        '
        'lblTrainTrip
        '
        resources.ApplyResources(Me.lblTrainTrip, "lblTrainTrip")
        Me.lblTrainTrip.Name = "lblTrainTrip"
        '
        'lblProductTrip
        '
        resources.ApplyResources(Me.lblProductTrip, "lblProductTrip")
        Me.lblProductTrip.Name = "lblProductTrip"
        '
        'lblDateTrip
        '
        resources.ApplyResources(Me.lblDateTrip, "lblDateTrip")
        Me.lblDateTrip.Name = "lblDateTrip"
        '
        'dtpTrip
        '
        resources.ApplyResources(Me.dtpTrip, "dtpTrip")
        Me.dtpTrip.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTrip.Name = "dtpTrip"
        '
        'gbTripList
        '
        Me.gbTripList.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbTripList.Controls.Add(Me.lstViewTrip)
        resources.ApplyResources(Me.gbTripList, "gbTripList")
        Me.gbTripList.Name = "gbTripList"
        Me.gbTripList.TabStop = False
        '
        'lstViewTrip
        '
        Me.lstViewTrip.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.dateTrip, Me.trainTrip, Me.productTrip, Me.tonsTrip})
        Me.lstViewTrip.ForeColor = System.Drawing.Color.Black
        Me.lstViewTrip.FullRowSelect = True
        Me.lstViewTrip.HideSelection = False
        resources.ApplyResources(Me.lstViewTrip, "lstViewTrip")
        Me.lstViewTrip.MultiSelect = False
        Me.lstViewTrip.Name = "lstViewTrip"
        Me.lstViewTrip.UseCompatibleStateImageBehavior = False
        Me.lstViewTrip.View = System.Windows.Forms.View.Details
        '
        'dateTrip
        '
        resources.ApplyResources(Me.dateTrip, "dateTrip")
        '
        'trainTrip
        '
        resources.ApplyResources(Me.trainTrip, "trainTrip")
        '
        'productTrip
        '
        resources.ApplyResources(Me.productTrip, "productTrip")
        '
        'tonsTrip
        '
        resources.ApplyResources(Me.tonsTrip, "tonsTrip")
        '
        'tabPrices
        '
        Me.tabPrices.BackColor = System.Drawing.Color.LightSlateGray
        Me.tabPrices.Controls.Add(Me.gbPriceList)
        Me.tabPrices.Controls.Add(Me.gbControlPrices)
        Me.tabPrices.Controls.Add(Me.gbPrices)
        Me.tabPrices.Controls.Add(Me.lblPricesList)
        resources.ApplyResources(Me.tabPrices, "tabPrices")
        Me.tabPrices.Name = "tabPrices"
        '
        'gbPriceList
        '
        Me.gbPriceList.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbPriceList.Controls.Add(Me.lstViewPrices)
        resources.ApplyResources(Me.gbPriceList, "gbPriceList")
        Me.gbPriceList.Name = "gbPriceList"
        Me.gbPriceList.TabStop = False
        '
        'lstViewPrices
        '
        Me.lstViewPrices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProductID, Me.ProductDescription, Me.PriceDate, Me.PricePerTon})
        Me.lstViewPrices.ForeColor = System.Drawing.Color.Black
        Me.lstViewPrices.FullRowSelect = True
        Me.lstViewPrices.HideSelection = False
        resources.ApplyResources(Me.lstViewPrices, "lstViewPrices")
        Me.lstViewPrices.MultiSelect = False
        Me.lstViewPrices.Name = "lstViewPrices"
        Me.lstViewPrices.UseCompatibleStateImageBehavior = False
        Me.lstViewPrices.View = System.Windows.Forms.View.Details
        '
        'ProductID
        '
        resources.ApplyResources(Me.ProductID, "ProductID")
        '
        'ProductDescription
        '
        resources.ApplyResources(Me.ProductDescription, "ProductDescription")
        '
        'PriceDate
        '
        resources.ApplyResources(Me.PriceDate, "PriceDate")
        '
        'PricePerTon
        '
        resources.ApplyResources(Me.PricePerTon, "PricePerTon")
        '
        'gbControlPrices
        '
        Me.gbControlPrices.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbControlPrices.Controls.Add(Me.btnAddPrices)
        Me.gbControlPrices.Controls.Add(Me.btnCleanPrices)
        Me.gbControlPrices.Controls.Add(Me.btnDeletePrices)
        Me.gbControlPrices.Controls.Add(Me.btnUpdatePrices)
        resources.ApplyResources(Me.gbControlPrices, "gbControlPrices")
        Me.gbControlPrices.Name = "gbControlPrices"
        Me.gbControlPrices.TabStop = False
        '
        'btnAddPrices
        '
        Me.btnAddPrices.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnAddPrices, "btnAddPrices")
        Me.btnAddPrices.ImageList = Me.iconList
        Me.btnAddPrices.Name = "btnAddPrices"
        Me.btnAddPrices.UseVisualStyleBackColor = False
        '
        'btnCleanPrices
        '
        Me.btnCleanPrices.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnCleanPrices, "btnCleanPrices")
        Me.btnCleanPrices.ImageList = Me.iconList
        Me.btnCleanPrices.Name = "btnCleanPrices"
        Me.btnCleanPrices.UseVisualStyleBackColor = False
        '
        'btnDeletePrices
        '
        Me.btnDeletePrices.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnDeletePrices, "btnDeletePrices")
        Me.btnDeletePrices.ImageList = Me.iconList
        Me.btnDeletePrices.Name = "btnDeletePrices"
        Me.btnDeletePrices.UseVisualStyleBackColor = False
        '
        'btnUpdatePrices
        '
        Me.btnUpdatePrices.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnUpdatePrices, "btnUpdatePrices")
        Me.btnUpdatePrices.ImageList = Me.iconList
        Me.btnUpdatePrices.Name = "btnUpdatePrices"
        Me.btnUpdatePrices.UseVisualStyleBackColor = False
        '
        'gbPrices
        '
        Me.gbPrices.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbPrices.Controls.Add(Me.lblEuroSymbol)
        Me.gbPrices.Controls.Add(Me.txtEurosPrices)
        Me.gbPrices.Controls.Add(Me.lblProductPrices)
        Me.gbPrices.Controls.Add(Me.lblDate)
        Me.gbPrices.Controls.Add(Me.lblPrice)
        Me.gbPrices.Controls.Add(Me.dtpDatePrices)
        Me.gbPrices.Controls.Add(Me.cboxProductPrices)
        resources.ApplyResources(Me.gbPrices, "gbPrices")
        Me.gbPrices.Name = "gbPrices"
        Me.gbPrices.TabStop = False
        '
        'lblEuroSymbol
        '
        resources.ApplyResources(Me.lblEuroSymbol, "lblEuroSymbol")
        Me.lblEuroSymbol.Name = "lblEuroSymbol"
        '
        'txtEurosPrices
        '
        resources.ApplyResources(Me.txtEurosPrices, "txtEurosPrices")
        Me.txtEurosPrices.ForeColor = System.Drawing.Color.Black
        Me.txtEurosPrices.Name = "txtEurosPrices"
        '
        'lblProductPrices
        '
        resources.ApplyResources(Me.lblProductPrices, "lblProductPrices")
        Me.lblProductPrices.Name = "lblProductPrices"
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        '
        'lblPrice
        '
        resources.ApplyResources(Me.lblPrice, "lblPrice")
        Me.lblPrice.Name = "lblPrice"
        '
        'dtpDatePrices
        '
        resources.ApplyResources(Me.dtpDatePrices, "dtpDatePrices")
        Me.dtpDatePrices.Name = "dtpDatePrices"
        '
        'cboxProductPrices
        '
        Me.cboxProductPrices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboxProductPrices, "cboxProductPrices")
        Me.cboxProductPrices.ForeColor = System.Drawing.Color.Black
        Me.cboxProductPrices.FormattingEnabled = True
        Me.cboxProductPrices.Name = "cboxProductPrices"
        '
        'lblPricesList
        '
        resources.ApplyResources(Me.lblPricesList, "lblPricesList")
        Me.lblPricesList.Name = "lblPricesList"
        '
        'tabTrainTypes
        '
        Me.tabTrainTypes.BackColor = System.Drawing.Color.LightSlateGray
        Me.tabTrainTypes.Controls.Add(Me.gbTrainTypeList)
        Me.tabTrainTypes.Controls.Add(Me.gbTrainTypeBoxes)
        Me.tabTrainTypes.Controls.Add(Me.gbControlTrainType)
        Me.tabTrainTypes.Controls.Add(Me.lblTrainTypeList)
        resources.ApplyResources(Me.tabTrainTypes, "tabTrainTypes")
        Me.tabTrainTypes.Name = "tabTrainTypes"
        '
        'gbTrainTypeList
        '
        Me.gbTrainTypeList.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbTrainTypeList.Controls.Add(Me.lstViewTrainTypes)
        resources.ApplyResources(Me.gbTrainTypeList, "gbTrainTypeList")
        Me.gbTrainTypeList.Name = "gbTrainTypeList"
        Me.gbTrainTypeList.TabStop = False
        '
        'lstViewTrainTypes
        '
        Me.lstViewTrainTypes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idTrainTypes, Me.descriptionTrainTypes, Me.capacityTrainTypes})
        resources.ApplyResources(Me.lstViewTrainTypes, "lstViewTrainTypes")
        Me.lstViewTrainTypes.ForeColor = System.Drawing.Color.Black
        Me.lstViewTrainTypes.FullRowSelect = True
        Me.lstViewTrainTypes.HideSelection = False
        Me.lstViewTrainTypes.MultiSelect = False
        Me.lstViewTrainTypes.Name = "lstViewTrainTypes"
        Me.lstViewTrainTypes.UseCompatibleStateImageBehavior = False
        Me.lstViewTrainTypes.View = System.Windows.Forms.View.Details
        '
        'idTrainTypes
        '
        resources.ApplyResources(Me.idTrainTypes, "idTrainTypes")
        '
        'descriptionTrainTypes
        '
        resources.ApplyResources(Me.descriptionTrainTypes, "descriptionTrainTypes")
        '
        'capacityTrainTypes
        '
        resources.ApplyResources(Me.capacityTrainTypes, "capacityTrainTypes")
        '
        'gbTrainTypeBoxes
        '
        Me.gbTrainTypeBoxes.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbTrainTypeBoxes.Controls.Add(Me.lblTonsTrainType)
        Me.gbTrainTypeBoxes.Controls.Add(Me.nudMaxCapacity)
        Me.gbTrainTypeBoxes.Controls.Add(Me.lblTrainType)
        Me.gbTrainTypeBoxes.Controls.Add(Me.txtTrainTypeDescription)
        Me.gbTrainTypeBoxes.Controls.Add(Me.lblCapacity)
        resources.ApplyResources(Me.gbTrainTypeBoxes, "gbTrainTypeBoxes")
        Me.gbTrainTypeBoxes.Name = "gbTrainTypeBoxes"
        Me.gbTrainTypeBoxes.TabStop = False
        '
        'lblTonsTrainType
        '
        resources.ApplyResources(Me.lblTonsTrainType, "lblTonsTrainType")
        Me.lblTonsTrainType.Name = "lblTonsTrainType"
        '
        'nudMaxCapacity
        '
        Me.nudMaxCapacity.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.nudMaxCapacity, "nudMaxCapacity")
        Me.nudMaxCapacity.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.nudMaxCapacity.Name = "nudMaxCapacity"
        '
        'lblTrainType
        '
        resources.ApplyResources(Me.lblTrainType, "lblTrainType")
        Me.lblTrainType.Name = "lblTrainType"
        '
        'txtTrainTypeDescription
        '
        Me.txtTrainTypeDescription.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.txtTrainTypeDescription, "txtTrainTypeDescription")
        Me.txtTrainTypeDescription.Name = "txtTrainTypeDescription"
        '
        'lblCapacity
        '
        resources.ApplyResources(Me.lblCapacity, "lblCapacity")
        Me.lblCapacity.Name = "lblCapacity"
        '
        'gbControlTrainType
        '
        Me.gbControlTrainType.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbControlTrainType.Controls.Add(Me.btnAddTrainType)
        Me.gbControlTrainType.Controls.Add(Me.btnCleanTrainType)
        Me.gbControlTrainType.Controls.Add(Me.btnUpdateTrainType)
        Me.gbControlTrainType.Controls.Add(Me.btnDeleteTrainType)
        resources.ApplyResources(Me.gbControlTrainType, "gbControlTrainType")
        Me.gbControlTrainType.Name = "gbControlTrainType"
        Me.gbControlTrainType.TabStop = False
        '
        'btnAddTrainType
        '
        Me.btnAddTrainType.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnAddTrainType, "btnAddTrainType")
        Me.btnAddTrainType.ImageList = Me.iconList
        Me.btnAddTrainType.Name = "btnAddTrainType"
        Me.btnAddTrainType.UseVisualStyleBackColor = False
        '
        'btnCleanTrainType
        '
        Me.btnCleanTrainType.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnCleanTrainType, "btnCleanTrainType")
        Me.btnCleanTrainType.ImageList = Me.iconList
        Me.btnCleanTrainType.Name = "btnCleanTrainType"
        Me.btnCleanTrainType.UseVisualStyleBackColor = False
        '
        'btnUpdateTrainType
        '
        Me.btnUpdateTrainType.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnUpdateTrainType, "btnUpdateTrainType")
        Me.btnUpdateTrainType.ImageList = Me.iconList
        Me.btnUpdateTrainType.Name = "btnUpdateTrainType"
        Me.btnUpdateTrainType.UseVisualStyleBackColor = False
        '
        'btnDeleteTrainType
        '
        Me.btnDeleteTrainType.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnDeleteTrainType, "btnDeleteTrainType")
        Me.btnDeleteTrainType.ImageList = Me.iconList
        Me.btnDeleteTrainType.Name = "btnDeleteTrainType"
        Me.btnDeleteTrainType.UseVisualStyleBackColor = False
        '
        'lblTrainTypeList
        '
        resources.ApplyResources(Me.lblTrainTypeList, "lblTrainTypeList")
        Me.lblTrainTypeList.Name = "lblTrainTypeList"
        '
        'tabTrains
        '
        Me.tabTrains.BackColor = System.Drawing.Color.LightSlateGray
        Me.tabTrains.Controls.Add(Me.gbTrainsList)
        Me.tabTrains.Controls.Add(Me.gbTrainsBoxes)
        Me.tabTrains.Controls.Add(Me.gbControlTrains)
        resources.ApplyResources(Me.tabTrains, "tabTrains")
        Me.tabTrains.Name = "tabTrains"
        '
        'gbTrainsList
        '
        Me.gbTrainsList.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbTrainsList.Controls.Add(Me.lstViewTrains)
        resources.ApplyResources(Me.gbTrainsList, "gbTrainsList")
        Me.gbTrainsList.Name = "gbTrainsList"
        Me.gbTrainsList.TabStop = False
        '
        'lstViewTrains
        '
        Me.lstViewTrains.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idTrains, Me.trainTypeTrains})
        Me.lstViewTrains.ForeColor = System.Drawing.Color.Black
        Me.lstViewTrains.FullRowSelect = True
        Me.lstViewTrains.HideSelection = False
        resources.ApplyResources(Me.lstViewTrains, "lstViewTrains")
        Me.lstViewTrains.MultiSelect = False
        Me.lstViewTrains.Name = "lstViewTrains"
        Me.lstViewTrains.UseCompatibleStateImageBehavior = False
        Me.lstViewTrains.View = System.Windows.Forms.View.Details
        '
        'idTrains
        '
        resources.ApplyResources(Me.idTrains, "idTrains")
        '
        'trainTypeTrains
        '
        resources.ApplyResources(Me.trainTypeTrains, "trainTypeTrains")
        '
        'gbTrainsBoxes
        '
        Me.gbTrainsBoxes.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbTrainsBoxes.Controls.Add(Me.lblTrainDescription)
        Me.gbTrainsBoxes.Controls.Add(Me.txtTrainID)
        Me.gbTrainsBoxes.Controls.Add(Me.cboxTrain)
        Me.gbTrainsBoxes.Controls.Add(Me.lblTypeTrain)
        resources.ApplyResources(Me.gbTrainsBoxes, "gbTrainsBoxes")
        Me.gbTrainsBoxes.Name = "gbTrainsBoxes"
        Me.gbTrainsBoxes.TabStop = False
        '
        'lblTrainDescription
        '
        resources.ApplyResources(Me.lblTrainDescription, "lblTrainDescription")
        Me.lblTrainDescription.Name = "lblTrainDescription"
        '
        'txtTrainID
        '
        Me.txtTrainID.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.txtTrainID, "txtTrainID")
        Me.txtTrainID.Name = "txtTrainID"
        '
        'cboxTrain
        '
        Me.cboxTrain.BackColor = System.Drawing.SystemColors.Window
        Me.cboxTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboxTrain, "cboxTrain")
        Me.cboxTrain.ForeColor = System.Drawing.Color.Black
        Me.cboxTrain.FormattingEnabled = True
        Me.cboxTrain.Name = "cboxTrain"
        '
        'lblTypeTrain
        '
        resources.ApplyResources(Me.lblTypeTrain, "lblTypeTrain")
        Me.lblTypeTrain.Name = "lblTypeTrain"
        '
        'gbControlTrains
        '
        Me.gbControlTrains.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbControlTrains.Controls.Add(Me.btnAddTrain)
        Me.gbControlTrains.Controls.Add(Me.btnUpdateTrain)
        Me.gbControlTrains.Controls.Add(Me.btnCleanTrain)
        Me.gbControlTrains.Controls.Add(Me.btnDeleteTrain)
        resources.ApplyResources(Me.gbControlTrains, "gbControlTrains")
        Me.gbControlTrains.Name = "gbControlTrains"
        Me.gbControlTrains.TabStop = False
        '
        'btnAddTrain
        '
        Me.btnAddTrain.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnAddTrain, "btnAddTrain")
        Me.btnAddTrain.ImageList = Me.iconList
        Me.btnAddTrain.Name = "btnAddTrain"
        Me.btnAddTrain.UseVisualStyleBackColor = False
        '
        'btnUpdateTrain
        '
        Me.btnUpdateTrain.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnUpdateTrain, "btnUpdateTrain")
        Me.btnUpdateTrain.ImageList = Me.iconList
        Me.btnUpdateTrain.Name = "btnUpdateTrain"
        Me.btnUpdateTrain.UseVisualStyleBackColor = False
        '
        'btnCleanTrain
        '
        Me.btnCleanTrain.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnCleanTrain, "btnCleanTrain")
        Me.btnCleanTrain.ImageList = Me.iconList
        Me.btnCleanTrain.Name = "btnCleanTrain"
        Me.btnCleanTrain.UseVisualStyleBackColor = False
        '
        'btnDeleteTrain
        '
        Me.btnDeleteTrain.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnDeleteTrain, "btnDeleteTrain")
        Me.btnDeleteTrain.ImageList = Me.iconList
        Me.btnDeleteTrain.Name = "btnDeleteTrain"
        Me.btnDeleteTrain.UseVisualStyleBackColor = False
        '
        'tabProduct
        '
        Me.tabProduct.BackColor = System.Drawing.Color.LightSlateGray
        Me.tabProduct.Controls.Add(Me.gbProductsList)
        Me.tabProduct.Controls.Add(Me.gbProductsBoxes)
        Me.tabProduct.Controls.Add(Me.gbControlProducts)
        Me.tabProduct.Controls.Add(Me.lblProductList)
        resources.ApplyResources(Me.tabProduct, "tabProduct")
        Me.tabProduct.Name = "tabProduct"
        '
        'gbProductsList
        '
        Me.gbProductsList.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbProductsList.Controls.Add(Me.lstViewProducts)
        resources.ApplyResources(Me.gbProductsList, "gbProductsList")
        Me.gbProductsList.Name = "gbProductsList"
        Me.gbProductsList.TabStop = False
        '
        'lstViewProducts
        '
        Me.lstViewProducts.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lstViewProducts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Description})
        Me.lstViewProducts.ForeColor = System.Drawing.Color.Black
        Me.lstViewProducts.FullRowSelect = True
        Me.lstViewProducts.HideSelection = False
        resources.ApplyResources(Me.lstViewProducts, "lstViewProducts")
        Me.lstViewProducts.MultiSelect = False
        Me.lstViewProducts.Name = "lstViewProducts"
        Me.lstViewProducts.UseCompatibleStateImageBehavior = False
        Me.lstViewProducts.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        resources.ApplyResources(Me.ID, "ID")
        '
        'Description
        '
        resources.ApplyResources(Me.Description, "Description")
        '
        'gbProductsBoxes
        '
        Me.gbProductsBoxes.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbProductsBoxes.Controls.Add(Me.txtProductDescription)
        Me.gbProductsBoxes.Controls.Add(Me.lblProductDescription)
        resources.ApplyResources(Me.gbProductsBoxes, "gbProductsBoxes")
        Me.gbProductsBoxes.Name = "gbProductsBoxes"
        Me.gbProductsBoxes.TabStop = False
        '
        'txtProductDescription
        '
        Me.txtProductDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtProductDescription.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.txtProductDescription, "txtProductDescription")
        Me.txtProductDescription.Name = "txtProductDescription"
        '
        'lblProductDescription
        '
        resources.ApplyResources(Me.lblProductDescription, "lblProductDescription")
        Me.lblProductDescription.Name = "lblProductDescription"
        '
        'gbControlProducts
        '
        Me.gbControlProducts.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbControlProducts.Controls.Add(Me.btnAddProduct)
        Me.gbControlProducts.Controls.Add(Me.btnCleanProduct)
        Me.gbControlProducts.Controls.Add(Me.btnDeleteProduct)
        Me.gbControlProducts.Controls.Add(Me.btnUpdateProduct)
        resources.ApplyResources(Me.gbControlProducts, "gbControlProducts")
        Me.gbControlProducts.Name = "gbControlProducts"
        Me.gbControlProducts.TabStop = False
        '
        'btnAddProduct
        '
        Me.btnAddProduct.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnAddProduct, "btnAddProduct")
        Me.btnAddProduct.ImageList = Me.iconList
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.UseVisualStyleBackColor = False
        '
        'btnCleanProduct
        '
        Me.btnCleanProduct.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnCleanProduct, "btnCleanProduct")
        Me.btnCleanProduct.ImageList = Me.iconList
        Me.btnCleanProduct.Name = "btnCleanProduct"
        Me.btnCleanProduct.UseVisualStyleBackColor = False
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnDeleteProduct, "btnDeleteProduct")
        Me.btnDeleteProduct.ImageList = Me.iconList
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.UseVisualStyleBackColor = False
        '
        'btnUpdateProduct
        '
        Me.btnUpdateProduct.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnUpdateProduct, "btnUpdateProduct")
        Me.btnUpdateProduct.ImageList = Me.iconList
        Me.btnUpdateProduct.Name = "btnUpdateProduct"
        Me.btnUpdateProduct.UseVisualStyleBackColor = False
        '
        'lblProductList
        '
        resources.ApplyResources(Me.lblProductList, "lblProductList")
        Me.lblProductList.Name = "lblProductList"
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabProduct)
        Me.tabControl.Controls.Add(Me.tabTrains)
        Me.tabControl.Controls.Add(Me.tabTrainTypes)
        Me.tabControl.Controls.Add(Me.tabPrices)
        Me.tabControl.Controls.Add(Me.tabTrips)
        Me.tabControl.Controls.Add(Me.tabQuery)
        resources.ApplyResources(Me.tabControl, "tabControl")
        Me.tabControl.ImageList = Me.iconList
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        '
        'txtPath
        '
        Me.txtPath.BackColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.txtPath, "txtPath")
        Me.txtPath.ForeColor = System.Drawing.Color.Black
        Me.txtPath.Name = "txtPath"
        '
        'btnConnect
        '
        resources.ApplyResources(Me.btnConnect, "btnConnect")
        Me.btnConnect.ImageList = Me.iconList
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        resources.ApplyResources(Me.btnSelect, "btnSelect")
        Me.btnSelect.ImageList = Me.iconList
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'gbDatabase
        '
        Me.gbDatabase.BackColor = System.Drawing.Color.LightSlateGray
        resources.ApplyResources(Me.gbDatabase, "gbDatabase")
        Me.gbDatabase.Controls.Add(Me.btnSelect)
        Me.gbDatabase.Controls.Add(Me.btnConnect)
        Me.gbDatabase.Controls.Add(Me.txtPath)
        Me.gbDatabase.Name = "gbDatabase"
        Me.gbDatabase.TabStop = False
        '
        'esiLogo
        '
        resources.ApplyResources(Me.esiLogo, "esiLogo")
        Me.esiLogo.Name = "esiLogo"
        Me.esiLogo.TabStop = False
        '
        'Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Controls.Add(Me.esiLogo)
        Me.Controls.Add(Me.gbDatabase)
        Me.Controls.Add(Me.tabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.tabQuery.ResumeLayout(False)
        Me.tbpQuerie.ResumeLayout(False)
        Me.tabQuery1.ResumeLayout(False)
        Me.gbSolutionQuery1.ResumeLayout(False)
        Me.gbSolutionQuery1.PerformLayout()
        Me.gbLstViewQuery1.ResumeLayout(False)
        Me.gbSlectionQuery1.ResumeLayout(False)
        Me.gbSlectionQuery1.PerformLayout()
        Me.tabQuery2.ResumeLayout(False)
        Me.gbSelectionQuery2.ResumeLayout(False)
        Me.gbSelectionQuery2.PerformLayout()
        Me.gbQuery2List.ResumeLayout(False)
        Me.tabQuery3.ResumeLayout(False)
        Me.gbQuery3List.ResumeLayout(False)
        Me.gbSelectionPanelQuery3.ResumeLayout(False)
        Me.gbSelectionPanelQuery3.PerformLayout()
        Me.tabQuery4.ResumeLayout(False)
        Me.gbListQuery4.ResumeLayout(False)
        Me.gbListQuery4.PerformLayout()
        Me.tabTrips.ResumeLayout(False)
        Me.gbControlTrip.ResumeLayout(False)
        Me.gbSelectionTrip.ResumeLayout(False)
        Me.gbSelectionTrip.PerformLayout()
        CType(Me.nudTonsTrip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTripList.ResumeLayout(False)
        Me.tabPrices.ResumeLayout(False)
        Me.gbPriceList.ResumeLayout(False)
        Me.gbControlPrices.ResumeLayout(False)
        Me.gbPrices.ResumeLayout(False)
        Me.gbPrices.PerformLayout()
        Me.tabTrainTypes.ResumeLayout(False)
        Me.gbTrainTypeList.ResumeLayout(False)
        Me.gbTrainTypeBoxes.ResumeLayout(False)
        Me.gbTrainTypeBoxes.PerformLayout()
        CType(Me.nudMaxCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbControlTrainType.ResumeLayout(False)
        Me.tabTrains.ResumeLayout(False)
        Me.gbTrainsList.ResumeLayout(False)
        Me.gbTrainsBoxes.ResumeLayout(False)
        Me.gbTrainsBoxes.PerformLayout()
        Me.gbControlTrains.ResumeLayout(False)
        Me.tabProduct.ResumeLayout(False)
        Me.gbProductsList.ResumeLayout(False)
        Me.gbProductsBoxes.ResumeLayout(False)
        Me.gbProductsBoxes.PerformLayout()
        Me.gbControlProducts.ResumeLayout(False)
        Me.tabControl.ResumeLayout(False)
        Me.gbDatabase.ResumeLayout(False)
        Me.gbDatabase.PerformLayout()
        CType(Me.esiLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OfdPath As OpenFileDialog
    Friend WithEvents iconList As ImageList
    Friend WithEvents tabQuery As TabPage
    Friend WithEvents tbpQuerie As TabControl
    Friend WithEvents tabQuery1 As TabPage
    Friend WithEvents gbSolutionQuery1 As GroupBox
    Friend WithEvents lblTripsSolution As Label
    Friend WithEvents txtNumberTripsQuery1 As TextBox
    Friend WithEvents lblNumberTripsQuery1 As Label
    Friend WithEvents gbLstViewQuery1 As GroupBox
    Friend WithEvents lstViewQuery1 As ListView
    Friend WithEvents tripDateQuery1 As ColumnHeader
    Friend WithEvents trainQuery1 As ColumnHeader
    Friend WithEvents productQuery1 As ColumnHeader
    Friend WithEvents gbSlectionQuery1 As GroupBox
    Friend WithEvents dtpDateEndQuery1 As DateTimePicker
    Friend WithEvents lblDateStartQuery As Label
    Friend WithEvents lblDateEnd As Label
    Friend WithEvents lblTrainIdQuery As Label
    Friend WithEvents dtpDateStartQuery1 As DateTimePicker
    Friend WithEvents cboxTrainIdQuery1 As ComboBox
    Friend WithEvents btnExecuteQuery1 As Button
    Friend WithEvents tabQuery2 As TabPage
    Friend WithEvents tabQuery3 As TabPage
    Friend WithEvents tabQuery4 As TabPage
    Friend WithEvents tabTrips As TabPage
    Friend WithEvents gbControlTrip As GroupBox
    Friend WithEvents btnAddTrip As Button
    Friend WithEvents btnCleanTrip As Button
    Friend WithEvents btnDeleteTrip As Button
    Friend WithEvents btnUpdateTrip As Button
    Friend WithEvents gbSelectionTrip As GroupBox
    Friend WithEvents lstboxProductTrip As ListBox
    Friend WithEvents nudTonsTrip As NumericUpDown
    Friend WithEvents cboxTrainTrip As ComboBox
    Friend WithEvents lblTonsTrip As Label
    Friend WithEvents lblTrainTrip As Label
    Friend WithEvents lblProductTrip As Label
    Friend WithEvents lblDateTrip As Label
    Friend WithEvents dtpTrip As DateTimePicker
    Friend WithEvents gbTripList As GroupBox
    Friend WithEvents lstViewTrip As ListView
    Friend WithEvents dateTrip As ColumnHeader
    Friend WithEvents trainTrip As ColumnHeader
    Friend WithEvents productTrip As ColumnHeader
    Friend WithEvents tonsTrip As ColumnHeader
    Friend WithEvents tabPrices As TabPage
    Friend WithEvents gbPriceList As GroupBox
    Friend WithEvents lstViewPrices As ListView
    Friend WithEvents ProductID As ColumnHeader
    Friend WithEvents ProductDescription As ColumnHeader
    Friend WithEvents PriceDate As ColumnHeader
    Friend WithEvents PricePerTon As ColumnHeader
    Friend WithEvents gbControlPrices As GroupBox
    Friend WithEvents btnAddPrices As Button
    Friend WithEvents btnCleanPrices As Button
    Friend WithEvents btnDeletePrices As Button
    Friend WithEvents btnUpdatePrices As Button
    Friend WithEvents gbPrices As GroupBox
    Friend WithEvents lblEuroSymbol As Label
    Friend WithEvents txtEurosPrices As TextBox
    Friend WithEvents lblProductPrices As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents dtpDatePrices As DateTimePicker
    Friend WithEvents cboxProductPrices As ComboBox
    Friend WithEvents lblPricesList As Label
    Friend WithEvents tabTrainTypes As TabPage
    Friend WithEvents gbTrainTypeList As GroupBox
    Friend WithEvents lstViewTrainTypes As ListView
    Friend WithEvents idTrainTypes As ColumnHeader
    Friend WithEvents descriptionTrainTypes As ColumnHeader
    Friend WithEvents capacityTrainTypes As ColumnHeader
    Friend WithEvents gbTrainTypeBoxes As GroupBox
    Friend WithEvents lblTonsTrainType As Label
    Friend WithEvents nudMaxCapacity As NumericUpDown
    Friend WithEvents lblTrainType As Label
    Friend WithEvents txtTrainTypeDescription As TextBox
    Friend WithEvents lblCapacity As Label
    Friend WithEvents gbControlTrainType As GroupBox
    Friend WithEvents btnAddTrainType As Button
    Friend WithEvents btnCleanTrainType As Button
    Friend WithEvents btnUpdateTrainType As Button
    Friend WithEvents btnDeleteTrainType As Button
    Friend WithEvents lblTrainTypeList As Label
    Friend WithEvents tabTrains As TabPage
    Friend WithEvents gbTrainsList As GroupBox
    Friend WithEvents lstViewTrains As ListView
    Friend WithEvents idTrains As ColumnHeader
    Friend WithEvents trainTypeTrains As ColumnHeader
    Friend WithEvents gbTrainsBoxes As GroupBox
    Friend WithEvents lblTrainDescription As Label
    Friend WithEvents txtTrainID As TextBox
    Friend WithEvents cboxTrain As ComboBox
    Friend WithEvents lblTypeTrain As Label
    Friend WithEvents gbControlTrains As GroupBox
    Friend WithEvents btnAddTrain As Button
    Friend WithEvents btnUpdateTrain As Button
    Friend WithEvents btnCleanTrain As Button
    Friend WithEvents btnDeleteTrain As Button
    Friend WithEvents tabProduct As TabPage
    Friend WithEvents gbProductsList As GroupBox
    Friend WithEvents lstViewProducts As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Description As ColumnHeader
    Friend WithEvents gbProductsBoxes As GroupBox
    Friend WithEvents txtProductDescription As TextBox
    Friend WithEvents lblProductDescription As Label
    Friend WithEvents gbControlProducts As GroupBox
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnCleanProduct As Button
    Friend WithEvents btnDeleteProduct As Button
    Friend WithEvents btnUpdateProduct As Button
    Friend WithEvents lblProductList As Label
    Friend WithEvents tabControl As TabControl
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents gbDatabase As GroupBox
    Friend WithEvents btnExecuteQuery2 As Button
    Friend WithEvents gbSelectionQuery2 As GroupBox
    Friend WithEvents lblEndDateQuery2 As Label
    Friend WithEvents lblStartDateQuery2 As Label
    Friend WithEvents dtpEndDateQuery2 As DateTimePicker
    Friend WithEvents dtpStartDateQuery2 As DateTimePicker
    Friend WithEvents gbQuery2List As GroupBox
    Friend WithEvents lstViewQuery2 As ListView
    Friend WithEvents trainType As ColumnHeader
    Friend WithEvents totalTrips As ColumnHeader
    Friend WithEvents btnCleanQuery2 As Button
    Friend WithEvents btnCleanQuery1 As Button
    Friend WithEvents gbQuery3List As GroupBox
    Friend WithEvents lstViewQuery3 As ListView
    Friend WithEvents Product As ColumnHeader
    Friend WithEvents total As ColumnHeader
    Friend WithEvents btnCleanQuery3 As Button
    Friend WithEvents btnExecuteQuery3 As Button
    Friend WithEvents gbSelectionPanelQuery3 As GroupBox
    Friend WithEvents lblEndDateQuery3 As Label
    Friend WithEvents lblStartDateQuery3 As Label
    Friend WithEvents dtpEndDateQuery3 As DateTimePicker
    Friend WithEvents dtpStartDateQuery3 As DateTimePicker
    Friend WithEvents btnCleanQuery4 As Button
    Friend WithEvents btnExecuteQuery4 As Button
    Friend WithEvents gbListQuery4 As GroupBox
    Friend WithEvents lblTripDateQuery4 As Label
    Friend WithEvents txtTripDateQuery4 As TextBox
    Friend WithEvents lstViewQuery4 As ListView
    Friend WithEvents productQuery4 As ColumnHeader
    Friend WithEvents tonsQuery4 As ColumnHeader
    Friend WithEvents productPriceQuery4 As ColumnHeader
    Friend WithEvents profitProductQuery4 As ColumnHeader
    Friend WithEvents txtMaxProfitQuery4 As TextBox
    Friend WithEvents txtTrainTypeQuery4 As TextBox
    Friend WithEvents txtTrainIDQuery4 As TextBox
    Friend WithEvents lblTrainTypeQuery4 As Label
    Friend WithEvents lblMaxProfit As Label
    Friend WithEvents lblTrainIDQuery4 As Label
    Friend WithEvents productPriceDate As ColumnHeader
    Friend WithEvents esiLogo As PictureBox
End Class
